Public Class StepAction_WindowSet

    Implements StepAction

    Public Function DoCommand(ByRef hwndCurWnd As Integer, curStepInfo As StepDataBase, ByRef strLogMessage As String) As Integer Implements StepAction.DoCommand

        Dim StepInfoObj As StepData_Window = curStepInfo

        hwndCurWnd = Utility.GetWindowHandle(StepInfoObj.strWindowTitle, StepInfoObj.strWindowClass)

        Utility.SetForegroundWindow(hwndCurWnd)

        strLogMessage = vbTab & " - Current window handle: " & hwndCurWnd

        Return True
    End Function

End Class
