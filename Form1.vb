Imports System.Collections.Concurrent
Imports System.Drawing.Imaging
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports OfficeOpenXml
Imports ZXing

Class Form1

    Dim filePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Barcode Generator", "Data", "data.xlsx")
    Dim outputFolder As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Barcode Generator", "Barcode")
    Dim pdfFilePath As String = Path.Combine(outputFolder, "Barcodes.pdf")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial
        Call LoadSettings()

    End Sub

    Private Async Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        If Not File.Exists(filePath) Then
            MessageBox.Show("Tệp data không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim employeeCodes As New List(Of String)()

        Using package As New ExcelPackage(New FileInfo(filePath))
            Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets("Sheet1")

            ' Check whether the Excel file has data or not
            If worksheet.Dimension Is Nothing OrElse worksheet.Dimension.End.Row = 0 Then
                MessageBox.Show("Tệp Excel chưa có dữ liệu, vui lòng nhập dữ liệu vào trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            'Take the first line and add it to employeeCodes
            For i As Integer = 1 To worksheet.Dimension.End.Row
                If Not String.IsNullOrEmpty(worksheet.Cells(i, 1).Text) Then
                    employeeCodes.Add(worksheet.Cells(i, 1).Text.Trim())
                End If
            Next
        End Using

        'Override Confirm?
        If File.Exists(pdfFilePath) Then
            Dim result As DialogResult = MessageBox.Show("Barcode cũ trong file pdf sẽ bị mất và thay bằng barcode mới, Bạn có muốn tiếp tục?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If result = DialogResult.Cancel Then
                Return
            End If
        End If

        Try
            ' Create parallel barcodes - Multi Thread
            Dim barcodeImages As New ConcurrentBag(Of Tuple(Of String, Bitmap))() ' Save barcode img from multi thread
            Parallel.ForEach(employeeCodes, Sub(code)

                                                ' Create BarcodeWriter to create the barcode CODE_128
                                                Dim writer As New BarcodeWriter With {
                                                    .Format = BarcodeFormat.CODE_128,
                                                    .Options = New ZXing.Common.EncodingOptions With {
                                                        .Width = 300,
                                                        .Height = 100
                                                    }
                                                }

                                                ' Use BarcodeWriter to create the barcode from StaffID (code)
                                                Dim img As Bitmap = writer.Write(code)

                                                ' Thêm Tuple (code, img) vào ConcurrentBag barcodeImages
                                                barcodeImages.Add(New Tuple(Of String, Bitmap)(code, img))
                                            End Sub)

            ' Customize margins and spacing
            Dim leftMargin As Single = 1.0F
            Dim rightMargin As Single = 50.0F
            Dim topMargin As Single = 10.0F
            Dim bottomMargin As Single = 0.1F
            Dim cellPaddingTop As Single = 5.0F
            Dim cellPaddingBottom As Single = 5.0F
            Dim cellPaddingLeft As Single = 10.0F
            Dim cellPaddingRight As Single = 10.0F
            Dim barcodeWidth As Single = 150.0F
            Dim barcodeHeight As Single = 50.0F
            Dim numOfCols As Integer = 4 'Quantity of colum in PDF file
            '-----------------------------------

            Using fs As New FileStream(pdfFilePath, FileMode.Create, FileAccess.Write, FileShare.None)
                Dim doc As New Document(PageSize.A4, leftMargin, rightMargin, topMargin, bottomMargin)
                Dim writer As PdfWriter = PdfWriter.GetInstance(doc, fs)
                doc.Open()

                Dim table As New PdfPTable(numOfCols)
                table.WidthPercentage = 100 'table width is 100% of document width (after subtracting margins)
                table.SpacingBefore = 10
                table.SpacingAfter = 10
                table.DefaultCell.Border = Rectangle.NO_BORDER ' Bỏ viền của các ô mặc định trong bảng.

                ' Calculate the available width for each column
                Dim totalWidth As Single = doc.PageSize.Width - leftMargin - rightMargin
                Dim columnWidths(numOfCols - 1) As Single
                For i As Integer = 0 To numOfCols - 1
                    columnWidths(i) = totalWidth / numOfCols
                Next
                table.SetWidths(columnWidths)

                For Each item In barcodeImages
                    Dim imgStream As New MemoryStream() ' Create a memory stream to store the barcode image
                    item.Item2.Save(imgStream, ImageFormat.Png)
                    imgStream.Seek(0, SeekOrigin.Begin)
                    Dim pdfImage As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(imgStream)

                    ' Scale image to fit within the cell while maintaining aspect ratio
                    pdfImage.ScaleToFit(barcodeWidth, barcodeHeight)

                    Dim cell As New PdfPCell(pdfImage) With {
                    .HorizontalAlignment = Element.ALIGN_CENTER,
                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                    .Border = PdfPCell.NO_BORDER,
                    .PaddingTop = cellPaddingTop,
                    .PaddingBottom = cellPaddingBottom,
                    .PaddingLeft = cellPaddingLeft,
                    .PaddingRight = cellPaddingRight
                }
                    table.AddCell(cell)
                Next

                ' Add empty cells if needed to complete the last row
                Dim emptyCells As Integer = numOfCols - (barcodeImages.Count Mod numOfCols)
                If emptyCells < numOfCols Then
                    For i As Integer = 1 To emptyCells
                        Dim emptyCell As New PdfPCell()
                        emptyCell.Border = PdfPCell.NO_BORDER
                        table.AddCell(emptyCell)
                    Next
                End If

                'Save table to PDF
                doc.Add(table)
                doc.Close()
            End Using

            MessageBox.Show("Tạo tệp PDF thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call btn_OpenOutput_Click(sender, e)
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btn_OpenInput_Click(sender As Object, e As EventArgs) Handles btn_OpenInput.Click

        If File.Exists(filePath) Then
            Try
                Process.Start(filePath)
            Catch ex As Exception
                MessageBox.Show($"Không thể mở file data.xlsx:{Environment.NewLine}{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Using package As New ExcelPackage()
                Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets.Add("Sheet1")
                ' Add any default data or structure to the worksheet if needed
                package.SaveAs(New FileInfo(filePath))
            End Using
        End If

    End Sub

    Private Sub btn_OpenOutput_Click(sender As Object, e As EventArgs) Handles btn_OpenOutput.Click

        If File.Exists(pdfFilePath) Then
            Try
                Process.Start(pdfFilePath)
            Catch ex As Exception
                MessageBox.Show($"Không thể mở file PDF:{Environment.NewLine}{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("File PDF không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

End Class