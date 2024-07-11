Imports System.IO

Module LoadSetting

    Public settingsFile As String = "Settings.ini"
    Public sourcePath As String
    Public inputPath As String
    Public inputFile As String
    Public outputPath As String
    Public ProjectPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)   'My Documents

    Sub LoadSettings()

        sourcePath = ProjectPath & GetSettingItem(settingsFile, "sourcePath")   '\Barcode Generator
        inputPath = sourcePath & GetSettingItem(settingsFile, "inputPath")      '\Barcode Generator\Data
        inputFile = Path.Combine(inputPath, "data.xlsx")                        '\Data\data.xlsx
        outputPath = sourcePath & GetSettingItem(settingsFile, "outputPath")    '\Barcode Generator\Barcode

        Call Create_Path(sourcePath)
        Call Create_Path(inputPath)
        Call Create_Path(outputPath)

    End Sub

    Function GetSettingItem(ByVal file As String, ByVal searchItem As String) As String

        'get setting value for variable
        Dim result = ""
        For Each line In System.IO.File.ReadLines(file)             'Pass=abc123
            If line.ToLower.Contains(searchItem.ToLower & "=") Then 'pass=
                result = line.Substring(searchItem.Length + 1)      '->abc123
                Exit For
            End If
        Next
        Return result

    End Function

    Sub Create_Path(ByVal path)

        Try
            If Directory.Exists(path) = False Then
                Directory.CreateDirectory(path)
            End If
        Catch ex As Exception

        End Try

    End Sub

End Module