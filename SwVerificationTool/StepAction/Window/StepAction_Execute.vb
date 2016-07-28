Public Class StepAction_Execute

    Implements StepAction

    Public Function DoCommand(ByRef hwndCurWnd As Integer, curStepInfo As StepDataBase, ByRef strLogMessage As String) As Integer Implements StepAction.DoCommand

        Dim StepInfoObj As StepData_Window = curStepInfo
        Dim sFileFullPath As String = StepInfoObj.strTypeString

        If Not My.Computer.FileSystem.FileExists(sFileFullPath) Then
            strLogMessage = "The file (" + sFileFullPath + ") doesn't exist."
            MessageBox.Show(strLogMessage)
            Return False
        End If

        Process.Start(StepInfoObj.strTypeString)

        Return True
    End Function

End Class
