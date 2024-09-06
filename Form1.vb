Imports System.Drawing.Imaging
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports ZXing
Imports ZXing.Common

Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call LoadSettings()

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        'check data.txt file exist
        If Not File.Exists(inputFile) Then
            MessageBox.Show("File data.txt không tồn tại!")
            Exit Sub
        End If

        Dim employeeID_list As New List(Of String)()
        Try
            'CREATE THE EMPLOYEE_ID LIST
            For Each employeeID In File.ReadAllLines(inputFile)
                If employeeID <> "" Then
                    employeeID_list.Add(employeeID.Trim().ToUpper) ' Add ID into list
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error: Không thể đọc file " & ex.Message)

        End Try

        'CHECK DATA FILE EMPTY
        If employeeID_list.Count = 0 Then
            MessageBox.Show("data.txt chưa có dữ liệu! Hãy thêm dữ liệu đầu vào trước! ")
            Process.Start(inputPath)
            Exit Sub
        End If

        '------------------------------------------------------

        Try
            'CREATE BARCODES LIST FROM EMPLOYEE ID LIST
            Dim barcodesList As New List(Of Tuple(Of String, Bitmap))() ' Save barcode img

            For Each EmployeeID In employeeID_list
                ' Create BarcodeWriter to create the barcode CODE_128
                Dim writer As New BarcodeWriter With {
                    .Format = BarcodeFormat.CODE_128,
                    .Options = New EncodingOptions With {
                        .Width = 400,
                        .Height = 150,
                        .PureBarcode = True ' Remove text below barcode
                    }
                }
                ' Use BarcodeWriter to create the barcode from StaffID (code)
                Dim img As Bitmap = writer.Write(EmployeeID)

                ' Add Tuple (code, img) to list barcodesList
                barcodesList.Add(New Tuple(Of String, Bitmap)(EmployeeID, img))
            Next

            '------------------------------------------------------

            ' Customize margins and spacing
            Dim leftMargin As Single = 0F
            Dim rightMargin As Single = 30.0F
            Dim topMargin As Single = 0.1F
            Dim bottomMargin As Single = 0F
            Dim cellPaddingLeft As Single = 2.0F
            Dim cellPaddingRight As Single = 2.0F
            Dim cellPaddingTop As Single = 5.0F
            Dim cellPaddingBottom As Single = 5.0F
            Dim barcodeWidth As Single = 150.0F
            Dim barcodeHeight As Single = 50.0F
            Dim numOfCols As Integer = 5 'Quantity of colum in PDF file

            Using fs As New FileStream(outputFile, FileMode.Create, FileAccess.Write, FileShare.None)

                Dim doc As New Document(PageSize.A4, leftMargin, rightMargin, topMargin, bottomMargin)
                Dim writer As PdfWriter = PdfWriter.GetInstance(doc, fs)
                doc.Open()

                ' Using PdfPTable to arrange barcodes
                Dim table As New PdfPTable(numOfCols)
                table.WidthPercentage = 100 ' Set table width to 100% of the document width
                table.SpacingBefore = 0
                table.SpacingAfter = 0

                ' Calculate the available width for each column
                Dim totalWidth As Single = doc.PageSize.Width - leftMargin - rightMargin
                Dim columnWidths(numOfCols - 1) As Single

                For i As Integer = 0 To numOfCols - 1
                    columnWidths(i) = totalWidth / numOfCols
                Next

                table.SetWidths(columnWidths)

                'CREATE THE BARCODES TABLE
                '---------------------------------
                For Each item In barcodesList

                    Dim imgStream As New MemoryStream() ' Create a memory stream to store the barcode image
                    item.Item2.Save(imgStream, ImageFormat.Png)
                    imgStream.Seek(0, SeekOrigin.Begin)
                    Dim pdfImage As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(imgStream)
                    pdfImage.ScaleToFit(barcodeWidth, barcodeHeight)

                    ' Create a cell for the barcode image
                    Dim barcodeCell As New PdfPCell(pdfImage) With {
                        .HorizontalAlignment = Element.ALIGN_CENTER,
                        .VerticalAlignment = Element.ALIGN_MIDDLE,
                        .Border = PdfPCell.NO_BORDER,
                        .PaddingTop = cellPaddingTop,
                        .PaddingBottom = 0, ' Set to 0 to reduce the gap between barcode and label
                        .PaddingLeft = cellPaddingLeft,
                        .PaddingRight = cellPaddingRight
                    }

                    ' Create a cell for the custom label
                    Dim fontSize As Single = 8.0F ' Set your desired font size here
                    Dim font As New Font(Font.FontFamily.HELVETICA, fontSize, Font.NORMAL)
                    Dim labelCell As New PdfPCell(New Phrase(item.Item1, font)) With {
                        .HorizontalAlignment = Element.ALIGN_CENTER,
                        .VerticalAlignment = Element.ALIGN_TOP,
                        .Border = PdfPCell.NO_BORDER,
                        .PaddingTop = 0, ' Set to 0 to reduce the gap between barcode and label
                        .PaddingBottom = cellPaddingBottom,
                        .PaddingLeft = 25.0F,
                        .PaddingRight = cellPaddingRight
                    }

                    ' Create a nested table to combine the barcode and label cells
                    Dim nestedTable As New PdfPTable(1)
                    nestedTable.WidthPercentage = 100
                    nestedTable.AddCell(barcodeCell)
                    nestedTable.AddCell(labelCell)

                    ' Add the nested table to the main table
                    Dim cell As New PdfPCell(nestedTable) With {
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

                'ADD EMPTY CELLS TO TABLE
                'Add empty cells if needed to complete the last row of table
                Dim emptyCells As Integer = numOfCols - (barcodesList.Count Mod numOfCols)
                If emptyCells < numOfCols Then
                    For i As Integer = 1 To emptyCells
                        Dim emptyCell As New PdfPCell()
                        emptyCell.Border = PdfPCell.NO_BORDER
                        table.AddCell(emptyCell)
                    Next
                End If

                '----------------------------------------------------------

                'ADD TABLE TO DOCUMENT
                doc.Add(table)
                doc.Close()

            End Using

            MessageBox.Show("Tạo File PDF thành công!")
            Process.Start(outputFile)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

End Class