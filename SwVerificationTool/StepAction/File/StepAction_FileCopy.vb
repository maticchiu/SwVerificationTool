Public Class StepAction_FileCopy

    Implements StepAction

    Public Function DoCommand(ByRef hwndCurWnd As Integer, curStepInfo As StepDataBase, ByRef strLogMessage As String) As Integer Implements StepAction.DoCommand
        Dim StepInfoObj As StepData_File = curStepInfo
        Try
            System.IO.File.Copy(StepInfoObj.strFileSourcePath, StepInfoObj.strFileDestPath)
        Catch ex As Exception
            MessageBox.Show("File Copy Error." & ex.Message)
        End Try

        strLogMessage = "Copy file from (" & StepInfoObj.strFileSourcePath & ") to (" & StepInfoObj.strFileDestPath & ")"

        Return True
    End Function

End Class
