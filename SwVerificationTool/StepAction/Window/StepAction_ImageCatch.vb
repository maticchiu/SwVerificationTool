Public Class StepAction_ImageCatch

    Implements StepAction

    Public Function DoCommand(ByRef hwndCurWnd As Integer, curStepInfo As StepDataBase, ByRef strLogMessage As String) As Integer Implements StepAction.DoCommand

        Dim StepInfoObj As StepData_Window = curStepInfo
        Dim strTime As String = Format(Now(), "yyyyMMdd_HHmmss")
        Dim strImageName As String
        Dim posAbsPosition As Point
        Dim strFullPath As String = StepInfoObj.strTypeString

        If strFullPath.Length > 0 Then

            If strFullPath.Chars(strFullPath.Length - 1) <> "/" And strFullPath.Chars(strFullPath.Length - 1) <> "\" Then
                strFullPath = strFullPath & "\"
            End If

            Utility.CreateFolder(strFullPath)

        End If

        posAbsPosition = Utility.AbsPositionGet(hwndCurWnd, StepInfoObj.posPosition)
        strImageName = curStepInfo.strStepName + "_" + strTime + ".jpg"
        strFullPath = strFullPath & strImageName
        Utility.SaveScreenImage(posAbsPosition, StepInfoObj.sizeImgSize, strFullPath)
        strLogMessage = vbTab & " - Saved image name: " & strImageName

        Return True
    End Function

End Class
