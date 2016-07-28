Public Class StepAction_TypeString

    Implements StepAction

    Public Function DoCommand(ByRef hwndCurWnd As Integer, curStepInfo As StepDataBase, ByRef strLogMessage As String) As Integer Implements StepAction.DoCommand

        Dim StepInfoObj As StepData_Window = curStepInfo
        SendKeys.Send(StepInfoObj.strTypeString)

        Return True
    End Function

End Class
