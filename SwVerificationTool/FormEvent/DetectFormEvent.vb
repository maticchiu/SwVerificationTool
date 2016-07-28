Public Class DetectFormEvent

    Private Sub ShowStatus(strMessage As String)

        ToolStripStatusLabel_DetectForm.Text = Now & " - " & strMessage

    End Sub

    Private Sub HotKey_Detection()
        Dim bHitKey As Boolean = False

        If (Utility.GetAsyncKeyState(Keys.S) And &H8000) = &H8000 Then

            Button_Detect.PerformClick()

            'ElseIf (Utility.GetAsyncKeyState(Keys.W) And &H8000) = &H8000 Then
            '    CheckBox_Detect_LockWnd.Checked = Not CheckBox_Detect_LockWnd.Checked
            bHitKey = True
        ElseIf (Utility.GetAsyncKeyState(Keys.C) And &H8000) = &H8000 Then

            If TextBox_Color_X.Text = "" Then
                TextBox_Color_X.Text = TextBox_Axis_X.Text
            Else
                TextBox_Color_X.Text = ""
            End If

            If TextBox_Color_Y.Text = "" Then
                TextBox_Color_Y.Text = TextBox_Axis_Y.Text
            Else
                TextBox_Color_Y.Text = ""
            End If

            ShowStatus("Get color")
            bHitKey = True
            'ElseIf (Utility.GetAsyncKeyState(Keys.T) And &H8000) = &H8000 Then
            '    CheckBox_TempWinHandle.Checked = Not CheckBox_TempWinHandle.Checked

        ElseIf (Utility.GetAsyncKeyState(Keys.R) And &H8000) = &H8000 Then

            If TextBox_Relative_X_BottomRight.Text <> "" Or TextBox_Relative_Y_BottomRight.Text <> "" Then
                TextBox_Relative_X_BottomRight.Text = ""
                TextBox_Relative_Y_BottomRight.Text = ""
            Else
                TextBox_Relative_X_BottomRight.Text = TextBox_Relative_X.Text
                TextBox_Relative_Y_BottomRight.Text = TextBox_Relative_Y.Text
            End If
            bHitKey = True
            'Threading.Thread.Sleep(100)

        ElseIf ComboBox_CommandType.Text = "Image Detection" And CheckBox_LockName.Checked Then

            If (Utility.GetAsyncKeyState(Keys.D1) And &H8000) = &H8000 Then

                TextBox_TopLeft_X.Text = TextBox_Axis_X.Text
                TextBox_TopLeft_Y.Text = TextBox_Axis_Y.Text

                ShowStatus("ImageDetect1 (TopLeft)")
                bHitKey = True
            ElseIf (Utility.GetAsyncKeyState(Keys.D2) And &H8000) = &H8000 Then

                TextBox_BottomRight_X.Text = TextBox_Axis_X.Text
                TextBox_BottomRight_Y.Text = TextBox_Axis_Y.Text

                ShowStatus("ImageDetect2 (BottomRight)")
                bHitKey = True
            ElseIf (Utility.GetAsyncKeyState(Keys.D3) And &H8000) = &H8000 Then

                If CheckBox_LockName.Checked Then

                    Dim posStartPos As Point
                    Dim sizeImg As Size

                    posStartPos.X = Convert.ToInt32(TextBox_TopLeft_X.Text)
                    posStartPos.Y = Convert.ToInt32(TextBox_TopLeft_Y.Text)

                    sizeImg.Width = Convert.ToInt32(TextBox_BottomRight_X.Text) - Convert.ToInt32(TextBox_TopLeft_X.Text)
                    sizeImg.Height = Convert.ToInt32(TextBox_BottomRight_Y.Text) - Convert.ToInt32(TextBox_TopLeft_Y.Text)

                    Dim strDirectoryName As String = System.IO.Path.GetDirectoryName(TextBox_SaveImageName.Text)
                    Utility.CreateFolder(strDirectoryName)

                    Utility.SaveScreenImage(posStartPos, sizeImg, TextBox_SaveImageName.Text)
                Else
                    MessageBox.Show("Please lock name before saving image.")
                End If
                bHitKey = True
                ShowStatus("ImageDetect3 (SaveImage)")

            ElseIf (Utility.GetAsyncKeyState(Keys.D4) And &H8000) = &H8000 Then

                Button_Duplicate.PerformClick()
                TextBox_TypeString.Text = TextBox_SaveImageName.Text
                TextBox_Position.Text = "(" + TextBox_TopLeft_X.Text + "," + TextBox_TopLeft_Y.Text + ")"

                TextBox_TopLeft_X.Text = ""
                TextBox_TopLeft_Y.Text = ""

                TextBox_BottomRight_X.Text = ""
                TextBox_BottomRight_Y.Text = ""

                TextBox_SaveImageName.Text = "./"
                CheckBox_LockName.Checked = False

                ShowStatus("ImageDetect4 (Duplicate && Clear Data)")
                bHitKey = True
            End If

            'ElseIf ComboBox_CommandType.Text = "Mouse Scroll" Then

            'If (Utility.GetAsyncKeyState() And &H8000) = &H8000 Then

            'End If

        End If

        If bHitKey Then
            Threading.Thread.Sleep(100)
        End If

        'Return iHitKey
    End Sub

    Private Sub DetectForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        DetectFormData.Init()

        CheckBox_Detect_LockWnd.Checked = True
        ComboBox_CommandType.SelectedIndex = 0

        ComboBox_VARIndex.SelectedIndex = 0
        ComboBox_VARsIndex.SelectedIndex = 0
        ComboBox_VAR_Operator.SelectedIndex = 0
        ComboBox_SVARIndex.SelectedIndex = 0

        ComboBox_WatchDogIndex.SelectedIndex = 0

        'AppStepUI.StepUISetting(MainFormData.CommandType.MOUSE_CLICK)

    End Sub

    Private Sub Timer_Detect_Tick(sender As Object, e As EventArgs) Handles Timer_Detect.Tick

        Static CurWinHandle As Integer = 0
        Dim CurWndRect As Rectangle = New Rectangle(0, 0, 0, 0)
        Dim CursorPos As Point

        CursorPos.X = MousePosition.X
        CursorPos.Y = MousePosition.Y
        TextBox_Axis_X.Text = CursorPos.X
        TextBox_Axis_Y.Text = CursorPos.Y

        'TextBox_Axis_X.Text = MousePosition.X
        'TextBox_Axis_Y.Text = MousePosition.Y

        If Not CheckBox_Detect_LockWnd.Checked Then
            CurWinHandle = 0
            CurWinHandle = Utility.WindowFromPoint(CursorPos.X, CursorPos.Y)
        End If

        ' Get title and class of detected window
        Dim strWndClass As String = New String(Chr(0), 256)
        Dim strWndTitle As String = New String(Chr(0), 256)

        If CurWinHandle Then
            Utility.GetWindowRect(CurWinHandle, CurWndRect)

            strWndTitle = Utility.GetWindowTitle(CurWinHandle)
            strWndClass = Utility.GetWindowClass(CurWinHandle)
        End If

        TextBox_Detect_WndTitle.Text = strWndTitle.ToString
        TextBox_Detect_WndClass.Text = strWndClass.ToString

        ' Coordinate of relative position
        TextBox_Relative_X.Text = CursorPos.X - CurWndRect.Left
        TextBox_Relative_Y.Text = CursorPos.Y - CurWndRect.Top

        ' Get color from position of cursor
        Dim posColor As Point = New Point(CursorPos)
        Dim colorPixel As Color

        If TextBox_Color_X.Text <> "" And TextBox_Color_Y.Text <> "" Then
            posColor = Utility.Position_Str2Pos("(" & TextBox_Color_X.Text & "," & TextBox_Color_Y.Text & ")")
        End If

        colorPixel = Utility.PixelColorGet(posColor)

        TextBox_Detect_Color.Text = "(" + colorPixel.R.ToString + "," + colorPixel.G.ToString + "," + colorPixel.B.ToString + ")"


        HotKey_Detection()

    End Sub


    Private Sub Button_Detect_Click(sender As Object, e As EventArgs) Handles Button_Detect.Click

        If Timer_Detect.Enabled Then

            Timer_Detect.Enabled = False
            Button_Detect.BackColor = Color.RosyBrown
            ShowStatus("Step detecting")

        Else

            Timer_Detect.Interval = 100
            Timer_Detect.Enabled = True
            Button_Detect.BackColor = Color.GreenYellow
            ShowStatus("Start to detect")

        End If

    End Sub

    Private Sub Button_Duplicate_Click(sender As Object, e As EventArgs) Handles Button_Duplicate.Click

        TextBox_Position.Text = "(" + TextBox_Relative_X.Text + "," + TextBox_Relative_Y.Text + ")"
        TextBox_Position_Up.Text = "(" + TextBox_Relative_X_BottomRight.Text + "," + TextBox_Relative_Y_BottomRight.Text +")"

        Dim posTopLeft As Point = New Point(0, 0)
        Dim posBottomRight As Point = New Point(0, 0)

        If TextBox_Relative_X.Text <> "" Then
            posTopLeft.X = Convert.ToInt32(TextBox_Relative_X.Text)
        End If
        If TextBox_Relative_Y.Text <> "" Then
            posTopLeft.Y = Convert.ToInt32(TextBox_Relative_Y.Text)
        End If
        If TextBox_Relative_X_BottomRight.Text <> "" Then
            posBottomRight.X = Convert.ToInt32(TextBox_Relative_X_BottomRight.Text)
        End If
        If TextBox_Relative_Y_BottomRight.Text <> "" Then
            posBottomRight.Y = Convert.ToInt32(TextBox_Relative_Y_BottomRight.Text)
        End If

        Dim ImageWidth As Integer = posBottomRight.X - posTopLeft.X
        Dim ImageHeight As Integer = posBottomRight.Y - posTopLeft.Y

        If ImageWidth > 0 And ImageHeight > 0 Then
            TextBox_ImgSize.Text = "(" & ImageWidth & "," & ImageHeight & ")"
        Else
            TextBox_ImgSize.Text = "(1,1)"
        End If

        TextBox_PixelHiLim.Text = TextBox_Detect_Color.Text
        TextBox_PixelLowLim.Text = TextBox_Detect_Color.Text

        TextBox_WndTitle.Text = TextBox_Detect_WndTitle.Text
        TextBox_WndClass.Text = TextBox_Detect_WndClass.Text

        TextBox_MouseScrollCount.Text = TextBox_Detect_MouseScrollCount.Text

        'If ComboBox_CommandType.SelectedValue = "Image Detection" Then
        '    TextBox_TypeString.Text = TextBox_SaveImageName.Text
        'End If


        ShowStatus("Duplicate data to command line")

    End Sub

    Private Sub Button_ClearCmd_Click(sender As Object, e As EventArgs) Handles Button_ClearCmd.Click

        TextBox_StepNum.Text = Convert.ToInt32(TextBox_StepNum.Text) + 1
        TextBox_StepName.Text = ""
        ComboBox_CommandType.SelectedIndex = 0
        TextBox_Delay.Text = 1000
        TextBox_NextStep.Text = "-1"
        TextBox_LastStep.Text = "-1"
        TextBox_Position.Text = ""
        TextBox_Position_Up.Text = ""
        TextBox_ImgSize.Text = "(1,1)"
        TextBox_PixelHiLim.Text = ""
        TextBox_PixelLowLim.Text = ""
        TextBox_MouseScrollCount.Text = "0"
        TextBox_WndTitle.Text = ""
        TextBox_WndClass.Text = ""
        ComboBox_VARIndex.SelectedIndex = 0
        ComboBox_VARsIndex.SelectedIndex = 0
        ComboBox_VAR_Operator.SelectedIndex = 0
        NumericUpDown_VARr.Value = 0
        NumericUpDown_VARHiLim.Value = 0
        NumericUpDown_VARLowLim.Value = 0
        ComboBox_SVARIndex.SelectedIndex = 0
        TextBox_SVAR_String.Text = ""
        TextBox_SVARCheck.Text = ""
        TextBox_TypeString.Text = ""

        TextBox_SourcePath.Text = ""
        TextBox_DestPath.Text = ""
        ComboBox_FileToSVAR.SelectedIndex = 0
        TextBox_FileString.Text = ""

        ComboBox_WatchDogIndex.SelectedIndex = 0
        TextBox_WatchDogFeedTime.Text = "0"
        TextBox_ForceAboutTimer.Text = "0"

    End Sub

    Private Sub Button_ReplaceStep_Click(sender As Object, e As EventArgs) Handles Button_ReplaceStep.Click

        Dim iStepNum As Integer = Math.Abs(Convert.ToInt32(TextBox_StepNum.Text))
        Dim iInsertRowIndex As Integer = MainFormEvent.GetStepInRowIndex(iStepNum)
        Dim iCommandType As Integer = MainFormData.GetCommandTypeIndex(ComboBox_CommandType.Text)


        If TextBox_StepName.ToString = "" Then
            MessageBox.Show("StepName is empty, please give it a name.")
            Exit Sub
        End If

        If TextBox_NextStep.ToString = "" Or TextBox_LastStep.ToString = "" Then
            MessageBox.Show("NextStep/LastStep is empty, please set it.")
            Exit Sub
        End If

        If Not MainFormData.IsStepNumExist(iStepNum) Then

            MessageBox.Show("Step " + iStepNum.ToString + " doesn't exists.")

            Exit Sub

        End If

        MainFormEvent.DataGridView_StepEdit.Rows(iInsertRowIndex).SetValues(TextBox_StepNum.Text, _
                                                    TextBox_StepName.Text, _
                                                    ComboBox_CommandType.Text, _
                                                    TextBox_NextStep.Text, _
                                                    TextBox_LastStep.Text, _
                                                    AppCommandData.GetParam(MainFormData.ParamNum.PARAM1, iCommandType), _
                                                    AppCommandData.GetParam(MainFormData.ParamNum.PARAM2, iCommandType), _
                                                    AppCommandData.GetParam(MainFormData.ParamNum.PARAM3, iCommandType), _
                                                    AppCommandData.GetParam(MainFormData.ParamNum.PARAM4, iCommandType), _
                                                    AppCommandData.GetParam(MainFormData.ParamNum.PARAM5, iCommandType), _
                                                    TextBox_Delay.Text)

        MainFormEvent.Button_SaveScript.Text = "*Save"
    End Sub

    Private Sub Button_InsertStep_Click(sender As Object, e As EventArgs) Handles Button_InsertStep.Click

        Dim iStepNum As Integer = Math.Abs(Convert.ToInt32(TextBox_StepNum.Text))
        Dim iInsertRowIndex As Integer = MainFormEvent.GetStepInRowIndex(iStepNum)
        Dim iCommandType As Integer = MainFormData.GetCommandTypeIndex(ComboBox_CommandType.Text)


        If TextBox_StepName.ToString = "" Then
            MessageBox.Show("StepName is empty, please give it a name.")
            Exit Sub
        End If

        If TextBox_NextStep.ToString = "" Or TextBox_LastStep.ToString = "" Then
            MessageBox.Show("NextStep/LastStep is empty, please set it.")
            Exit Sub
        End If

        If MainFormData.IsStepNumExist(iStepNum) Then

            MessageBox.Show("Step " + iStepNum.ToString + " exists.")
            MainFormEvent.InsertStep(iStepNum)
            'Exit Sub

        End If

        If iInsertRowIndex = -1 Then
            MainFormEvent.DataGridView_StepEdit.Rows.Add(TextBox_StepNum.Text, _
                                                    TextBox_StepName.Text, _
                                                    ComboBox_CommandType.Text, _
                                                    TextBox_NextStep.Text, _
                                                    TextBox_LastStep.Text, _
                                                    AppCommandData.GetParam(MainFormData.ParamNum.PARAM1, iCommandType), _
                                                    AppCommandData.GetParam(MainFormData.ParamNum.PARAM2, iCommandType), _
                                                    AppCommandData.GetParam(MainFormData.ParamNum.PARAM3, iCommandType), _
                                                    AppCommandData.GetParam(MainFormData.ParamNum.PARAM4, iCommandType), _
                                                    AppCommandData.GetParam(MainFormData.ParamNum.PARAM5, iCommandType), _
                                                    TextBox_Delay.Text)
        Else
            MainFormEvent.DataGridView_StepEdit.Rows.Insert(iInsertRowIndex, _
                                                        TextBox_StepNum.Text, _
                                                        TextBox_StepName.Text, _
                                                        ComboBox_CommandType.Text, _
                                                        TextBox_NextStep.Text, _
                                                        TextBox_LastStep.Text, _
                                                        AppCommandData.GetParam(MainFormData.ParamNum.PARAM1, iCommandType), _
                                                        AppCommandData.GetParam(MainFormData.ParamNum.PARAM2, iCommandType), _
                                                        AppCommandData.GetParam(MainFormData.ParamNum.PARAM3, iCommandType), _
                                                        AppCommandData.GetParam(MainFormData.ParamNum.PARAM4, iCommandType), _
                                                        AppCommandData.GetParam(MainFormData.ParamNum.PARAM5, iCommandType), _
                                                        TextBox_Delay.Text)

        End If

        MainFormEvent.Button_SaveScript.Text = "*Save"

    End Sub

    Private Sub Button_DeleteStep_Click(sender As Object, e As EventArgs) Handles Button_DeleteStep.Click

        Dim iStepNum As Integer = Math.Abs(Convert.ToInt32(TextBox_StepNum.Text))
        Dim iDeleteRowIndex As Integer = MainFormEvent.GetStepInRowIndex(iStepNum)
        Dim iCommandType As Integer = MainFormData.GetCommandTypeIndex(ComboBox_CommandType.Text)

        If Not MainFormData.IsStepNumExist(iStepNum) Then
            MessageBox.Show("Step " + iStepNum.ToString + " doesn't exists.")
            'Exit Sub
        Else
            MainFormEvent.DataGridView_StepEdit.Rows.RemoveAt(iDeleteRowIndex)
        End If

        MainFormEvent.DeleteStep(iStepNum)
        MainFormEvent.Button_SaveScript.Text = "*Save"

    End Sub

    Private Sub Button_GetStep_Click(sender As Object, e As EventArgs) Handles Button_GetStep.Click

        Dim iStepNum As Integer = Math.Abs(Convert.ToInt32(TextBox_StepNum.Text))
        Dim iGetRowIndex As Integer = MainFormEvent.GetStepInRowIndex(iStepNum)
        Dim iCommandType As Integer

        If Not MainFormData.IsStepNumExist(iStepNum) Then

            MessageBox.Show("Step " + iStepNum.ToString + " doesn't exists.")
            Exit Sub

        End If

        TextBox_StepNum.Text = MainFormEvent.DataGridView_StepEdit.Rows(iGetRowIndex).Cells(MainFormData.EditColumn.STEP_NUM).Value.ToString
        TextBox_StepName.Text = MainFormEvent.DataGridView_StepEdit.Rows(iGetRowIndex).Cells(MainFormData.EditColumn.STEP_NAME).Value.ToString
        ComboBox_CommandType.Text = MainFormEvent.DataGridView_StepEdit.Rows(iGetRowIndex).Cells(MainFormData.EditColumn.COMMAND_TYPE).Value.ToString
        TextBox_Delay.Text = MainFormEvent.DataGridView_StepEdit.Rows(iGetRowIndex).Cells(MainFormData.EditColumn.DELAY).Value.ToString
        TextBox_NextStep.Text = MainFormEvent.DataGridView_StepEdit.Rows(iGetRowIndex).Cells(MainFormData.EditColumn.NEXT_STEP).Value.ToString
        TextBox_LastStep.Text = MainFormEvent.DataGridView_StepEdit.Rows(iGetRowIndex).Cells(MainFormData.EditColumn.LAST_STEP).Value.ToString

        iCommandType = MainFormData.GetCommandTypeIndex(ComboBox_CommandType.Text)

        If TabControl_ParamSet.SelectedTab.Text = TabPage_Window.Text Then
            TextBox_Position.Text = AppCommandData.GetPosition(iGetRowIndex, iCommandType)
            TextBox_Position_Up.Text = AppCommandData.GetPositionUp(iGetRowIndex, iCommandType)
            TextBox_ImgSize.Text = AppCommandData.GetImageSize(iGetRowIndex, iCommandType)
            TextBox_PixelHiLim.Text = AppCommandData.GetHiLimitOfPixel(iGetRowIndex, iCommandType)
            TextBox_PixelLowLim.Text = AppCommandData.GetLowLimitOfPixel(iGetRowIndex, iCommandType)
            TextBox_MouseScrollCount.Text = AppCommandData.GetScrollCount(iGetRowIndex, iCommandType)
            TextBox_TypeString.Text = AppCommandData.GetTypeString(iGetRowIndex, iCommandType)
            TextBox_WndTitle.Text = AppCommandData.GetWindowTitle(iGetRowIndex, iCommandType)
            TextBox_WndClass.Text = AppCommandData.GetWindowClass(iGetRowIndex, iCommandType)
        ElseIf TabControl_ParamSet.SelectedTab.Text = TabPage_Variable.Text Then
            ComboBox_VARIndex.Text = AppCommandData.GetVARIndex(iGetRowIndex, iCommandType).ToString
            ComboBox_VARsIndex.Text = AppCommandData.GetVARsIndex(iGetRowIndex, iCommandType)
            ComboBox_VAR_Operator.Text = AppCommandData.GetVAROperator(iGetRowIndex, iCommandType)
            NumericUpDown_VARr.Value = AppCommandData.GetVARNumeric(iGetRowIndex, iCommandType)
            NumericUpDown_VARHiLim.Value = AppCommandData.GetVARHiLim(iGetRowIndex, iCommandType)
            NumericUpDown_VARLowLim.Value = AppCommandData.GetVARLowLim(iGetRowIndex, iCommandType)
            ComboBox_SVARIndex.Text = AppCommandData.GetSVARIndex(iGetRowIndex, iCommandType).ToString
            TextBox_SVAR_String.Text = AppCommandData.GetSVARString(iGetRowIndex, iCommandType)
            TextBox_SVARCheck.Text = AppCommandData.GetSVARCheck(iGetRowIndex, iCommandType)
        ElseIf TabControl_ParamSet.SelectedTab.Text = TabPage_File.Text Then
            TextBox_SourcePath.Text = AppCommandData.GetFileSourcePath(iGetRowIndex, iCommandType)
            TextBox_DestPath.Text = AppCommandData.GetFileDestPath(iGetRowIndex, iCommandType)
            TextBox_FileString.Text = AppCommandData.GetFileString(iGetRowIndex, iCommandType)
            ComboBox_FileToSVAR.Text = AppCommandData.GetFileRead_SVARIndex(iGetRowIndex, iCommandType)
        ElseIf TabControl_ParamSet.SelectedTab.Text = TabPage_System.Text Then
            ComboBox_WatchDogIndex.Text = AppCommandData.GetWatchDogIndex(iGetRowIndex, iCommandType)
            TextBox_WatchDogFeedTime.Text = AppCommandData.GetWatchDogFeedTime(iGetRowIndex, iCommandType).ToString
            TextBox_ForceAboutTimer.Text = AppCommandData.GetForceAbortTimer(iGetRowIndex, iCommandType)
        End If


    End Sub

    Private Sub ComboBox_CommandType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_CommandType.SelectedIndexChanged

        If DetectFormData.IsValueInTableCommand_Window(ComboBox_CommandType.Text) Then
            TabControl_ParamSet.SelectedTab = TabPage_Window
        ElseIf DetectFormData.IsValueInTableCommand_Variable(ComboBox_CommandType.Text) Then
            TabControl_ParamSet.SelectedTab = TabPage_Variable
        ElseIf DetectFormData.IsValueInTableCommand_File(ComboBox_CommandType.Text) Then
            TabControl_ParamSet.SelectedTab = TabPage_File
        ElseIf DetectFormData.IsValueInTableCommand_System(ComboBox_CommandType.Text) Then
            TabControl_ParamSet.SelectedTab = TabPage_System
        End If

        Dim iCommandType As Integer = MainFormData.GetCommandTypeIndex(ComboBox_CommandType.Text)

        AppStepUI.StepUISetting(iCommandType)

    End Sub

    Private Sub Button_GetColorFromPosition_Click(sender As Object, e As EventArgs) Handles Button_GetColorFromPosition.Click

        Dim posPixel As Point
        Dim colorPixel As Color
        If TextBox_Axis_X.Text.Length = 0 Or TextBox_Axis_Y.Text.Length = 0 Then
            posPixel.X = 0
            posPixel.Y = 0
        Else
            posPixel.X = Convert.ToInt32(TextBox_Axis_X.Text)
            posPixel.Y = Convert.ToInt32(TextBox_Axis_Y.Text)
        End If

        colorPixel = Utility.PixelColorGet(posPixel)

        TextBox_Detect_Color.Text = "(" & colorPixel.R & "," & colorPixel.G & "," & colorPixel.B & ")"

        ShowStatus("Get color")
    End Sub

    Private Sub CheckBox_LockName_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_LockName.CheckedChanged

        TextBox_SaveImageName.Enabled = Not CheckBox_LockName.Checked

        If Button_Detect.BackColor <> Color.GreenYellow And CheckBox_LockName.Checked Then
            Button_Detect.PerformClick()
            ComboBox_CommandType.Text = MainFormData.GetCommandTypeString(MainFormData.CommandType.IMAGE_DETECTION)
        End If

    End Sub

   
End Class