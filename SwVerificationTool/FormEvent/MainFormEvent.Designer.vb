<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFormEvent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button_DetectForm = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_Script = New System.Windows.Forms.TabPage()
        Me.Button_CheckStep = New System.Windows.Forms.Button()
        Me.Button_ShowStepForm = New System.Windows.Forms.Button()
        Me.TextBox_StepNum_Start = New System.Windows.Forms.TextBox()
        Me.Button_StartScript = New System.Windows.Forms.Button()
        Me.Button_ClearAllStep = New System.Windows.Forms.Button()
        Me.Button_SaveScript = New System.Windows.Forms.Button()
        Me.Button_DeleteScript = New System.Windows.Forms.Button()
        Me.Button_LoadScript = New System.Windows.Forms.Button()
        Me.Button_AddNewScript = New System.Windows.Forms.Button()
        Me.TextBox_AddScript = New System.Windows.Forms.TextBox()
        Me.Label_AddNewScript = New System.Windows.Forms.Label()
        Me.Label_ScriptList = New System.Windows.Forms.Label()
        Me.ComboBox_ScriptList = New System.Windows.Forms.ComboBox()
        Me.DataGridView_StepEdit = New System.Windows.Forms.DataGridView()
        Me.Column_StepNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_StepName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_CommandType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_NextStep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_LastStep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Param1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Param2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Param3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Param4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Param5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Delay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage_Sequence = New System.Windows.Forms.TabPage()
        Me.CheckBox_LogEnable = New System.Windows.Forms.CheckBox()
        Me.Button_ClearScriptInSequence = New System.Windows.Forms.Button()
        Me.Button_GetScript = New System.Windows.Forms.Button()
        Me.Button_DeleteScriptInSequence = New System.Windows.Forms.Button()
        Me.Button_StartSequence = New System.Windows.Forms.Button()
        Me.Button_ClearSequence = New System.Windows.Forms.Button()
        Me.Button_SaveSequence = New System.Windows.Forms.Button()
        Me.Button_DeleteSequence = New System.Windows.Forms.Button()
        Me.Button_LoadSequence = New System.Windows.Forms.Button()
        Me.Button_AddSequence = New System.Windows.Forms.Button()
        Me.TextBox_AddSequence = New System.Windows.Forms.TextBox()
        Me.Label_AddSequence = New System.Windows.Forms.Label()
        Me.Label_SequenceList = New System.Windows.Forms.Label()
        Me.ComboBox_SequenceList = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox_ScriptNum = New System.Windows.Forms.TextBox()
        Me.TextBox_TimeScript = New System.Windows.Forms.TextBox()
        Me.ComboBox_ScriptList4Sequence = New System.Windows.Forms.ComboBox()
        Me.TextBox_NextScript = New System.Windows.Forms.TextBox()
        Me.Label_ScriptNum = New System.Windows.Forms.Label()
        Me.Label_ScriptName = New System.Windows.Forms.Label()
        Me.Label_NextScript = New System.Windows.Forms.Label()
        Me.Label_TimeScript = New System.Windows.Forms.Label()
        Me.Button_InsertScriptInSequence = New System.Windows.Forms.Button()
        Me.DataGridView_Sequence = New System.Windows.Forms.DataGridView()
        Me.Column_ScriptNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_ScirptName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_NextScript = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_TimeScript = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button_ClearLog = New System.Windows.Forms.Button()
        Me.RichTextBox_RunLog = New System.Windows.Forms.RichTextBox()
        Me.Timer_Script = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip_Script = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel_Script = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer_Sequence = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_System = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage_Script.SuspendLayout()
        CType(Me.DataGridView_StepEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Sequence.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView_Sequence, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip_Script.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_DetectForm
        '
        Me.Button_DetectForm.Location = New System.Drawing.Point(881, 650)
        Me.Button_DetectForm.Name = "Button_DetectForm"
        Me.Button_DetectForm.Size = New System.Drawing.Size(108, 32)
        Me.Button_DetectForm.TabIndex = 8
        Me.Button_DetectForm.Text = "Detect Form"
        Me.Button_DetectForm.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_Script)
        Me.TabControl1.Controls.Add(Me.TabPage_Sequence)
        Me.TabControl1.Location = New System.Drawing.Point(17, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1003, 724)
        Me.TabControl1.TabIndex = 15
        '
        'TabPage_Script
        '
        Me.TabPage_Script.Controls.Add(Me.Button_CheckStep)
        Me.TabPage_Script.Controls.Add(Me.Button_ShowStepForm)
        Me.TabPage_Script.Controls.Add(Me.TextBox_StepNum_Start)
        Me.TabPage_Script.Controls.Add(Me.Button_StartScript)
        Me.TabPage_Script.Controls.Add(Me.Button_ClearAllStep)
        Me.TabPage_Script.Controls.Add(Me.Button_SaveScript)
        Me.TabPage_Script.Controls.Add(Me.Button_DeleteScript)
        Me.TabPage_Script.Controls.Add(Me.Button_LoadScript)
        Me.TabPage_Script.Controls.Add(Me.Button_AddNewScript)
        Me.TabPage_Script.Controls.Add(Me.TextBox_AddScript)
        Me.TabPage_Script.Controls.Add(Me.Label_AddNewScript)
        Me.TabPage_Script.Controls.Add(Me.Label_ScriptList)
        Me.TabPage_Script.Controls.Add(Me.ComboBox_ScriptList)
        Me.TabPage_Script.Controls.Add(Me.DataGridView_StepEdit)
        Me.TabPage_Script.Controls.Add(Me.Button_DetectForm)
        Me.TabPage_Script.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Script.Name = "TabPage_Script"
        Me.TabPage_Script.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Script.Size = New System.Drawing.Size(995, 698)
        Me.TabPage_Script.TabIndex = 0
        Me.TabPage_Script.Text = "Script"
        Me.TabPage_Script.UseVisualStyleBackColor = True
        '
        'Button_CheckStep
        '
        Me.Button_CheckStep.Location = New System.Drawing.Point(712, 634)
        Me.Button_CheckStep.Name = "Button_CheckStep"
        Me.Button_CheckStep.Size = New System.Drawing.Size(75, 23)
        Me.Button_CheckStep.TabIndex = 21
        Me.Button_CheckStep.Text = "Check"
        Me.Button_CheckStep.UseVisualStyleBackColor = True
        '
        'Button_ShowStepForm
        '
        Me.Button_ShowStepForm.Location = New System.Drawing.Point(6, 650)
        Me.Button_ShowStepForm.Name = "Button_ShowStepForm"
        Me.Button_ShowStepForm.Size = New System.Drawing.Size(105, 32)
        Me.Button_ShowStepForm.TabIndex = 20
        Me.Button_ShowStepForm.Text = "ShowStepForm"
        Me.Button_ShowStepForm.UseVisualStyleBackColor = True
        '
        'TextBox_StepNum_Start
        '
        Me.TextBox_StepNum_Start.Location = New System.Drawing.Point(6, 598)
        Me.TextBox_StepNum_Start.Name = "TextBox_StepNum_Start"
        Me.TextBox_StepNum_Start.Size = New System.Drawing.Size(63, 22)
        Me.TextBox_StepNum_Start.TabIndex = 19
        Me.TextBox_StepNum_Start.Text = "1"
        '
        'Button_StartScript
        '
        Me.Button_StartScript.Location = New System.Drawing.Point(75, 598)
        Me.Button_StartScript.Name = "Button_StartScript"
        Me.Button_StartScript.Size = New System.Drawing.Size(75, 23)
        Me.Button_StartScript.TabIndex = 18
        Me.Button_StartScript.Text = "Start"
        Me.Button_StartScript.UseVisualStyleBackColor = True
        '
        'Button_ClearAllStep
        '
        Me.Button_ClearAllStep.Location = New System.Drawing.Point(631, 663)
        Me.Button_ClearAllStep.Name = "Button_ClearAllStep"
        Me.Button_ClearAllStep.Size = New System.Drawing.Size(75, 23)
        Me.Button_ClearAllStep.TabIndex = 17
        Me.Button_ClearAllStep.Text = "Clear"
        Me.Button_ClearAllStep.UseVisualStyleBackColor = True
        '
        'Button_SaveScript
        '
        Me.Button_SaveScript.Location = New System.Drawing.Point(550, 634)
        Me.Button_SaveScript.Name = "Button_SaveScript"
        Me.Button_SaveScript.Size = New System.Drawing.Size(75, 23)
        Me.Button_SaveScript.TabIndex = 16
        Me.Button_SaveScript.Text = "Save"
        Me.Button_SaveScript.UseVisualStyleBackColor = True
        '
        'Button_DeleteScript
        '
        Me.Button_DeleteScript.Location = New System.Drawing.Point(550, 663)
        Me.Button_DeleteScript.Name = "Button_DeleteScript"
        Me.Button_DeleteScript.Size = New System.Drawing.Size(75, 23)
        Me.Button_DeleteScript.TabIndex = 15
        Me.Button_DeleteScript.Text = "Delete"
        Me.Button_DeleteScript.UseVisualStyleBackColor = True
        '
        'Button_LoadScript
        '
        Me.Button_LoadScript.Location = New System.Drawing.Point(631, 634)
        Me.Button_LoadScript.Name = "Button_LoadScript"
        Me.Button_LoadScript.Size = New System.Drawing.Size(75, 23)
        Me.Button_LoadScript.TabIndex = 14
        Me.Button_LoadScript.Text = "Load"
        Me.Button_LoadScript.UseVisualStyleBackColor = True
        '
        'Button_AddNewScript
        '
        Me.Button_AddNewScript.Location = New System.Drawing.Point(550, 598)
        Me.Button_AddNewScript.Name = "Button_AddNewScript"
        Me.Button_AddNewScript.Size = New System.Drawing.Size(75, 23)
        Me.Button_AddNewScript.TabIndex = 13
        Me.Button_AddNewScript.Text = "Add"
        Me.Button_AddNewScript.UseVisualStyleBackColor = True
        '
        'TextBox_AddScript
        '
        Me.TextBox_AddScript.Location = New System.Drawing.Point(426, 600)
        Me.TextBox_AddScript.Name = "TextBox_AddScript"
        Me.TextBox_AddScript.Size = New System.Drawing.Size(118, 22)
        Me.TextBox_AddScript.TabIndex = 12
        '
        'Label_AddNewScript
        '
        Me.Label_AddNewScript.AutoSize = True
        Me.Label_AddNewScript.Location = New System.Drawing.Point(365, 603)
        Me.Label_AddNewScript.Name = "Label_AddNewScript"
        Me.Label_AddNewScript.Size = New System.Drawing.Size(55, 12)
        Me.Label_AddNewScript.TabIndex = 11
        Me.Label_AddNewScript.Text = "Add Script"
        '
        'Label_ScriptList
        '
        Me.Label_ScriptList.AutoSize = True
        Me.Label_ScriptList.Location = New System.Drawing.Point(368, 639)
        Me.Label_ScriptList.Name = "Label_ScriptList"
        Me.Label_ScriptList.Size = New System.Drawing.Size(52, 12)
        Me.Label_ScriptList.TabIndex = 10
        Me.Label_ScriptList.Text = "Script List"
        '
        'ComboBox_ScriptList
        '
        Me.ComboBox_ScriptList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_ScriptList.FormattingEnabled = True
        Me.ComboBox_ScriptList.Location = New System.Drawing.Point(426, 636)
        Me.ComboBox_ScriptList.Name = "ComboBox_ScriptList"
        Me.ComboBox_ScriptList.Size = New System.Drawing.Size(118, 20)
        Me.ComboBox_ScriptList.TabIndex = 9
        '
        'DataGridView_StepEdit
        '
        Me.DataGridView_StepEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_StepEdit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_StepNum, Me.Column_StepName, Me.Column_CommandType, Me.Column_NextStep, Me.Column_LastStep, Me.Column_Param1, Me.Column_Param2, Me.Column_Param3, Me.Column_Param4, Me.Column_Param5, Me.Column_Delay})
        Me.DataGridView_StepEdit.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView_StepEdit.Name = "DataGridView_StepEdit"
        Me.DataGridView_StepEdit.RowHeadersVisible = False
        Me.DataGridView_StepEdit.RowTemplate.Height = 24
        Me.DataGridView_StepEdit.Size = New System.Drawing.Size(983, 574)
        Me.DataGridView_StepEdit.TabIndex = 0
        '
        'Column_StepNum
        '
        Me.Column_StepNum.Frozen = True
        Me.Column_StepNum.HeaderText = "StepNum"
        Me.Column_StepNum.Name = "Column_StepNum"
        Me.Column_StepNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column_StepNum.Width = 60
        '
        'Column_StepName
        '
        Me.Column_StepName.HeaderText = "StepName"
        Me.Column_StepName.Name = "Column_StepName"
        Me.Column_StepName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_CommandType
        '
        Me.Column_CommandType.HeaderText = "CommandType"
        Me.Column_CommandType.Name = "Column_CommandType"
        Me.Column_CommandType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_NextStep
        '
        Me.Column_NextStep.HeaderText = "NextStep"
        Me.Column_NextStep.Name = "Column_NextStep"
        Me.Column_NextStep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column_NextStep.Width = 60
        '
        'Column_LastStep
        '
        Me.Column_LastStep.HeaderText = "LastStep"
        Me.Column_LastStep.Name = "Column_LastStep"
        Me.Column_LastStep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column_LastStep.Width = 60
        '
        'Column_Param1
        '
        Me.Column_Param1.HeaderText = "Param1"
        Me.Column_Param1.Name = "Column_Param1"
        Me.Column_Param1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_Param2
        '
        Me.Column_Param2.HeaderText = "Param2"
        Me.Column_Param2.Name = "Column_Param2"
        Me.Column_Param2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_Param3
        '
        Me.Column_Param3.HeaderText = "Param3"
        Me.Column_Param3.Name = "Column_Param3"
        Me.Column_Param3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_Param4
        '
        Me.Column_Param4.HeaderText = "Param4"
        Me.Column_Param4.Name = "Column_Param4"
        Me.Column_Param4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_Param5
        '
        Me.Column_Param5.HeaderText = "Param5"
        Me.Column_Param5.Name = "Column_Param5"
        Me.Column_Param5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_Delay
        '
        Me.Column_Delay.HeaderText = "Delay"
        Me.Column_Delay.Name = "Column_Delay"
        Me.Column_Delay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TabPage_Sequence
        '
        Me.TabPage_Sequence.Controls.Add(Me.CheckBox_LogEnable)
        Me.TabPage_Sequence.Controls.Add(Me.Button_ClearScriptInSequence)
        Me.TabPage_Sequence.Controls.Add(Me.Button_GetScript)
        Me.TabPage_Sequence.Controls.Add(Me.Button_DeleteScriptInSequence)
        Me.TabPage_Sequence.Controls.Add(Me.Button_StartSequence)
        Me.TabPage_Sequence.Controls.Add(Me.Button_ClearSequence)
        Me.TabPage_Sequence.Controls.Add(Me.Button_SaveSequence)
        Me.TabPage_Sequence.Controls.Add(Me.Button_DeleteSequence)
        Me.TabPage_Sequence.Controls.Add(Me.Button_LoadSequence)
        Me.TabPage_Sequence.Controls.Add(Me.Button_AddSequence)
        Me.TabPage_Sequence.Controls.Add(Me.TextBox_AddSequence)
        Me.TabPage_Sequence.Controls.Add(Me.Label_AddSequence)
        Me.TabPage_Sequence.Controls.Add(Me.Label_SequenceList)
        Me.TabPage_Sequence.Controls.Add(Me.ComboBox_SequenceList)
        Me.TabPage_Sequence.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage_Sequence.Controls.Add(Me.Button_InsertScriptInSequence)
        Me.TabPage_Sequence.Controls.Add(Me.DataGridView_Sequence)
        Me.TabPage_Sequence.Controls.Add(Me.Button_ClearLog)
        Me.TabPage_Sequence.Controls.Add(Me.RichTextBox_RunLog)
        Me.TabPage_Sequence.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Sequence.Name = "TabPage_Sequence"
        Me.TabPage_Sequence.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Sequence.Size = New System.Drawing.Size(995, 698)
        Me.TabPage_Sequence.TabIndex = 1
        Me.TabPage_Sequence.Text = "Sequence"
        Me.TabPage_Sequence.UseVisualStyleBackColor = True
        '
        'CheckBox_LogEnable
        '
        Me.CheckBox_LogEnable.AutoSize = True
        Me.CheckBox_LogEnable.Checked = True
        Me.CheckBox_LogEnable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_LogEnable.Location = New System.Drawing.Point(686, 644)
        Me.CheckBox_LogEnable.Name = "CheckBox_LogEnable"
        Me.CheckBox_LogEnable.Size = New System.Drawing.Size(75, 16)
        Me.CheckBox_LogEnable.TabIndex = 31
        Me.CheckBox_LogEnable.Text = "LogEnable"
        Me.CheckBox_LogEnable.UseVisualStyleBackColor = True
        '
        'Button_ClearScriptInSequence
        '
        Me.Button_ClearScriptInSequence.Location = New System.Drawing.Point(261, 578)
        Me.Button_ClearScriptInSequence.Name = "Button_ClearScriptInSequence"
        Me.Button_ClearScriptInSequence.Size = New System.Drawing.Size(75, 31)
        Me.Button_ClearScriptInSequence.TabIndex = 30
        Me.Button_ClearScriptInSequence.Text = "Clear"
        Me.Button_ClearScriptInSequence.UseVisualStyleBackColor = True
        '
        'Button_GetScript
        '
        Me.Button_GetScript.Location = New System.Drawing.Point(180, 578)
        Me.Button_GetScript.Name = "Button_GetScript"
        Me.Button_GetScript.Size = New System.Drawing.Size(75, 31)
        Me.Button_GetScript.TabIndex = 29
        Me.Button_GetScript.Text = "Get"
        Me.Button_GetScript.UseVisualStyleBackColor = True
        '
        'Button_DeleteScriptInSequence
        '
        Me.Button_DeleteScriptInSequence.Location = New System.Drawing.Point(99, 578)
        Me.Button_DeleteScriptInSequence.Name = "Button_DeleteScriptInSequence"
        Me.Button_DeleteScriptInSequence.Size = New System.Drawing.Size(75, 31)
        Me.Button_DeleteScriptInSequence.TabIndex = 28
        Me.Button_DeleteScriptInSequence.Text = "Delete"
        Me.Button_DeleteScriptInSequence.UseVisualStyleBackColor = True
        '
        'Button_StartSequence
        '
        Me.Button_StartSequence.Location = New System.Drawing.Point(18, 644)
        Me.Button_StartSequence.Name = "Button_StartSequence"
        Me.Button_StartSequence.Size = New System.Drawing.Size(75, 31)
        Me.Button_StartSequence.TabIndex = 27
        Me.Button_StartSequence.Text = "Start"
        Me.Button_StartSequence.UseVisualStyleBackColor = True
        '
        'Button_ClearSequence
        '
        Me.Button_ClearSequence.Location = New System.Drawing.Point(309, 430)
        Me.Button_ClearSequence.Name = "Button_ClearSequence"
        Me.Button_ClearSequence.Size = New System.Drawing.Size(75, 23)
        Me.Button_ClearSequence.TabIndex = 26
        Me.Button_ClearSequence.Text = "Clear"
        Me.Button_ClearSequence.UseVisualStyleBackColor = True
        '
        'Button_SaveSequence
        '
        Me.Button_SaveSequence.Location = New System.Drawing.Point(228, 401)
        Me.Button_SaveSequence.Name = "Button_SaveSequence"
        Me.Button_SaveSequence.Size = New System.Drawing.Size(75, 23)
        Me.Button_SaveSequence.TabIndex = 25
        Me.Button_SaveSequence.Text = "Save"
        Me.Button_SaveSequence.UseVisualStyleBackColor = True
        '
        'Button_DeleteSequence
        '
        Me.Button_DeleteSequence.Location = New System.Drawing.Point(228, 430)
        Me.Button_DeleteSequence.Name = "Button_DeleteSequence"
        Me.Button_DeleteSequence.Size = New System.Drawing.Size(75, 23)
        Me.Button_DeleteSequence.TabIndex = 24
        Me.Button_DeleteSequence.Text = "Delete"
        Me.Button_DeleteSequence.UseVisualStyleBackColor = True
        '
        'Button_LoadSequence
        '
        Me.Button_LoadSequence.Location = New System.Drawing.Point(309, 401)
        Me.Button_LoadSequence.Name = "Button_LoadSequence"
        Me.Button_LoadSequence.Size = New System.Drawing.Size(75, 23)
        Me.Button_LoadSequence.TabIndex = 23
        Me.Button_LoadSequence.Text = "Load"
        Me.Button_LoadSequence.UseVisualStyleBackColor = True
        '
        'Button_AddSequence
        '
        Me.Button_AddSequence.Location = New System.Drawing.Point(228, 365)
        Me.Button_AddSequence.Name = "Button_AddSequence"
        Me.Button_AddSequence.Size = New System.Drawing.Size(75, 23)
        Me.Button_AddSequence.TabIndex = 22
        Me.Button_AddSequence.Text = "Add"
        Me.Button_AddSequence.UseVisualStyleBackColor = True
        '
        'TextBox_AddSequence
        '
        Me.TextBox_AddSequence.Location = New System.Drawing.Point(104, 367)
        Me.TextBox_AddSequence.Name = "TextBox_AddSequence"
        Me.TextBox_AddSequence.Size = New System.Drawing.Size(118, 22)
        Me.TextBox_AddSequence.TabIndex = 21
        '
        'Label_AddSequence
        '
        Me.Label_AddSequence.AutoSize = True
        Me.Label_AddSequence.Location = New System.Drawing.Point(28, 370)
        Me.Label_AddSequence.Name = "Label_AddSequence"
        Me.Label_AddSequence.Size = New System.Drawing.Size(72, 12)
        Me.Label_AddSequence.TabIndex = 20
        Me.Label_AddSequence.Text = "Add Sequence"
        '
        'Label_SequenceList
        '
        Me.Label_SequenceList.AutoSize = True
        Me.Label_SequenceList.Location = New System.Drawing.Point(27, 406)
        Me.Label_SequenceList.Name = "Label_SequenceList"
        Me.Label_SequenceList.Size = New System.Drawing.Size(66, 12)
        Me.Label_SequenceList.TabIndex = 19
        Me.Label_SequenceList.Text = "SequenceList"
        '
        'ComboBox_SequenceList
        '
        Me.ComboBox_SequenceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_SequenceList.FormattingEnabled = True
        Me.ComboBox_SequenceList.Location = New System.Drawing.Point(104, 403)
        Me.ComboBox_SequenceList.Name = "ComboBox_SequenceList"
        Me.ComboBox_SequenceList.Size = New System.Drawing.Size(118, 20)
        Me.ComboBox_SequenceList.TabIndex = 18
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_ScriptNum, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_TimeScript, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox_ScriptList4Sequence, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_NextScript, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_ScriptNum, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_ScriptName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_NextScript, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_TimeScript, 3, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(18, 508)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(373, 53)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'TextBox_ScriptNum
        '
        Me.TextBox_ScriptNum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_ScriptNum.Location = New System.Drawing.Point(3, 29)
        Me.TextBox_ScriptNum.Name = "TextBox_ScriptNum"
        Me.TextBox_ScriptNum.Size = New System.Drawing.Size(87, 22)
        Me.TextBox_ScriptNum.TabIndex = 11
        Me.TextBox_ScriptNum.Text = "1"
        '
        'TextBox_TimeScript
        '
        Me.TextBox_TimeScript.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_TimeScript.Location = New System.Drawing.Point(282, 29)
        Me.TextBox_TimeScript.Name = "TextBox_TimeScript"
        Me.TextBox_TimeScript.Size = New System.Drawing.Size(88, 22)
        Me.TextBox_TimeScript.TabIndex = 13
        '
        'ComboBox_ScriptList4Sequence
        '
        Me.ComboBox_ScriptList4Sequence.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox_ScriptList4Sequence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_ScriptList4Sequence.FormattingEnabled = True
        Me.ComboBox_ScriptList4Sequence.Location = New System.Drawing.Point(96, 29)
        Me.ComboBox_ScriptList4Sequence.Name = "ComboBox_ScriptList4Sequence"
        Me.ComboBox_ScriptList4Sequence.Size = New System.Drawing.Size(87, 20)
        Me.ComboBox_ScriptList4Sequence.TabIndex = 10
        '
        'TextBox_NextScript
        '
        Me.TextBox_NextScript.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_NextScript.Location = New System.Drawing.Point(189, 29)
        Me.TextBox_NextScript.Name = "TextBox_NextScript"
        Me.TextBox_NextScript.Size = New System.Drawing.Size(87, 22)
        Me.TextBox_NextScript.TabIndex = 12
        Me.TextBox_NextScript.Text = "-1"
        '
        'Label_ScriptNum
        '
        Me.Label_ScriptNum.AutoSize = True
        Me.Label_ScriptNum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_ScriptNum.Location = New System.Drawing.Point(3, 0)
        Me.Label_ScriptNum.Name = "Label_ScriptNum"
        Me.Label_ScriptNum.Size = New System.Drawing.Size(87, 26)
        Me.Label_ScriptNum.TabIndex = 14
        Me.Label_ScriptNum.Text = "ScriptNum"
        Me.Label_ScriptNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_ScriptName
        '
        Me.Label_ScriptName.AutoSize = True
        Me.Label_ScriptName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_ScriptName.Location = New System.Drawing.Point(96, 0)
        Me.Label_ScriptName.Name = "Label_ScriptName"
        Me.Label_ScriptName.Size = New System.Drawing.Size(87, 26)
        Me.Label_ScriptName.TabIndex = 15
        Me.Label_ScriptName.Text = "ScriptName"
        Me.Label_ScriptName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_NextScript
        '
        Me.Label_NextScript.AutoSize = True
        Me.Label_NextScript.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_NextScript.Location = New System.Drawing.Point(189, 0)
        Me.Label_NextScript.Name = "Label_NextScript"
        Me.Label_NextScript.Size = New System.Drawing.Size(87, 26)
        Me.Label_NextScript.TabIndex = 16
        Me.Label_NextScript.Text = "NextScript"
        Me.Label_NextScript.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_TimeScript
        '
        Me.Label_TimeScript.AutoSize = True
        Me.Label_TimeScript.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_TimeScript.Location = New System.Drawing.Point(282, 0)
        Me.Label_TimeScript.Name = "Label_TimeScript"
        Me.Label_TimeScript.Size = New System.Drawing.Size(88, 26)
        Me.Label_TimeScript.TabIndex = 17
        Me.Label_TimeScript.Text = "TimeScript"
        Me.Label_TimeScript.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_InsertScriptInSequence
        '
        Me.Button_InsertScriptInSequence.Location = New System.Drawing.Point(18, 578)
        Me.Button_InsertScriptInSequence.Name = "Button_InsertScriptInSequence"
        Me.Button_InsertScriptInSequence.Size = New System.Drawing.Size(75, 31)
        Me.Button_InsertScriptInSequence.TabIndex = 3
        Me.Button_InsertScriptInSequence.Text = "Insert"
        Me.Button_InsertScriptInSequence.UseVisualStyleBackColor = True
        '
        'DataGridView_Sequence
        '
        Me.DataGridView_Sequence.AccessibleDescription = ""
        Me.DataGridView_Sequence.AccessibleName = ""
        Me.DataGridView_Sequence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Sequence.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_ScriptNum, Me.Column_ScirptName, Me.Column_NextScript, Me.Column_TimeScript})
        Me.DataGridView_Sequence.Location = New System.Drawing.Point(18, 15)
        Me.DataGridView_Sequence.Name = "DataGridView_Sequence"
        Me.DataGridView_Sequence.RowHeadersVisible = False
        Me.DataGridView_Sequence.RowTemplate.Height = 24
        Me.DataGridView_Sequence.Size = New System.Drawing.Size(384, 330)
        Me.DataGridView_Sequence.TabIndex = 2
        Me.DataGridView_Sequence.Tag = ""
        '
        'Column_ScriptNum
        '
        Me.Column_ScriptNum.Frozen = True
        Me.Column_ScriptNum.HeaderText = "ScriptNum"
        Me.Column_ScriptNum.Name = "Column_ScriptNum"
        Me.Column_ScriptNum.Width = 60
        '
        'Column_ScirptName
        '
        Me.Column_ScirptName.HeaderText = "ScirptName"
        Me.Column_ScirptName.Name = "Column_ScirptName"
        Me.Column_ScirptName.Width = 120
        '
        'Column_NextScript
        '
        Me.Column_NextScript.HeaderText = "NextScript"
        Me.Column_NextScript.Name = "Column_NextScript"
        '
        'Column_TimeScript
        '
        Me.Column_TimeScript.HeaderText = "TimeScript"
        Me.Column_TimeScript.Name = "Column_TimeScript"
        '
        'Button_ClearLog
        '
        Me.Button_ClearLog.Location = New System.Drawing.Point(890, 644)
        Me.Button_ClearLog.Name = "Button_ClearLog"
        Me.Button_ClearLog.Size = New System.Drawing.Size(75, 31)
        Me.Button_ClearLog.TabIndex = 1
        Me.Button_ClearLog.Text = "Clear"
        Me.Button_ClearLog.UseVisualStyleBackColor = True
        '
        'RichTextBox_RunLog
        '
        Me.RichTextBox_RunLog.Location = New System.Drawing.Point(686, 15)
        Me.RichTextBox_RunLog.Name = "RichTextBox_RunLog"
        Me.RichTextBox_RunLog.ReadOnly = True
        Me.RichTextBox_RunLog.Size = New System.Drawing.Size(279, 617)
        Me.RichTextBox_RunLog.TabIndex = 0
        Me.RichTextBox_RunLog.Text = ""
        '
        'Timer_Script
        '
        Me.Timer_Script.Interval = 1000
        '
        'StatusStrip_Script
        '
        Me.StatusStrip_Script.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel_Script})
        Me.StatusStrip_Script.Location = New System.Drawing.Point(0, 749)
        Me.StatusStrip_Script.Name = "StatusStrip_Script"
        Me.StatusStrip_Script.Size = New System.Drawing.Size(1036, 22)
        Me.StatusStrip_Script.TabIndex = 16
        Me.StatusStrip_Script.Text = "aaa"
        '
        'ToolStripStatusLabel_Script
        '
        Me.ToolStripStatusLabel_Script.Name = "ToolStripStatusLabel_Script"
        Me.ToolStripStatusLabel_Script.Size = New System.Drawing.Size(40, 17)
        Me.ToolStripStatusLabel_Script.Text = "Script"
        '
        'Timer_Sequence
        '
        '
        'Timer_System
        '
        '
        'MainFormEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1036, 771)
        Me.Controls.Add(Me.StatusStrip_Script)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "MainFormEvent"
        Me.Text = "SW verification tool"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_Script.ResumeLayout(False)
        Me.TabPage_Script.PerformLayout()
        CType(Me.DataGridView_StepEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Sequence.ResumeLayout(False)
        Me.TabPage_Sequence.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataGridView_Sequence, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip_Script.ResumeLayout(False)
        Me.StatusStrip_Script.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_DetectForm As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Script As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Sequence As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView_StepEdit As System.Windows.Forms.DataGridView
    Friend WithEvents Button_DeleteScript As System.Windows.Forms.Button
    Friend WithEvents Button_LoadScript As System.Windows.Forms.Button
    Friend WithEvents Button_AddNewScript As System.Windows.Forms.Button
    Friend WithEvents TextBox_AddScript As System.Windows.Forms.TextBox
    Friend WithEvents Label_AddNewScript As System.Windows.Forms.Label
    Friend WithEvents Label_ScriptList As System.Windows.Forms.Label
    Friend WithEvents ComboBox_ScriptList As System.Windows.Forms.ComboBox
    Friend WithEvents Button_SaveScript As System.Windows.Forms.Button
    Friend WithEvents Button_ClearAllStep As System.Windows.Forms.Button
    Friend WithEvents Button_StartScript As System.Windows.Forms.Button
    Friend WithEvents Timer_Script As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip_Script As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel_Script As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Column_StepNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_StepName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_CommandType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_NextStep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_LastStep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_Param1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_Param2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_Param3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_Param4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_Param5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_Delay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox_StepNum_Start As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox_RunLog As System.Windows.Forms.RichTextBox
    Friend WithEvents Button_ClearLog As System.Windows.Forms.Button
    Friend WithEvents DataGridView_Sequence As System.Windows.Forms.DataGridView
    Friend WithEvents Button_InsertScriptInSequence As System.Windows.Forms.Button
    Friend WithEvents ComboBox_ScriptList4Sequence As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox_ScriptNum As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TextBox_TimeScript As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_NextScript As System.Windows.Forms.TextBox
    Friend WithEvents Label_ScriptNum As System.Windows.Forms.Label
    Friend WithEvents Label_ScriptName As System.Windows.Forms.Label
    Friend WithEvents Label_NextScript As System.Windows.Forms.Label
    Friend WithEvents Label_TimeScript As System.Windows.Forms.Label
    Friend WithEvents Button_ClearSequence As System.Windows.Forms.Button
    Friend WithEvents Button_SaveSequence As System.Windows.Forms.Button
    Friend WithEvents Button_DeleteSequence As System.Windows.Forms.Button
    Friend WithEvents Button_LoadSequence As System.Windows.Forms.Button
    Friend WithEvents Button_AddSequence As System.Windows.Forms.Button
    Friend WithEvents TextBox_AddSequence As System.Windows.Forms.TextBox
    Friend WithEvents Label_AddSequence As System.Windows.Forms.Label
    Friend WithEvents Label_SequenceList As System.Windows.Forms.Label
    Friend WithEvents ComboBox_SequenceList As System.Windows.Forms.ComboBox
    Friend WithEvents Button_StartSequence As System.Windows.Forms.Button
    Friend WithEvents Timer_Sequence As System.Windows.Forms.Timer
    Friend WithEvents Button_DeleteScriptInSequence As System.Windows.Forms.Button
    Friend WithEvents Button_ClearScriptInSequence As System.Windows.Forms.Button
    Friend WithEvents Button_GetScript As System.Windows.Forms.Button
    Friend WithEvents Column_ScriptNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_ScirptName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_NextScript As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_TimeScript As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckBox_LogEnable As System.Windows.Forms.CheckBox
    Friend WithEvents Button_ShowStepForm As System.Windows.Forms.Button
    Friend WithEvents Button_CheckStep As System.Windows.Forms.Button
    Friend WithEvents Timer_System As System.Windows.Forms.Timer

End Class
