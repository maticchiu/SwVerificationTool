Public Class StepAction_WindowDetection

    Implements StepAction

    Public Function DoCommand(ByRef hwndCurWnd As Integer, curStepInfo As StepDataBase, ByRef strLogMessage As String) As Integer Implements StepAction.DoCommand

        Dim StepInfoObj As StepData_Window = curStepInfo
        Dim iWndHandle As Integer = 0

        Dim strWndTitle As String
        Dim strWndClass As String

        Dim bStepPass As Boolean = True

        strWndTitle = StepInfoObj.strWindowTitle
        If strWndTitle = "" Then
            strWndTitle = Nothing
        End If
        strWndClass = StepInfoObj.strWindowClass
        If strWndClass = "" Then
            strWndClass = Nothing
        End If

        iWndHandle = Utility.FindWindow(strWndClass, strWndTitle)

        If iWndHandle = 0 Then
            bStepPass = False
        End If

        Return bStepPass
    End Function

End Class
