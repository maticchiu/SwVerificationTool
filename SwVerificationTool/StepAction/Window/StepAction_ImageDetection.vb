Public Class StepAction_ImageDetection

    Implements StepAction

    Public Function DoCommand(ByRef hwndCurWnd As Integer, curStepInfo As StepDataBase, ByRef strLogMessage As String) As Integer Implements StepAction.DoCommand

        Dim bStepPass As Boolean = True

        ' Access parameters from StepInfo
        Dim StepInfoObj As StepData_Window = curStepInfo
        Dim WndTitle As String = StepInfoObj.strWindowTitle
        Dim WndClass As String = StepInfoObj.strWindowClass
        Dim strFileName As String = StepInfoObj.strTypeString
        Dim posControlImage_Relative As Point = StepInfoObj.posPosition
        Dim WndHandle As Integer = Utility.GetWindowHandle(WndTitle, WndClass)
        Dim posControlImage_Absolute As Point = Utility.AbsPositionGet(WndHandle, posControlImage_Relative)

        ' Get control image from file of user setting
        Dim bmpControlImage As New Bitmap(strFileName)

        ' Get screen image from screen
        Dim bmpScreenImage As New Bitmap(bmpControlImage.Size.Width, bmpControlImage.Size.Height)
        Dim g As Graphics = Graphics.FromImage(bmpScreenImage)
        g.CopyFromScreen(posControlImage_Absolute, New Size(0, 0), bmpControlImage.Size)

        ' Check and save any difference between 2 images.
        Dim bmpDiff As Bitmap = New Bitmap(bmpControlImage.Width, bmpControlImage.Height)
        For x As Integer = 0 To bmpControlImage.Width - 1
            For y As Integer = 0 To bmpControlImage.Height - 1

                If bmpControlImage.GetPixel(x, y) <> bmpScreenImage.GetPixel(x, y) Then
                    bmpDiff.SetPixel(x, y, Color.White)
                    bStepPass = False
                Else
                    bmpDiff.SetPixel(x, y, Color.Black)
                End If

            Next
        Next

        ' If any difference, save images
        If bStepPass = False Then
            Dim FileName_NoExt As String = System.IO.Path.GetFileNameWithoutExtension(strFileName)
            Dim ExtensionName As String = System.IO.Path.GetExtension(strFileName)
            Dim CurTime As String = Now.ToString("yyyyMMddHHmmss")
            Utility.CreateFolder("./ImageDiff/")
            bmpControlImage.Save("./ImageDiff/" & FileName_NoExt & "_OK_" & CurTime & ".jpg", Imaging.ImageFormat.Jpeg)
            bmpScreenImage.Save("./ImageDiff/" & FileName_NoExt & "_NG_" & CurTime & ".jpg", Imaging.ImageFormat.Jpeg)
            bmpDiff.Save("./ImageDiff/" & FileName_NoExt & "_DIFF_" & CurTime & ".jpg", Imaging.ImageFormat.Jpeg)
        End If

        ' Don't forget release to avoid memory leak
        bmpControlImage.Dispose()
        bmpScreenImage.Dispose()
        g.Dispose()

        Return bStepPass
    End Function
End Class
