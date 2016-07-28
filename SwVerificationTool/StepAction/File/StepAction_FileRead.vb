Public Class StepAction_FileRead

    Implements StepAction

    Public Function DoCommand(ByRef hwndCurWnd As Integer, curStepInfo As StepDataBase, ByRef strLogMessage As String) As Integer Implements StepAction.DoCommand
        Dim StepInfoObj As StepData_File = curStepInfo
        Dim strFileContent As String = ""
        Try
            Dim objReader As New System.IO.StreamReader(StepInfoObj.strFileSourcePath)

            strFileContent = objReader.ReadToEnd()
            'MainFormData.SvarSet(curStepInfo.iFileReadSvarIndex, strFileContent)
            MainFormData.SVAR(StepInfoObj.iFileReadSvarIndex) = strFileContent

            objReader.Close()
        Catch ex As Exception
            MessageBox.Show("File Read Error." & ex.Message)
        End Try

        strLogMessage = "Read file: " & strFileContent

        Return True
    End Function

End Class
