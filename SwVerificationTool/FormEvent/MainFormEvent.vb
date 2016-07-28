Public Class MainFormEvent

    Const SW_VERSION As String = "V0006_20150908"

    Const SCRIPTLIST_PATH As String = "SCRIPT\"
    Const SCRIPTLIST_NAME As String = "ScriptList.scl"
    Const SCRIPTLIST_FULLPATH As String = SCRIPTLIST_PATH + SCRIPTLIST_NAME

    Const SEQUENCELIST_PATH As String = "SEQUENCE\"
    Const SEQUENCELIST_NAME As String = "SequenceList.sdl"
    Const SEQUENCELIST_FULLPATH As String = SEQUENCELIST_PATH + SEQUENCELIST_NAME


    ' -------------------------------------------------------
    ' CommandType Description:

    '   MOUSE_CLICK:
    '        - Position         - Param1
    '   MOUSE_CLICK_COLOR:
    '        - Position         - Param1
    '        - Image Size       - Param2
    '        - Hi Limit of Pixel - Param3-1
    '        - Low Limit of Pixel - Param3-2
    '       Param3 = (HiLim);(LowLim)
    '   MOUSE_CLICK_RIGHT
    '        - Position         - Param1
    '   MOUSE_SCROLL
    '        - Position         - Param1
    '        - Scroll Count     - Param2
    '   MOUSE_DRAG
    '        - Mouse Down Position - Param1
    '        - Mouse Up Position   - Param2
    '   TYPE_STRING
    '        - Position         - Param1
    '        - Type String      - Param2
    '   PIXEL_DETECTION
    '        - Position         - Param1
    '        - Image Size       - Param2
    '        - Hi Limit of Pixel - Param3-1
    '        - Low Limit of Pixel - Param3-2
    '       Param3 = (HiLim);(LowLim)
    '   IMAGE_DETECTION
    '       - Title
    '       - Class
    '       - Relative Position
    '       - Full Path of ControlImage
    '   IMAGE_CATCH
    '        - Position         - Param1
    '        - Image Size       - Param2
    '        - Folder Path      - Param3
    '   DELAY
    '        - Delay Time       - Param1
    '   WINDOW_SET
    '        - Title            - Param1
    '        - Class            - Param2
    '   WINDOW_DETECTION
    '        - Title            - Param1
    '        - Class            - Param2
    '   EXECUTE
    '        - Execute file path - Param2
    '   VAR_SET
    '        - VAR Index        - Param1
    '        - VARs Index       - Param2
    '        - Operator         - Param3
    '        - Numeric          - Param4
    '        VAR = VARs (+-*/%\) Numeric
    '   SVAR_SET
    '        - SVAR Index       - Param1
    '        - String           - Param2
    '   VAR_CHECK
    '        - VAR Index        - Param1
    '        - VAR Hi Limit     - Param2
    '        - VAR Low Limit    - Param3
    '   SVAR_CHECK
    '        - SVAR Index       - Param1
    '        - Check String     - Param2
    '   FILE_WRITE
    '        - Path of Source   - Param1
    '        - String           - Param2
    '   FILE_APPEND
    '        - Path of Source   - Param1
    '        - String           - Param2
    '   FILE_READ
    '        - Path of Source   - Param1
    '        - SVAR             - Param2
    '   FILE_COPY
    '        - Path of Source   - Param1
    '        - Path of Destination - Param2
    '   FILE_STRING_CHECK
    '        - Path of Source   - Param1
    '        - Checking String  - Param2
    '   WATCHDOG_SET
    '        - WatchDogIndex    - Param1
    '        - FeedTime(Minute) - Param2
    '   WATCHDOG_FEED
    '        - WatchDogIndex    - Param1
    '   WATCHDOG_DISABLE
    '        - WatchDogIndex    - Param1
    '   FORCEABORT_TIMER
    '        - Timeout          - Param1
    ' -------------------------------------------------------

    Private giCurStepIndex As Integer
    Private giWndHandle As Integer

    Private giCurScriptIndex As Integer

    Private gbIsSetWndHandle As Boolean

    Public Sub InsertStep(ByVal iStepNum As Integer)

        For iRowIndex As Integer = 0 To DataGridView_StepEdit.RowCount - 1

            If Math.Abs(Convert.ToInt32(DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.STEP_NUM).Value)) >= iStepNum Then
                If Convert.ToInt32(DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.STEP_NUM).Value) > 0 Then
                    DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.STEP_NUM).Value = Convert.ToInt32(DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.STEP_NUM).Value) + 1
                Else
                    DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.STEP_NUM).Value = Convert.ToInt32(DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.STEP_NUM).Value) - 1
                End If

            End If

            If Convert.ToInt32(DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.NEXT_STEP).Value) >= iStepNum Then
                DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.NEXT_STEP).Value = Convert.ToInt32(DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.NEXT_STEP).Value) + 1
            End If

            If Convert.ToInt32(DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.LAST_STEP).Value) >= iStepNum Then
                DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.LAST_STEP).Value = Convert.ToInt32(DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.LAST_STEP).Value) + 1
            End If
        Next

    End Sub

    Public Sub InsertScript(ByVal iScriptNum As Integer)

        For iRowIndex As Integer = 0 To DataGridView_Sequence.RowCount - 1

            If Math.Abs(Convert.ToInt32(DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.SCRIPT_NUM).Value)) >= iScriptNum Then
                If Convert.ToInt32(DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.SCRIPT_NUM).Value) > 0 Then
                    DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.SCRIPT_NUM).Value = Convert.ToInt32(DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.SCRIPT_NUM).Value) + 1
                Else
                    DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.SCRIPT_NUM).Value = Convert.ToInt32(DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.SCRIPT_NUM).Value) - 1
                End If
            End If

            If Convert.ToInt32(DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.NEXT_SCRIPT).Value) >= iScriptNum Then
                DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.NEXT_SCRIPT).Value = Convert.ToInt32(DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.NEXT_SCRIPT).Value) + 1
            End If

        Next

    End Sub

    Public Sub DeleteStep(ByVal iStepNum As Integer)

        For iRowIndex As Integer = 0 To DataGridView_StepEdit.RowCount - 1

            If Math.Abs(Convert.ToInt32(DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.STEP_NUM).Value)) > iStepNum Then
                If Convert.ToInt32(DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.STEP_NUM).Value) > 0 Then
                    DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.STEP_NUM).Value = Convert.ToInt32(DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.STEP_NUM).Value) - 1
                Else
                    DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.STEP_NUM).Value = Convert.ToInt32(DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.STEP_NUM).Value) + 1
                End If
            End If

            If Convert.ToInt32(DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.NEXT_STEP).Value) > iStepNum Then
                DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.NEXT_STEP).Value = Convert.ToInt32(DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.NEXT_STEP).Value) - 1
            End If

            If Convert.ToInt32(DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.LAST_STEP).Value) > iStepNum Then
                DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.LAST_STEP).Value = Convert.ToInt32(DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.LAST_STEP).Value) - 1
            End If
        Next

    End Sub

    Public Sub DeleteScript(ByVal iScriptNum As Integer)

        For iRowIndex As Integer = 0 To DataGridView_Sequence.RowCount - 1

            If Math.Abs(Convert.ToInt32(DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.SCRIPT_NUM).Value)) > iScriptNum Then
                If Convert.ToInt32(DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.SCRIPT_NUM).Value) > 0 Then
                    DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.SCRIPT_NUM).Value = Convert.ToInt32(DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.SCRIPT_NUM).Value) - 1
                Else
                    DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.SCRIPT_NUM).Value = Convert.ToInt32(DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.SCRIPT_NUM).Value) + 1
                End If
            End If

            If Convert.ToInt32(DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.NEXT_SCRIPT).Value) > iScriptNum Then
                DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.NEXT_SCRIPT).Value = Convert.ToInt32(DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.NEXT_SCRIPT).Value) - 1
            End If

        Next

    End Sub

    Public Function GetStepInRowIndex(ByVal iStepNum As Integer) As Integer

        For i As Integer = 0 To DataGridView_StepEdit.RowCount - 1

            If iStepNum <= Math.Abs(Convert.ToInt32(DataGridView_StepEdit.Rows(i).Cells(MainFormData.EditColumn.STEP_NUM).Value)) Then
                Return i
            End If

        Next

        Return -1

    End Function

    Public Function GetScriptInRowIndex(ByVal iScriptNum As Integer) As Integer

        For i As Integer = 0 To DataGridView_Sequence.RowCount - 1

            If iScriptNum <= Math.Abs(Convert.ToInt32(DataGridView_Sequence.Rows(i).Cells(MainFormData.EditColumn.STEP_NUM).Value)) Then
                Return i
            End If

        Next

        Return -1

    End Function

    Private Sub Button_DetectForm_Click(sender As Object, e As EventArgs) Handles Button_DetectForm.Click

        If DetectFormEvent.Created Then
            DetectFormEvent.Focus()
        Else
            DetectFormEvent.Show()
        End If

    End Sub

    Private Sub LogOfRunning(strLog As String)

        If CheckBox_LogEnable.Checked Then

            RichTextBox_RunLog.AppendText(strLog & vbNewLine)

            RichTextBox_RunLog.SelectionStart = RichTextBox_RunLog.Text.Length
            RichTextBox_RunLog.ScrollToCaret()
        End If

    End Sub

    Private Sub AllMessageShow(strMsg As String)

        ToolStripStatusLabel_Script.Text = strMsg
        StepShowFormEvent.Label_CurrentStepStatus.Text = strMsg
        LogOfRunning(strMsg)

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Text = Me.Text & " - " & SW_VERSION

        MainFormData.Init()
        DetectFormData.Init()

        MainFormData.VarInit()
        MainFormData.SvarInit()

        ' If folder ../SCRIPT/ doesn't exist, create it
        Utility.CreateFolder(SCRIPTLIST_PATH)

        ' If folder ../SEQUENCE/ doesn't exist, create it
        Utility.CreateFolder(SEQUENCELIST_PATH)

        ' Set ComboBox data from file
        If (MainFormData.SetListIntoComboBox(SCRIPTLIST_FULLPATH, ComboBox_ScriptList)) Then
            MainFormData.SetListIntoComboBox(SCRIPTLIST_FULLPATH, ComboBox_ScriptList4Sequence)
        Else
            MessageBox.Show("The script list (" + SCRIPTLIST_FULLPATH + ") doesn't exist.")
        End If

        If (MainFormData.SetListIntoComboBox(SEQUENCELIST_FULLPATH, ComboBox_SequenceList) = False) Then
            MessageBox.Show("The Sequence list (" + SEQUENCELIST_FULLPATH + ") doesn't exist.")
        End If

        Button_SaveScript.Text = "Save"
        Button_SaveSequence.Text = "Save"

    End Sub

    Private Sub Button_AddNewScript_Click(sender As Object, e As EventArgs) Handles Button_AddNewScript.Click

        If TextBox_AddScript.Text.Length < 3 Then
            MessageBox.Show("The length of script name (" + TextBox_AddScript.Text + ") is less than 3." + vbNewLine + "Please rename a long one.")
            Exit Sub
        End If

        For Each i As String In ComboBox_ScriptList.Items
            If i = TextBox_AddScript.Text Then
                MessageBox.Show("The name of script (" + i + ") has existed in script list.")
                Exit Sub
            End If
        Next

        ComboBox_ScriptList.Items.Add(TextBox_AddScript.Text)
        ComboBox_ScriptList4Sequence.Items.Add(TextBox_AddScript.Text)

        'Save data of ComboBox_ScriptList into file ScriptList
        MainFormData.SaveListIntoFile(SCRIPTLIST_FULLPATH, ComboBox_ScriptList)

    End Sub

    Private Sub Button_SaveScript_Click(sender As Object, e As EventArgs) Handles Button_SaveScript.Click

        Dim strScirptName As String = ComboBox_ScriptList.Text

        If strScirptName.Length < 3 Then
            MessageBox.Show("The length of selected script (" + strScirptName + ") is short than 3.")
            Exit Sub
        End If

        Dim iDiagRet As Integer = MessageBox.Show("Do you wanna save the script?", "Warning", MessageBoxButtons.YesNo)

        If iDiagRet = DialogResult.No Then
            Exit Sub
        End If

        Dim strScriptFullPath As String = SCRIPTLIST_PATH + strScirptName + ".dat"
        MainFormData.SaveScript(strScriptFullPath)

        MainFormData.SetStepInfoFromDataGridView()

        Button_SaveScript.Text = "Save"

    End Sub

    Private Sub Button_LoadScript_Click(sender As Object, e As EventArgs) Handles Button_LoadScript.Click

        Dim strScirptName As String = ComboBox_ScriptList.Text
        Dim strScriptFullPath As String = SCRIPTLIST_PATH + strScirptName + ".dat"

        FileVersionControl.StepInfoDataConvert(strScriptFullPath, MainFormData.giStepInfoDataVersion)

        If Not e.Equals(EventArgs.Empty) Then

            If strScirptName.Length < 3 Then
                MessageBox.Show("The length of selected script (" + strScirptName + ") is short than 3.")
                Exit Sub
            End If

            If Not My.Computer.FileSystem.FileExists(strScriptFullPath) Then
                MessageBox.Show("The script (" + strScriptFullPath + ") doesn't exist.")
                Exit Sub
            End If

            Dim iDiagRet As Integer = MessageBox.Show("Do you wanna load the script?", "Warning", MessageBoxButtons.YesNo)

            If iDiagRet = DialogResult.No Then
                Exit Sub
            End If

        End If

        MainFormData.LoadScriptFromFile(strScriptFullPath)

        LogOfRunning("Load Script: " & strScirptName)
        MainFormData.SetStepInfoFromDataGridView()

        Button_SaveScript.Text = "Save"

    End Sub

    Private Sub Button_ClearAllStep_Click(sender As Object, e As EventArgs) Handles Button_ClearAllStep.Click

        Dim iDiagRet As Integer = MessageBox.Show("Do you wanna clear the script?", "Warning", MessageBoxButtons.YesNo)

        If iDiagRet = DialogResult.No Then
            Exit Sub
        End If

        DataGridView_StepEdit.Rows.Clear()
    End Sub

    Private Sub Button_DeleteScript_Click(sender As Object, e As EventArgs) Handles Button_DeleteScript.Click

        Dim iDiagRet As Integer = MessageBox.Show("Do you wanna delete the script?", "Warning", MessageBoxButtons.YesNo)

        If iDiagRet = DialogResult.No Then
            Exit Sub
        End If

        ' Remove script from ComboBox_ScriptList
        Dim strSelectedScript As String = ComboBox_ScriptList.SelectedItem.ToString
        ComboBox_ScriptList.Items.Remove(strSelectedScript)
        ComboBox_ScriptList4Sequence.Items.Remove(strSelectedScript)
        ' Write scripts of ComboBox_ScriptList to file ScriptList.scl
        MainFormData.SaveListIntoFile(SCRIPTLIST_FULLPATH, ComboBox_ScriptList)

        Button_SaveScript.Text = "Save"

    End Sub

    Private Sub ScriptRun(ByVal bOnOff)

        If bOnOff Then
            LogOfRunning(vbNewLine & "Start Time: " & Format(Now(), "yyyyMMdd_HHmmss"))
            MainFormData.VarInit()
            MainFormData.SvarInit()
            giCurStepIndex = Convert.ToInt32(TextBox_StepNum_Start.Text)
            giWndHandle = 0
            gbIsSetWndHandle = False
            ToolStripStatusLabel_Script.Text = "Idle"
            Button_StartScript.Text = "Stop"
            Button_StartScript.BackColor = Color.Red
            Timer_Script.Interval = 1000
            Timer_Script.Enabled = True
        Else
            giCurStepIndex = -1
            gbIsSetWndHandle = False
            ToolStripStatusLabel_Script.Text = "Idle"
            Button_StartScript.Text = "Start"
            Button_StartScript.BackColor = Color.Green
            Timer_Script.Enabled = False
            LogOfRunning("End Time: " & Format(Now(), "yyyyMMdd_HHmmss"))
        End If

    End Sub

    Private Sub Button_StartScript_Click(sender As Object, e As EventArgs) Handles Button_StartScript.Click

        If Button_SaveScript.Text <> "Save" Then
            MessageBox.Show("Please save the modified script first before running.")
            Exit Sub
        End If

        If AppStepInfo.IsStepInfoExist() = False Then
            MessageBox.Show("Please add step(s) before running.")
            Exit Sub
        End If

        ScriptRun(Not Timer_Script.Enabled)

    End Sub

    Private Function ScriptRun_DataCheck() As Boolean

        If Button_StartScript.Text = "Start" Then
            Return False
        End If

        ' String of StatusLabel
        ToolStripStatusLabel_Script.Text = "Step " & giCurStepIndex & " - " & MainFormData.GetStepInfoData(giCurStepIndex).strStepName
        If MainFormData.GetStepInfoData(giCurStepIndex).bIsSkip Then
            ToolStripStatusLabel_Script.Text = ToolStripStatusLabel_Script.Text & "(Skip)"
        End If
        Me.Text = ToolStripStatusLabel_Script.Text
        StepShowFormEvent.Label_CurrentStepStatus.Text = ToolStripStatusLabel_Script.Text
        LogOfRunning(ToolStripStatusLabel_Script.Text)


        ' if set window handle, giWndHandle should be non-zero
        If gbIsSetWndHandle Then

            If (MainFormData.GetStepInfoData(giCurStepIndex).iCommandType = MainFormData.CommandType.MOUSE_CLICK _
              Or MainFormData.GetStepInfoData(giCurStepIndex).iCommandType = MainFormData.CommandType.PIXEL_DETECTION _
              Or MainFormData.GetStepInfoData(giCurStepIndex).iCommandType = MainFormData.CommandType.IMAGE_CATCH) _
              And giWndHandle = 0 Then
                MessageBox.Show("Window handle is 0, please set it before running script.")
                ScriptRun(False)
                Return False
            End If

        End If

        'Check if TRI SW crashed, stop auto run.
        Dim CrashWndHandle As Integer = 0
        CrashWndHandle = Utility.FindWindow("#32770", "TRI")
        If CrashWndHandle Then
            Dim strTime As String = Format(Now(), "yyyyMMdd_HHmmss")
            Dim strImageName As String = "CrashImage_" + strTime + ".jpg"
            Utility.SaveScreenImage(New Point(0, 0), Screen.PrimaryScreen.Bounds.Size, strImageName)
            LogOfRunning(vbTab & "TRI SW crashed!!! Save screen image and stop.")
            MessageBox.Show("TRI SW crashed!!! Save screen image and stop.")
            ScriptRun(False)
        End If

        Return True

    End Function

    Private Sub ScriptRun_NextStepSet(ByVal bStepPass As Boolean)
        Dim iCurDelayTime As Integer = 0

        ' Set delay time 
        iCurDelayTime = MainFormData.GetStepInfoData(giCurStepIndex).delay

        ' Set next step
        If bStepPass = True Then
            giCurStepIndex = MainFormData.GetStepInfoData(giCurStepIndex).iNextStep
        Else
            giCurStepIndex = MainFormData.GetStepInfoData(giCurStepIndex).iLastStep
        End If

        ' If timer needs to restart
        If giCurStepIndex <> -1 Then
            Timer_Script.Interval = iCurDelayTime
            Timer_Script.Start()
        Else
            ToolStripStatusLabel_Script.Text = ToolStripStatusLabel_Script.Text + " -> Step -1"
            LogOfRunning("End Time: " & Format(Now(), "yyyyMMdd_HHmmss") & vbNewLine)
            Button_StartScript.Text = "Start"
            Button_StartScript.BackColor = Color.Green
        End If
    End Sub

    Private Function ScriptRun_HotkeyStop() As Boolean

        If Utility.GetAsyncKeyState(Keys.ControlKey) And Utility.GetAsyncKeyState(Keys.S) Then
            Return True
        End If

        Return False

    End Function

    Private Function ScriptRun_WatchDogCheck() As Boolean

        Dim bIsTimeout As Boolean = False

        For index As MainFormData.WatchDogIndex = MainFormData.WatchDogIndex.WATCHDOG_0 To MainFormData.WatchDogIndex.WATCHDOG_TOTAL - 1
            If AppWatchDogInfo.WatchDog_TimeCheck(index) Then
                bIsTimeout = True
                LogOfRunning("WatchDog " & index & " is timeout.")
                Exit For
            End If
        Next

        Return bIsTimeout

    End Function

    Private Sub Timer_Script_Tick(sender As Object, e As EventArgs) Handles Timer_Script.Tick

        Dim bStepPass As Boolean = True

        Timer_Script.Stop()

        If ScriptRun_DataCheck() = False Then
            Exit Sub
        End If

        If ScriptRun_WatchDogCheck() Then

            ScriptRun(False)
            Exit Sub
        End If

        ' If the current step is not skipped, do command
        If MainFormData.GetStepInfoData(giCurStepIndex).bIsSkip = False Then
            ' Do command
            Dim strLogMessage As String = ""
            bStepPass = AppStepAction.DoCommand(giWndHandle, MainFormData.GetStepInfoData(giCurStepIndex), strLogMessage)
            LogOfRunning(strLogMessage)
        End If

        ScriptRun_NextStepSet(bStepPass)

        ' Force stop by user
        If ScriptRun_HotkeyStop() Then
            ScriptRun(False)
            AllMessageShow(ToolStripStatusLabel_Script.Text + " -> Force stop script running by user")
        End If

        ' Do garbage collection
        GC.Collect()

    End Sub


    Private Sub Button_ClearLog_Click(sender As Object, e As EventArgs) Handles Button_ClearLog.Click

        RichTextBox_RunLog.Text = ""

    End Sub

    Private Sub DataGridView_StepEdit_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_StepEdit.CellValueChanged

        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            If DataGridView_StepEdit.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Nothing Then
                DataGridView_StepEdit.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ""
            End If
        End If

        Button_SaveScript.Text = "*Save"
    End Sub

    Private Sub Button_InsertScriptInSequence_Click(sender As Object, e As EventArgs) Handles Button_InsertScriptInSequence.Click

        If ComboBox_ScriptList4Sequence.Text <> "" Then

            Dim iScriptNum As Integer = Convert.ToInt32(TextBox_ScriptNum.Text)
            Dim iInsertRowIndex As Integer = GetScriptInRowIndex(iScriptNum)
            Dim iCommandType As Integer = MainFormData.GetCommandTypeIndex(ComboBox_ScriptList4Sequence.Text)

            If TextBox_TimeScript.Text <> vbNullString Then
                If Not DateTime.TryParse(TextBox_TimeScript.Text, Nothing) Then

                    MessageBox.Show("The format of TimeScript(" & TextBox_TimeScript.Text & ") is error. Please keyin TimeScript with format HH:mm")
                    Exit Sub

                End If

            End If

            If MainFormData.IsScriptNumExist(iScriptNum) Then

                MessageBox.Show("Script " + iScriptNum.ToString + " exists.")
                InsertScript(iScriptNum)
                'Exit Sub
            End If

            If iInsertRowIndex = -1 Then
                DataGridView_Sequence.Rows.Add(TextBox_ScriptNum.Text, _
                                             ComboBox_ScriptList4Sequence.Text, _
                                             TextBox_NextScript.Text, _
                                             TextBox_TimeScript.Text)
            Else
                DataGridView_Sequence.Rows.Insert(iInsertRowIndex, _
                                                TextBox_ScriptNum.Text, _
                                                ComboBox_ScriptList4Sequence.Text, _
                                                TextBox_NextScript.Text, _
                                                TextBox_TimeScript.Text)
            End If

            Button_SaveSequence.Text = "*Save"

        Else
            MessageBox.Show("Please select script first.")

        End If

    End Sub

    Private Sub Button_DeleteScriptInSequence_Click(sender As Object, e As EventArgs) Handles Button_DeleteScriptInSequence.Click

        Dim iScriptNum As Integer = Convert.ToInt32(TextBox_ScriptNum.Text)
        Dim iDeleteRowIndex As Integer = GetScriptInRowIndex(iScriptNum)

        If Not MainFormData.IsScriptNumExist(iScriptNum) Then
            MessageBox.Show("Script " + iScriptNum.ToString + " doesn't exists.")
            'Exit Sub
        Else
            DataGridView_Sequence.Rows.RemoveAt(iDeleteRowIndex)

        End If
        DeleteScript(iScriptNum)
        Button_SaveSequence.Text = "*Save"

    End Sub

    Private Sub Button_ClearAllScriptInSequence_Click(sender As Object, e As EventArgs) Handles Button_ClearScriptInSequence.Click

        TextBox_ScriptNum.Text = "1"
        ComboBox_ScriptList4Sequence.SelectedIndex = 0
        TextBox_NextScript.Text = "-1"
        TextBox_TimeScript.Text = ""

    End Sub

    Private Sub DataGridView_Sequence_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Sequence.CellValueChanged

        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            If DataGridView_Sequence.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Nothing Then
                DataGridView_Sequence.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ""
            End If
        End If

        Button_SaveSequence.Text = "*Save"
    End Sub

    Private Sub Button_AddSequence_Click(sender As Object, e As EventArgs) Handles Button_AddSequence.Click

        If TextBox_AddSequence.Text.Length < 3 Then
            MessageBox.Show("The length of sequence name (" + TextBox_AddSequence.Text + ") is less than 3." + vbNewLine + "Please rename a long one.")
            Exit Sub
        End If

        For Each i As String In ComboBox_SequenceList.Items
            If i = TextBox_AddSequence.Text Then
                MessageBox.Show("The name of sequence (" + i + ") has existed in sequence list.")
                Exit Sub
            End If
        Next

        ComboBox_SequenceList.Items.Add(TextBox_AddSequence.Text)

        MainFormData.SaveListIntoFile(SEQUENCELIST_FULLPATH, ComboBox_SequenceList)

    End Sub

    Private Sub Button_SaveSequence_Click(sender As Object, e As EventArgs) Handles Button_SaveSequence.Click

        Dim strSequenceName As String = ComboBox_SequenceList.Text

        If strSequenceName.Length < 3 Then
            MessageBox.Show("The length of selected Sequence (" + strSequenceName + ") is short than 3.")
            Exit Sub
        End If

        Dim iDiagRet As Integer = MessageBox.Show("Do you wanna save the Sequence?", "Warning", MessageBoxButtons.YesNo)

        If iDiagRet = DialogResult.No Then
            Exit Sub
        End If

        MainFormData.SetScriptInfoFromDataGridView()

        Button_SaveSequence.Text = "Save"

    End Sub

    Private Sub Button_LoadSequence_Click(sender As Object, e As EventArgs) Handles Button_LoadSequence.Click

        Dim strSequenceName As String = ComboBox_SequenceList.Text
        Dim strSequenceFullPath As String = SEQUENCELIST_PATH + strSequenceName + ".sch"

        If strSequenceName.Length < 3 Then
            MessageBox.Show("The length of selected Sequence (" + strSequenceName + ") is short than 3.")
            Exit Sub
        End If

        If Not My.Computer.FileSystem.FileExists(strSequenceFullPath) Then
            MessageBox.Show("The Sequence (" + strSequenceFullPath + ") doesn't exist.")
            Exit Sub
        End If

        Dim iDiagRet As Integer = MessageBox.Show("Do you wanna load the Sequence?", "Warning", MessageBoxButtons.YesNo)

        If iDiagRet = DialogResult.No Then
            Exit Sub
        End If

        DataGridView_Sequence.Rows.Clear()

        MainFormData.SaveSequence(strSequenceFullPath)

        LogOfRunning("Load Sequence: " & strSequenceName)

        MainFormData.SetScriptInfoFromDataGridView()

        Button_SaveSequence.Text = "Save"
    End Sub

    Private Sub Button_DeleteSequence_Click(sender As Object, e As EventArgs) Handles Button_DeleteSequence.Click

        Dim iDiagRet As Integer = MessageBox.Show("Do you wanna delete the sequence?", "Warning", MessageBoxButtons.YesNo)

        If iDiagRet = DialogResult.No Then
            Exit Sub
        End If

        ' Remove sequence from ComboBox_SequenceList
        ComboBox_SequenceList.Items.Remove(ComboBox_SequenceList.SelectedItem)

        ' Write sequence of ComboBox_SequenceList to file SequenceList.sdl
        Dim fSequenceList As New System.IO.StreamWriter(SEQUENCELIST_FULLPATH)

        For Each strName As String In ComboBox_SequenceList.Items
            fSequenceList.WriteLine(strName)
        Next

        fSequenceList.Close()

        Button_SaveSequence.Text = "Save"


    End Sub

    Private Sub Button_ClearSequence_Click(sender As Object, e As EventArgs) Handles Button_ClearSequence.Click

        Dim iDiagRet As Integer = MessageBox.Show("Do you wanna clear the sequence?", "Warning", MessageBoxButtons.YesNo)

        If iDiagRet = DialogResult.No Then
            Exit Sub
        End If

        DataGridView_Sequence.Rows.Clear()

    End Sub

    Private Sub Timer_Sequence_Tick(sender As Object, e As EventArgs) Handles Timer_Sequence.Tick


        If giCurStepIndex = -1 And Timer_Script.Enabled = False Then

            Dim iNextScript = MainFormData.GetScriptInfoData(giCurScriptIndex).iNextScript

            Timer_Sequence.Enabled = False

            giCurStepIndex = 1

            ' Check TimeScript
            For iScriptIndex = 1 To MainFormData.GetScriptInfoLength() - 1

                If giCurScriptIndex = iScriptIndex Then
                    Continue For
                End If

                If MainFormData.GetScriptInfoData(iScriptIndex).sTimeScript <> vbNullString Then

                    Dim dtTimeScript As DateTime
                    Dim dtHiLimTime As DateTime
                    Dim dtCurTime As DateTime = Now
                    Try
                        dtTimeScript = DateTime.Parse(MainFormData.GetScriptInfoData(iScriptIndex).sTimeScript)
                        dtHiLimTime = dtTimeScript.AddMinutes(1)
                    Catch ex As Exception
                        MessageBox.Show("TimeScript of Script(" & iScriptIndex & ") is error. Please check it.", "Force Abort")
                        SequenceRun(False)
                        Exit Sub
                    End Try

                    If dtCurTime.CompareTo(dtTimeScript) >= 0 And dtCurTime.CompareTo(dtHiLimTime) <= 0 Then

                        ' Not be executed yet
                        If Not MainFormData.GetScriptInfoData(iScriptIndex).bIsSkip Then
                            ' TimeScript is hit!!! Go to and run this script
                            iNextScript = iScriptIndex
                            MainFormData.SetScriptInfoData_bIsSkip(iScriptIndex, True)
                        End If

                    Else
                        MainFormData.SetScriptInfoData_bIsSkip(iScriptIndex, False)
                    End If

                End If

            Next

            giCurScriptIndex = iNextScript

            SequenceRun(giCurScriptIndex <> -1)

        End If

    End Sub

    Private Sub SequenceRun(ByVal bOnOff As Boolean)

        If bOnOff Then

            TextBox_StepNum_Start.Text = "1"


            Timer_Sequence.Interval = 1000

            ComboBox_ScriptList.Text = MainFormData.GetScriptInfoData(giCurScriptIndex).sScriptName
            Button_LoadScript_Click(Nothing, EventArgs.Empty)

            Button_StartScript.Enabled = False
            Button_StartSequence.Text = "Stop"
            Button_StartSequence.BackColor = Color.Red

            If Timer_Script.Enabled = False Then
                Button_StartScript_Click(Nothing, EventArgs.Empty)
            End If

            Timer_Sequence.Enabled = True

        Else

            Timer_Sequence.Enabled = False

            Button_StartScript.Enabled = True
            If Timer_Script.Enabled Then
                Button_StartScript_Click(Nothing, EventArgs.Empty)
            End If

            Button_StartSequence.Text = "Start"
            Button_StartSequence.BackColor = Color.Green

        End If

    End Sub

    Private Sub Button_StartSequence_Click(sender As Object, e As EventArgs) Handles Button_StartSequence.Click

        If Button_SaveSequence.Text <> "Save" Then
            MessageBox.Show("Please save the modified sequence first before running.")
            Exit Sub
        End If

        If Timer_Sequence.Enabled = True Then
            giCurScriptIndex = -1
            SequenceRun(False)
        Else
            giCurScriptIndex = 1
            SequenceRun(True)
        End If


    End Sub

    Private Sub Button_GetScript_Click(sender As Object, e As EventArgs) Handles Button_GetScript.Click

        Dim iScriptNum As Integer = Convert.ToInt32(TextBox_ScriptNum.Text)
        Dim iGetRowIndex As Integer = GetScriptInRowIndex(iScriptNum)

        If Not MainFormData.IsScriptNumExist(iScriptNum) Then
            MessageBox.Show("Script " + iScriptNum.ToString + " doesn't exists.")
            Exit Sub
        End If

        TextBox_ScriptNum.Text = DataGridView_Sequence.Rows(iGetRowIndex).Cells(MainFormData.ScriptColumn.SCRIPT_NUM).Value.ToString
        ComboBox_ScriptList4Sequence.Text = DataGridView_Sequence.Rows(iGetRowIndex).Cells(MainFormData.ScriptColumn.SCRIPT_NAME).Value.ToString
        TextBox_NextScript.Text = DataGridView_Sequence.Rows(iGetRowIndex).Cells(MainFormData.ScriptColumn.NEXT_SCRIPT).Value.ToString
        TextBox_TimeScript.Text = DataGridView_Sequence.Rows(iGetRowIndex).Cells(MainFormData.ScriptColumn.TIME_SCRIPT).Value.ToString

    End Sub

    Private Sub Button_ShowStepForm_Click(sender As Object, e As EventArgs) Handles Button_ShowStepForm.Click
        StepShowFormEvent.Show()
        StepShowFormEvent.TopMost = True
    End Sub

    Private Sub DataGridView_StepEdit_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView_StepEdit.KeyDown

        If e.KeyData = (Keys.Control + Keys.K) Then
            Dim iRowIndex As Integer = DataGridView_StepEdit.CurrentCell.RowIndex()
            ' Dim CurStepInfo As StepInfoData.Step_Info = StepInfoData.GetData(iRowIndex)
            DataGridView_StepEdit.Rows(iRowIndex).Cells(0).Value = -DataGridView_StepEdit.Rows(iRowIndex).Cells(0).Value
            Button_SaveScript.Text = "*Save"
            If DataGridView_StepEdit.Rows(iRowIndex).Cells(0).Value < 0 Then
                DataGridView_StepEdit.Rows(iRowIndex).DefaultCellStyle.BackColor = Color.GreenYellow
            Else
                DataGridView_StepEdit.Rows(iRowIndex).DefaultCellStyle.BackColor = Color.White
            End If
        End If

    End Sub

    Private Sub CheckStep_StepTrack(iStepNum As Integer, ByRef StepTrack() As Boolean)

        If iStepNum < 0 Then
            Exit Sub
        End If

        If StepTrack(iStepNum) Then
            Exit Sub
        End If

        StepTrack(iStepNum) = True

        CheckStep_StepTrack(MainFormData.GetStepInfoData(iStepNum).iNextStep, StepTrack)
        CheckStep_StepTrack(MainFormData.GetStepInfoData(iStepNum).iLastStep, StepTrack)
    End Sub

    Private Sub Button_CheckStep_Click(sender As Object, e As EventArgs) Handles Button_CheckStep.Click

        Dim iStartStepNum As Integer = Convert.ToInt32(TextBox_StepNum_Start.Text)
        Dim iStepTotal As Integer = MainFormData.GetStepInfoLength() - 1

        If iStepTotal < 1 Then
            Exit Sub
        End If

        Dim StepTrack(iStepTotal) As Boolean
        For Each stepmark In StepTrack
            stepmark = False
        Next

        CheckStep_StepTrack(iStartStepNum, StepTrack)

        Dim strMissStep As String = ""

        For StepIndex As Integer = 1 To iStepTotal

            If StepTrack(StepIndex) = False Then
                strMissStep = strMissStep & "Step " & StepIndex & ": " & MainFormData.GetStepInfoData(StepIndex).strStepName & vbNewLine
            End If

        Next

        If strMissStep.Length <> 0 Then
            MessageBox.Show("Miss Step List as below:" & vbNewLine & strMissStep)
        Else
            MessageBox.Show("No Miss Step")
        End If

    End Sub

    Private Sub Timer_System_Tick(sender As Object, e As EventArgs) Handles Timer_System.Tick

    End Sub
End Class
