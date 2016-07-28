﻿Public Class StepAction_MouseClick_Right

    Implements StepAction

    Public Function DoCommand(ByRef hwndCurWnd As Integer, curStepInfo As StepDataBase, ByRef strLogMessage As String) As Integer Implements StepAction.DoCommand
        Dim StepInfoObj As StepData_Window = curStepInfo
        Dim posAbsPosition As Point
        Dim CurWndHandle As Integer = hwndCurWnd

        ' if need to set temporary window handle
        If StepInfoObj.strWindowTitle <> "" Or StepInfoObj.strWindowClass <> "" Then

            Dim tempWndHandle As Integer = Utility.GetWindowHandle(StepInfoObj.strWindowTitle, StepInfoObj.strWindowClass)

            If tempWndHandle <> 0 Then
                CurWndHandle = tempWndHandle
            End If

        End If

        posAbsPosition = Utility.AbsPositionGet(CurWndHandle, StepInfoObj.posPosition)
        Utility.MouseClick_Right(posAbsPosition.X, posAbsPosition.Y)

        Return True
    End Function
End Class
