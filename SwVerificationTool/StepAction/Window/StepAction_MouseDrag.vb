Public Class StepAction_MouseDrag

    Implements StepAction

    Public Function DoCommand(ByRef hwndCurWnd As Integer, curStepInfo As StepDataBase, ByRef strLogMessage As String) As Integer Implements StepAction.DoCommand
        Dim StepInfoObj As StepData_Window = curStepInfo
        Dim posAbsPosition_MouseDown As Point
        Dim posAbsPosition_MouseUp As Point
        Dim CurWndHandle As Integer = hwndCurWnd

        ' if need to set temporary window handle
        If StepInfoObj.strWindowTitle <> "" Or StepInfoObj.strWindowClass <> "" Then

            Dim tempWndHandle As Integer = Utility.GetWindowHandle(StepInfoObj.strWindowTitle, StepInfoObj.strWindowClass)

            If tempWndHandle <> 0 Then
                CurWndHandle = tempWndHandle
            End If

        End If

        posAbsPosition_MouseDown = Utility.AbsPositionGet(CurWndHandle, StepInfoObj.posPosition)
        posAbsPosition_MouseUp = Utility.AbsPositionGet(CurWndHandle, StepInfoObj.posPositionUp)
        Utility.MouseDrag(posAbsPosition_MouseDown, posAbsPosition_MouseUp)

        Return True
    End Function

End Class
