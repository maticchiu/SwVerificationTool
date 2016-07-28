Public Class StepAction_ForceAbortTimer

    Implements StepAction

    Public Function DoCommand(ByRef hwndCurWnd As Integer, curStepInfo As StepDataBase, ByRef strLogMessage As String) As Integer Implements StepAction.DoCommand

        ' Dim StepInfoObj As StepData_System = curStepInfo
        Return True

    End Function

End Class
