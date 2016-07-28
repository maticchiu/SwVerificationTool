Public Class FileVersionControl

    'Private CurVersion As Integer = 1

    Private Shared Function DataConvert_Ver0000(strContent As String) As String
        strContent = strContent.Replace("Image Detection", "Pixel Detection")
        Return strContent
    End Function

    Private Shared Function DoDataConvert(iFileVersion As Integer, iLatestVersion As Integer, strContent As String) As String

        Dim strNewContent As String = ""

        Select Case iFileVersion

            Case 0
                strNewContent = DataConvert_Ver0000(strContent)
                iFileVersion = iFileVersion + 1
        End Select

        If iFileVersion < iLatestVersion Then
            strNewContent = DoDataConvert(iFileVersion, iLatestVersion, strNewContent)
        End If

        Return strNewContent

    End Function

    Private Shared Function GetDataVersion(strFileFullPath As String) As Integer

        If Not System.IO.File.Exists(strFileFullPath) Then

            MessageBox.Show("File " & strFileFullPath & " doesn't exist." & vbNewLine & _
                            "Please check it.")
            Return -1
        End If

        Dim fDataRead As New System.IO.StreamReader(strFileFullPath)
        Dim strOneLineData As String
        Dim iVersion As Integer = 0

        Do While fDataRead.Peek >= 0

            strOneLineData = fDataRead.ReadLine()
            strOneLineData = strOneLineData.Replace(" ", "")

            ' Cannot find data version -> version = 0
            If strOneLineData.Chars(0) <> "#" And strOneLineData.Length > 3 Then
                Exit Do
            End If

            If strOneLineData.Contains("#Version=") Then

                iVersion = Convert.ToInt32(strOneLineData.Substring(9))
                Exit Do

            End If

        Loop

        fDataRead.Close()

        Return iVersion

    End Function

    Public Shared Sub StepInfoDataConvert(ByVal strFileFullPath As String, ByVal iLatestVersion As Integer)

        Dim iFileVersion As Integer = GetDataVersion(strFileFullPath)

        If iFileVersion >= 0 And iFileVersion < iLatestVersion Then

            ' Backup the current file
            Dim strOldDataPath As String = strFileFullPath & ".Version" & iFileVersion.ToString.PadLeft(4, "0") & ".bak"
            System.IO.File.Copy(strFileFullPath, strOldDataPath, True)

            Dim fOldDataRead As New System.IO.StreamReader(strFileFullPath)
            Dim strDataContent As String = fOldDataRead.ReadToEnd()
            fOldDataRead.Close()

            Dim strNewDataContent As String = ""

            ' Convert data
            strNewDataContent = DoDataConvert(iFileVersion, iLatestVersion, strDataContent)

            Dim fNewDataWrite As New System.IO.StreamWriter(strFileFullPath)

            If strNewDataContent.Contains("# Version = ") Then
                strNewDataContent.Replace("# Version = " & iFileVersion, "# Version = " & iLatestVersion)
            Else
                fNewDataWrite.Write("# Version = " & iLatestVersion.ToString.PadLeft(4, "0") & vbNewLine & vbNewLine)
            End If

            fNewDataWrite.Write(strNewDataContent)
            fNewDataWrite.Close()

            MessageBox.Show("The latest version: " & iLatestVersion & vbNewLine & _
                            "Backup file to " & strOldDataPath)

        End If

    End Sub

 

End Class
