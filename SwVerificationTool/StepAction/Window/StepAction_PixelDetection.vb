Public Class StepAction_PixelDetection

    Implements StepAction

    Public Function DoCommand(ByRef hwndCurWnd As Integer, curStepInfo As StepDataBase, ByRef strLogMessage As String) As Integer Implements StepAction.DoCommand

        Dim StepInfoObj As StepData_Window = curStepInfo
        Dim posDetectedPixel As Point
        Dim posAbsPosition As Point
        Dim bStepPass As Boolean = False

        posAbsPosition = Utility.AbsPositionGet(hwndCurWnd, StepInfoObj.posPosition)
        strLogMessage = vbTab & " - AbsPos:(" & posAbsPosition.X & "," & posAbsPosition.Y & ")" + vbNewLine + _
                        vbTab & " - ImgSize:(" & StepInfoObj.sizeImgSize.Width & "," & StepInfoObj.sizeImgSize.Height & ")"

        posDetectedPixel = Utility.DetectColorPosition(posAbsPosition, StepInfoObj.sizeImgSize, StepInfoObj.colorPixelHiLim, StepInfoObj.colorPixelLowLim)

        If posDetectedPixel.X <> -1 And posDetectedPixel.Y <> -1 Then
            bStepPass = True
        End If

        Return bStepPass
    End Function

End Class
