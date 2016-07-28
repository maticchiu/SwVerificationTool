Public Class StepAction_MouseClick_Color

    Implements StepAction

    Public Function DoCommand(ByRef hwndCurWnd As Integer, curStepInfo As StepDataBase, ByRef strLogMessage As String) As Integer Implements StepAction.DoCommand

        Dim StepInfoObj As StepData_Window = curStepInfo
        Dim posDetectedPixel As Point
        Dim bStepPass As Boolean = False
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

        posDetectedPixel = Utility.DetectColorPosition(posAbsPosition, StepInfoObj.sizeImgSize, StepInfoObj.colorPixelHiLim, StepInfoObj.colorPixelLowLim)

        If posDetectedPixel.X <> -1 And posDetectedPixel.Y <> -1 Then
            bStepPass = True
            Utility.MouseClick(posDetectedPixel.X, posDetectedPixel.Y)
        End If

        strLogMessage = vbTab & " - AbsPos:(" & posAbsPosition.X & "," & posAbsPosition.Y & ")" + vbNewLine + _
                        vbTab & " - ImgSize:(" & StepInfoObj.sizeImgSize.Width & "," & StepInfoObj.sizeImgSize.Height & ")" + vbNewLine + _
                        vbTab & " - ClickPos:(" & posDetectedPixel.X & "," & posDetectedPixel.Y & ")"

        Return True
    End Function

End Class
