Public Class StepAction_MouseScroll

    Implements StepAction

    Public Function DoCommand(ByRef hwndCurWnd As Integer, curStepInfo As StepDataBase, ByRef strLogMessage As String) As Integer Implements StepAction.DoCommand
        Dim StepInfoObj As StepData_Window = curStepInfo
        Dim posMouse As Point
        Dim CurWndHandle As Integer = hwndCurWnd

        ' if need to set temporary window handle
        If StepInfoObj.strWindowTitle <> "" Or StepInfoObj.strWindowClass <> "" Then

            Dim tempWndHandle As Integer = Utility.GetWindowHandle(StepInfoObj.strWindowTitle, StepInfoObj.strWindowClass)

            If tempWndHandle <> 0 Then
                CurWndHandle = tempWndHandle
            End If

        End If

        posMouse = Utility.AbsPositionGet(CurWndHandle, StepInfoObj.posPosition)
        Utility.MouseWheel(posMouse, StepInfoObj.iScrollCount)

        Return True
    End Function

End Class
