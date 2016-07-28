<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetectFormEvent
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
        Me.Timer_Detect = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox_Detect_WndTitle = New System.Windows.Forms.TextBox()
        Me.Label_AbsoluteCoordinate = New System.Windows.Forms.Label()
        Me.TextBox_Axis_X = New System.Windows.Forms.TextBox()
        Me.Label_RelativeCoordinate = New System.Windows.Forms.Label()
        Me.Label_Axis_X = New System.Windows.Forms.Label()
        Me.TextBox_Relative_Y = New System.Windows.Forms.TextBox()
        Me.TextBox_Axis_Y = New System.Windows.Forms.TextBox()
        Me.TextBox_Relative_X = New System.Windows.Forms.TextBox()
        Me.Label_WinTitle = New System.Windows.Forms.Label()
        Me.Label_WinClass = New System.Windows.Forms.Label()
        Me.TextBox_Detect_WndClass = New System.Windows.Forms.TextBox()
        Me.Label_Axis_Y = New System.Windows.Forms.Label()
        Me.Button_Detect = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_CommandType = New System.Windows.Forms.Label()
        Me.Label_StepName = New System.Windows.Forms.Label()
        Me.Label_StepNum = New System.Windows.Forms.Label()
        Me.ComboBox_CommandType = New System.Windows.Forms.ComboBox()
        Me.TextBox_StepNum = New System.Windows.Forms.TextBox()
        Me.TextBox_StepName = New System.Windows.Forms.TextBox()
        Me.Label_Delay = New System.Windows.Forms.Label()
        Me.Label_NextStep = New System.Windows.Forms.Label()
        Me.Label_LastStep = New System.Windows.Forms.Label()
        Me.TextBox_Delay = New System.Windows.Forms.TextBox()
        Me.TextBox_NextStep = New System.Windows.Forms.TextBox()
        Me.TextBox_LastStep = New System.Windows.Forms.TextBox()
        Me.GroupBox_Detect = New System.Windows.Forms.GroupBox()
        Me.Label_Color_Axis_Y = New System.Windows.Forms.Label()
        Me.Label_Color_Axis_X = New System.Windows.Forms.Label()
        Me.TextBox_Relative_X_BottomRight = New System.Windows.Forms.TextBox()
        Me.TextBox_Relative_Y_BottomRight = New System.Windows.Forms.TextBox()
        Me.Label_RelativeCoordinate_2 = New System.Windows.Forms.Label()
        Me.Label_Detect_MouseScrollCount = New System.Windows.Forms.Label()
        Me.TextBox_Detect_MouseScrollCount = New System.Windows.Forms.TextBox()
        Me.GroupBox_ImageDetect = New System.Windows.Forms.GroupBox()
        Me.Label_ImageName = New System.Windows.Forms.Label()
        Me.CheckBox_LockName = New System.Windows.Forms.CheckBox()
        Me.TextBox_BottomRight_X = New System.Windows.Forms.TextBox()
        Me.Label_Duplicate_Clear_Data = New System.Windows.Forms.Label()
        Me.Label_SaveImage_TopLeft = New System.Windows.Forms.Label()
        Me.TextBox_SaveImageName = New System.Windows.Forms.TextBox()
        Me.TextBox_TopLeft_X = New System.Windows.Forms.TextBox()
        Me.Label_SaveImage = New System.Windows.Forms.Label()
        Me.TextBox_TopLeft_Y = New System.Windows.Forms.TextBox()
        Me.TextBox_BottomRight_Y = New System.Windows.Forms.TextBox()
        Me.Label_BottomRight = New System.Windows.Forms.Label()
        Me.Label_ColorCoordinate = New System.Windows.Forms.Label()
        Me.TextBox_Color_X = New System.Windows.Forms.TextBox()
        Me.TextBox_Color_Y = New System.Windows.Forms.TextBox()
        Me.Button_GetColorFromPosition = New System.Windows.Forms.Button()
        Me.CheckBox_Detect_LockWnd = New System.Windows.Forms.CheckBox()
        Me.Button_Duplicate = New System.Windows.Forms.Button()
        Me.Label_Detect_Color = New System.Windows.Forms.Label()
        Me.TextBox_Detect_Color = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox_MouseScrollCount = New System.Windows.Forms.TextBox()
        Me.Label_MouseScrollCount = New System.Windows.Forms.Label()
        Me.Label_Position = New System.Windows.Forms.Label()
        Me.Label_ImgSize = New System.Windows.Forms.Label()
        Me.Label_PixelLowLim = New System.Windows.Forms.Label()
        Me.Label_PixelHiLim = New System.Windows.Forms.Label()
        Me.TextBox_Position = New System.Windows.Forms.TextBox()
        Me.TextBox_ImgSize = New System.Windows.Forms.TextBox()
        Me.TextBox_PixelLowLim = New System.Windows.Forms.TextBox()
        Me.TextBox_PixelHiLim = New System.Windows.Forms.TextBox()
        Me.Label_Position_Up = New System.Windows.Forms.Label()
        Me.TextBox_Position_Up = New System.Windows.Forms.TextBox()
        Me.Label_TypeString = New System.Windows.Forms.Label()
        Me.TextBox_TypeString = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_WndClass = New System.Windows.Forms.Label()
        Me.Label_WndTitle = New System.Windows.Forms.Label()
        Me.TextBox_WndTitle = New System.Windows.Forms.TextBox()
        Me.TextBox_WndClass = New System.Windows.Forms.TextBox()
        Me.Button_DeleteStep = New System.Windows.Forms.Button()
        Me.Button_InsertStep = New System.Windows.Forms.Button()
        Me.Button_ClearCmd = New System.Windows.Forms.Button()
        Me.Button_GetStep = New System.Windows.Forms.Button()
        Me.TabControl_ParamSet = New System.Windows.Forms.TabControl()
        Me.TabPage_Window = New System.Windows.Forms.TabPage()
        Me.CheckBox_TempWinHandle = New System.Windows.Forms.CheckBox()
        Me.TabPage_Variable = New System.Windows.Forms.TabPage()
        Me.Label_SVARCheck = New System.Windows.Forms.Label()
        Me.TextBox_SVARCheck = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_VARHiLim = New System.Windows.Forms.Label()
        Me.Label_VARLowLim = New System.Windows.Forms.Label()
        Me.NumericUpDown_VARHiLim = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_VARLowLim = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBox_SVARIndex = New System.Windows.Forms.ComboBox()
        Me.Label_SVARIndex = New System.Windows.Forms.Label()
        Me.Label_SVAR_Equal = New System.Windows.Forms.Label()
        Me.Label_SVAR_String = New System.Windows.Forms.Label()
        Me.TextBox_SVAR_String = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_VARIndex = New System.Windows.Forms.Label()
        Me.Label_VAR_Equal = New System.Windows.Forms.Label()
        Me.Label_VARs = New System.Windows.Forms.Label()
        Me.Label_Numeric = New System.Windows.Forms.Label()
        Me.ComboBox_VAR_Operator = New System.Windows.Forms.ComboBox()
        Me.ComboBox_VARIndex = New System.Windows.Forms.ComboBox()
        Me.ComboBox_VARsIndex = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown_VARr = New System.Windows.Forms.NumericUpDown()
        Me.TabPage_File = New System.Windows.Forms.TabPage()
        Me.ComboBox_FileToSVAR = New System.Windows.Forms.ComboBox()
        Me.Label_ToSVAR = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_SourcePath = New System.Windows.Forms.Label()
        Me.Label_DestPath = New System.Windows.Forms.Label()
        Me.TextBox_SourcePath = New System.Windows.Forms.TextBox()
        Me.Label_String = New System.Windows.Forms.Label()
        Me.TextBox_FileString = New System.Windows.Forms.TextBox()
        Me.TextBox_DestPath = New System.Windows.Forms.TextBox()
        Me.TabPage_System = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_WatchDogIndex = New System.Windows.Forms.Label()
        Me.Label_WatchDogFeedTime = New System.Windows.Forms.Label()
        Me.Label_WatchDogFeedTime_Minute = New System.Windows.Forms.Label()
        Me.ComboBox_WatchDogIndex = New System.Windows.Forms.ComboBox()
        Me.TextBox_WatchDogFeedTime = New System.Windows.Forms.TextBox()
        Me.Label_ForceAboutTimer_Minute = New System.Windows.Forms.Label()
        Me.Label_ForceAboutTimer = New System.Windows.Forms.Label()
        Me.TextBox_ForceAboutTimer = New System.Windows.Forms.TextBox()
        Me.Button_ReplaceStep = New System.Windows.Forms.Button()
        Me.StatusStrip_DetectForm = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel_DetectForm = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox_Detect.SuspendLayout()
        Me.GroupBox_ImageDetect.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TabControl_ParamSet.SuspendLayout()
        Me.TabPage_Window.SuspendLayout()
        Me.TabPage_Variable.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.NumericUpDown_VARHiLim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_VARLowLim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.NumericUpDown_VARr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_File.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TabPage_System.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.StatusStrip_DetectForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer_Detect
        '
        '
        'TextBox_Detect_WndTitle
        '
        Me.TextBox_Detect_WndTitle.Location = New System.Drawing.Point(44, 156)
        Me.TextBox_Detect_WndTitle.Name = "TextBox_Detect_WndTitle"
        Me.TextBox_Detect_WndTitle.Size = New System.Drawing.Size(294, 22)
        Me.TextBox_Detect_WndTitle.TabIndex = 18
        Me.TextBox_Detect_WndTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_AbsoluteCoordinate
        '
        Me.Label_AbsoluteCoordinate.AutoSize = True
        Me.Label_AbsoluteCoordinate.Location = New System.Drawing.Point(9, 35)
        Me.Label_AbsoluteCoordinate.Name = "Label_AbsoluteCoordinate"
        Me.Label_AbsoluteCoordinate.Size = New System.Drawing.Size(98, 12)
        Me.Label_AbsoluteCoordinate.TabIndex = 25
        Me.Label_AbsoluteCoordinate.Text = "Absolute coordinate"
        '
        'TextBox_Axis_X
        '
        Me.TextBox_Axis_X.Location = New System.Drawing.Point(117, 32)
        Me.TextBox_Axis_X.Name = "TextBox_Axis_X"
        Me.TextBox_Axis_X.Size = New System.Drawing.Size(48, 22)
        Me.TextBox_Axis_X.TabIndex = 15
        Me.TextBox_Axis_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_RelativeCoordinate
        '
        Me.Label_RelativeCoordinate.AutoSize = True
        Me.Label_RelativeCoordinate.Location = New System.Drawing.Point(12, 62)
        Me.Label_RelativeCoordinate.Name = "Label_RelativeCoordinate"
        Me.Label_RelativeCoordinate.Size = New System.Drawing.Size(95, 12)
        Me.Label_RelativeCoordinate.TabIndex = 24
        Me.Label_RelativeCoordinate.Text = "Relative coordinate"
        '
        'Label_Axis_X
        '
        Me.Label_Axis_X.AutoSize = True
        Me.Label_Axis_X.Location = New System.Drawing.Point(134, 17)
        Me.Label_Axis_X.Name = "Label_Axis_X"
        Me.Label_Axis_X.Size = New System.Drawing.Size(13, 12)
        Me.Label_Axis_X.TabIndex = 16
        Me.Label_Axis_X.Text = "X"
        '
        'TextBox_Relative_Y
        '
        Me.TextBox_Relative_Y.Location = New System.Drawing.Point(171, 59)
        Me.TextBox_Relative_Y.Name = "TextBox_Relative_Y"
        Me.TextBox_Relative_Y.Size = New System.Drawing.Size(48, 22)
        Me.TextBox_Relative_Y.TabIndex = 23
        Me.TextBox_Relative_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_Axis_Y
        '
        Me.TextBox_Axis_Y.Location = New System.Drawing.Point(171, 32)
        Me.TextBox_Axis_Y.Name = "TextBox_Axis_Y"
        Me.TextBox_Axis_Y.Size = New System.Drawing.Size(48, 22)
        Me.TextBox_Axis_Y.TabIndex = 17
        Me.TextBox_Axis_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_Relative_X
        '
        Me.TextBox_Relative_X.Location = New System.Drawing.Point(117, 59)
        Me.TextBox_Relative_X.Name = "TextBox_Relative_X"
        Me.TextBox_Relative_X.Size = New System.Drawing.Size(48, 22)
        Me.TextBox_Relative_X.TabIndex = 22
        Me.TextBox_Relative_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_WinTitle
        '
        Me.Label_WinTitle.AutoSize = True
        Me.Label_WinTitle.Location = New System.Drawing.Point(12, 159)
        Me.Label_WinTitle.Name = "Label_WinTitle"
        Me.Label_WinTitle.Size = New System.Drawing.Size(26, 12)
        Me.Label_WinTitle.TabIndex = 19
        Me.Label_WinTitle.Text = "Title"
        '
        'Label_WinClass
        '
        Me.Label_WinClass.AutoSize = True
        Me.Label_WinClass.Location = New System.Drawing.Point(9, 187)
        Me.Label_WinClass.Name = "Label_WinClass"
        Me.Label_WinClass.Size = New System.Drawing.Size(29, 12)
        Me.Label_WinClass.TabIndex = 21
        Me.Label_WinClass.Text = "Class"
        '
        'TextBox_Detect_WndClass
        '
        Me.TextBox_Detect_WndClass.Location = New System.Drawing.Point(44, 184)
        Me.TextBox_Detect_WndClass.Name = "TextBox_Detect_WndClass"
        Me.TextBox_Detect_WndClass.Size = New System.Drawing.Size(294, 22)
        Me.TextBox_Detect_WndClass.TabIndex = 20
        Me.TextBox_Detect_WndClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Axis_Y
        '
        Me.Label_Axis_Y.AutoSize = True
        Me.Label_Axis_Y.Location = New System.Drawing.Point(187, 17)
        Me.Label_Axis_Y.Name = "Label_Axis_Y"
        Me.Label_Axis_Y.Size = New System.Drawing.Size(13, 12)
        Me.Label_Axis_Y.TabIndex = 26
        Me.Label_Axis_Y.Text = "Y"
        '
        'Button_Detect
        '
        Me.Button_Detect.Location = New System.Drawing.Point(477, 53)
        Me.Button_Detect.Name = "Button_Detect"
        Me.Button_Detect.Size = New System.Drawing.Size(108, 32)
        Me.Button_Detect.TabIndex = 27
        Me.Button_Detect.Text = "Detect(s)"
        Me.Button_Detect.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.55319!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.7234!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.7234!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label_CommandType, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_StepName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_StepNum, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox_CommandType, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_StepNum, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_StepName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Delay, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_NextStep, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_LastStep, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_Delay, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_NextStep, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_LastStep, 5, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(588, 57)
        Me.TableLayoutPanel1.TabIndex = 28
        '
        'Label_CommandType
        '
        Me.Label_CommandType.AutoSize = True
        Me.Label_CommandType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_CommandType.Location = New System.Drawing.Point(202, 0)
        Me.Label_CommandType.Name = "Label_CommandType"
        Me.Label_CommandType.Size = New System.Drawing.Size(113, 28)
        Me.Label_CommandType.TabIndex = 2
        Me.Label_CommandType.Text = "CommandType"
        Me.Label_CommandType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_StepName
        '
        Me.Label_StepName.AutoSize = True
        Me.Label_StepName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_StepName.Location = New System.Drawing.Point(73, 0)
        Me.Label_StepName.Name = "Label_StepName"
        Me.Label_StepName.Size = New System.Drawing.Size(123, 28)
        Me.Label_StepName.TabIndex = 1
        Me.Label_StepName.Text = "StepName"
        Me.Label_StepName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_StepNum
        '
        Me.Label_StepNum.AutoSize = True
        Me.Label_StepNum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_StepNum.Location = New System.Drawing.Point(3, 0)
        Me.Label_StepNum.Name = "Label_StepNum"
        Me.Label_StepNum.Size = New System.Drawing.Size(64, 28)
        Me.Label_StepNum.TabIndex = 0
        Me.Label_StepNum.Text = "StepNum"
        Me.Label_StepNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox_CommandType
        '
        Me.ComboBox_CommandType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox_CommandType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_CommandType.FormattingEnabled = True
        Me.ComboBox_CommandType.Location = New System.Drawing.Point(202, 31)
        Me.ComboBox_CommandType.Name = "ComboBox_CommandType"
        Me.ComboBox_CommandType.Size = New System.Drawing.Size(113, 20)
        Me.ComboBox_CommandType.TabIndex = 3
        '
        'TextBox_StepNum
        '
        Me.TextBox_StepNum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_StepNum.Location = New System.Drawing.Point(3, 31)
        Me.TextBox_StepNum.Name = "TextBox_StepNum"
        Me.TextBox_StepNum.Size = New System.Drawing.Size(64, 22)
        Me.TextBox_StepNum.TabIndex = 4
        Me.TextBox_StepNum.Text = "1"
        Me.TextBox_StepNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_StepName
        '
        Me.TextBox_StepName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_StepName.Location = New System.Drawing.Point(73, 31)
        Me.TextBox_StepName.Name = "TextBox_StepName"
        Me.TextBox_StepName.Size = New System.Drawing.Size(123, 22)
        Me.TextBox_StepName.TabIndex = 5
        Me.TextBox_StepName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Delay
        '
        Me.Label_Delay.AutoSize = True
        Me.Label_Delay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Delay.Location = New System.Drawing.Point(321, 0)
        Me.Label_Delay.Name = "Label_Delay"
        Me.Label_Delay.Size = New System.Drawing.Size(108, 28)
        Me.Label_Delay.TabIndex = 6
        Me.Label_Delay.Text = "Delay (ms)"
        Me.Label_Delay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_NextStep
        '
        Me.Label_NextStep.AutoSize = True
        Me.Label_NextStep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_NextStep.Location = New System.Drawing.Point(435, 0)
        Me.Label_NextStep.Name = "Label_NextStep"
        Me.Label_NextStep.Size = New System.Drawing.Size(71, 28)
        Me.Label_NextStep.TabIndex = 7
        Me.Label_NextStep.Text = "NextStep"
        Me.Label_NextStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_LastStep
        '
        Me.Label_LastStep.AutoSize = True
        Me.Label_LastStep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_LastStep.Location = New System.Drawing.Point(512, 0)
        Me.Label_LastStep.Name = "Label_LastStep"
        Me.Label_LastStep.Size = New System.Drawing.Size(73, 28)
        Me.Label_LastStep.TabIndex = 8
        Me.Label_LastStep.Text = "LastStep"
        Me.Label_LastStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_Delay
        '
        Me.TextBox_Delay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Delay.Location = New System.Drawing.Point(321, 31)
        Me.TextBox_Delay.Name = "TextBox_Delay"
        Me.TextBox_Delay.Size = New System.Drawing.Size(108, 22)
        Me.TextBox_Delay.TabIndex = 9
        Me.TextBox_Delay.Text = "1000"
        Me.TextBox_Delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_NextStep
        '
        Me.TextBox_NextStep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_NextStep.Location = New System.Drawing.Point(435, 31)
        Me.TextBox_NextStep.Name = "TextBox_NextStep"
        Me.TextBox_NextStep.Size = New System.Drawing.Size(71, 22)
        Me.TextBox_NextStep.TabIndex = 10
        Me.TextBox_NextStep.Text = "-1"
        Me.TextBox_NextStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_LastStep
        '
        Me.TextBox_LastStep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_LastStep.Location = New System.Drawing.Point(512, 31)
        Me.TextBox_LastStep.Name = "TextBox_LastStep"
        Me.TextBox_LastStep.Size = New System.Drawing.Size(73, 22)
        Me.TextBox_LastStep.TabIndex = 11
        Me.TextBox_LastStep.Text = "-1"
        Me.TextBox_LastStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox_Detect
        '
        Me.GroupBox_Detect.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox_Detect.Controls.Add(Me.Label_Color_Axis_Y)
        Me.GroupBox_Detect.Controls.Add(Me.Label_Color_Axis_X)
        Me.GroupBox_Detect.Controls.Add(Me.TextBox_Relative_X_BottomRight)
        Me.GroupBox_Detect.Controls.Add(Me.TextBox_Relative_Y_BottomRight)
        Me.GroupBox_Detect.Controls.Add(Me.Label_RelativeCoordinate_2)
        Me.GroupBox_Detect.Controls.Add(Me.Label_Detect_MouseScrollCount)
        Me.GroupBox_Detect.Controls.Add(Me.TextBox_Detect_MouseScrollCount)
        Me.GroupBox_Detect.Controls.Add(Me.GroupBox_ImageDetect)
        Me.GroupBox_Detect.Controls.Add(Me.Label_ColorCoordinate)
        Me.GroupBox_Detect.Controls.Add(Me.TextBox_Color_X)
        Me.GroupBox_Detect.Controls.Add(Me.TextBox_Color_Y)
        Me.GroupBox_Detect.Controls.Add(Me.Button_GetColorFromPosition)
        Me.GroupBox_Detect.Controls.Add(Me.CheckBox_Detect_LockWnd)
        Me.GroupBox_Detect.Controls.Add(Me.Button_Duplicate)
        Me.GroupBox_Detect.Controls.Add(Me.Label_Detect_Color)
        Me.GroupBox_Detect.Controls.Add(Me.TextBox_Detect_Color)
        Me.GroupBox_Detect.Controls.Add(Me.TextBox_Detect_WndTitle)
        Me.GroupBox_Detect.Controls.Add(Me.TextBox_Detect_WndClass)
        Me.GroupBox_Detect.Controls.Add(Me.Button_Detect)
        Me.GroupBox_Detect.Controls.Add(Me.Label_WinClass)
        Me.GroupBox_Detect.Controls.Add(Me.Label_Axis_Y)
        Me.GroupBox_Detect.Controls.Add(Me.Label_WinTitle)
        Me.GroupBox_Detect.Controls.Add(Me.TextBox_Relative_X)
        Me.GroupBox_Detect.Controls.Add(Me.Label_AbsoluteCoordinate)
        Me.GroupBox_Detect.Controls.Add(Me.TextBox_Axis_Y)
        Me.GroupBox_Detect.Controls.Add(Me.TextBox_Axis_X)
        Me.GroupBox_Detect.Controls.Add(Me.TextBox_Relative_Y)
        Me.GroupBox_Detect.Controls.Add(Me.Label_RelativeCoordinate)
        Me.GroupBox_Detect.Controls.Add(Me.Label_Axis_X)
        Me.GroupBox_Detect.Location = New System.Drawing.Point(12, 309)
        Me.GroupBox_Detect.Name = "GroupBox_Detect"
        Me.GroupBox_Detect.Size = New System.Drawing.Size(614, 379)
        Me.GroupBox_Detect.TabIndex = 29
        Me.GroupBox_Detect.TabStop = False
        Me.GroupBox_Detect.Text = "Detect"
        '
        'Label_Color_Axis_Y
        '
        Me.Label_Color_Axis_Y.AutoSize = True
        Me.Label_Color_Axis_Y.Location = New System.Drawing.Point(416, 17)
        Me.Label_Color_Axis_Y.Name = "Label_Color_Axis_Y"
        Me.Label_Color_Axis_Y.Size = New System.Drawing.Size(13, 12)
        Me.Label_Color_Axis_Y.TabIndex = 45
        Me.Label_Color_Axis_Y.Text = "Y"
        '
        'Label_Color_Axis_X
        '
        Me.Label_Color_Axis_X.AutoSize = True
        Me.Label_Color_Axis_X.Location = New System.Drawing.Point(363, 17)
        Me.Label_Color_Axis_X.Name = "Label_Color_Axis_X"
        Me.Label_Color_Axis_X.Size = New System.Drawing.Size(13, 12)
        Me.Label_Color_Axis_X.TabIndex = 44
        Me.Label_Color_Axis_X.Text = "X"
        '
        'TextBox_Relative_X_BottomRight
        '
        Me.TextBox_Relative_X_BottomRight.Location = New System.Drawing.Point(117, 87)
        Me.TextBox_Relative_X_BottomRight.Name = "TextBox_Relative_X_BottomRight"
        Me.TextBox_Relative_X_BottomRight.Size = New System.Drawing.Size(48, 22)
        Me.TextBox_Relative_X_BottomRight.TabIndex = 41
        Me.TextBox_Relative_X_BottomRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_Relative_Y_BottomRight
        '
        Me.TextBox_Relative_Y_BottomRight.Location = New System.Drawing.Point(171, 87)
        Me.TextBox_Relative_Y_BottomRight.Name = "TextBox_Relative_Y_BottomRight"
        Me.TextBox_Relative_Y_BottomRight.Size = New System.Drawing.Size(48, 22)
        Me.TextBox_Relative_Y_BottomRight.TabIndex = 42
        Me.TextBox_Relative_Y_BottomRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_RelativeCoordinate_2
        '
        Me.Label_RelativeCoordinate_2.AutoSize = True
        Me.Label_RelativeCoordinate_2.Location = New System.Drawing.Point(12, 90)
        Me.Label_RelativeCoordinate_2.Name = "Label_RelativeCoordinate_2"
        Me.Label_RelativeCoordinate_2.Size = New System.Drawing.Size(107, 12)
        Me.Label_RelativeCoordinate_2.TabIndex = 43
        Me.Label_RelativeCoordinate_2.Text = "Relative coordinate(r)"
        '
        'Label_Detect_MouseScrollCount
        '
        Me.Label_Detect_MouseScrollCount.AutoSize = True
        Me.Label_Detect_MouseScrollCount.Location = New System.Drawing.Point(19, 125)
        Me.Label_Detect_MouseScrollCount.Name = "Label_Detect_MouseScrollCount"
        Me.Label_Detect_MouseScrollCount.Size = New System.Drawing.Size(92, 12)
        Me.Label_Detect_MouseScrollCount.TabIndex = 40
        Me.Label_Detect_MouseScrollCount.Text = "MouseScrollCount"
        '
        'TextBox_Detect_MouseScrollCount
        '
        Me.TextBox_Detect_MouseScrollCount.Location = New System.Drawing.Point(117, 122)
        Me.TextBox_Detect_MouseScrollCount.Name = "TextBox_Detect_MouseScrollCount"
        Me.TextBox_Detect_MouseScrollCount.Size = New System.Drawing.Size(102, 22)
        Me.TextBox_Detect_MouseScrollCount.TabIndex = 39
        '
        'GroupBox_ImageDetect
        '
        Me.GroupBox_ImageDetect.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox_ImageDetect.Controls.Add(Me.Label_ImageName)
        Me.GroupBox_ImageDetect.Controls.Add(Me.CheckBox_LockName)
        Me.GroupBox_ImageDetect.Controls.Add(Me.TextBox_BottomRight_X)
        Me.GroupBox_ImageDetect.Controls.Add(Me.Label_Duplicate_Clear_Data)
        Me.GroupBox_ImageDetect.Controls.Add(Me.Label_SaveImage_TopLeft)
        Me.GroupBox_ImageDetect.Controls.Add(Me.TextBox_SaveImageName)
        Me.GroupBox_ImageDetect.Controls.Add(Me.TextBox_TopLeft_X)
        Me.GroupBox_ImageDetect.Controls.Add(Me.Label_SaveImage)
        Me.GroupBox_ImageDetect.Controls.Add(Me.TextBox_TopLeft_Y)
        Me.GroupBox_ImageDetect.Controls.Add(Me.TextBox_BottomRight_Y)
        Me.GroupBox_ImageDetect.Controls.Add(Me.Label_BottomRight)
        Me.GroupBox_ImageDetect.Location = New System.Drawing.Point(10, 212)
        Me.GroupBox_ImageDetect.Name = "GroupBox_ImageDetect"
        Me.GroupBox_ImageDetect.Size = New System.Drawing.Size(460, 154)
        Me.GroupBox_ImageDetect.TabIndex = 38
        Me.GroupBox_ImageDetect.TabStop = False
        Me.GroupBox_ImageDetect.Text = "Image Detect"
        '
        'Label_ImageName
        '
        Me.Label_ImageName.AutoSize = True
        Me.Label_ImageName.Location = New System.Drawing.Point(16, 27)
        Me.Label_ImageName.Name = "Label_ImageName"
        Me.Label_ImageName.Size = New System.Drawing.Size(61, 12)
        Me.Label_ImageName.TabIndex = 10
        Me.Label_ImageName.Text = "ImageName"
        '
        'CheckBox_LockName
        '
        Me.CheckBox_LockName.AutoSize = True
        Me.CheckBox_LockName.Location = New System.Drawing.Point(257, 23)
        Me.CheckBox_LockName.Name = "CheckBox_LockName"
        Me.CheckBox_LockName.Size = New System.Drawing.Size(167, 16)
        Me.CheckBox_LockName.TabIndex = 9
        Me.CheckBox_LockName.Text = "Must lock before saving image"
        Me.CheckBox_LockName.UseVisualStyleBackColor = True
        '
        'TextBox_BottomRight_X
        '
        Me.TextBox_BottomRight_X.Location = New System.Drawing.Point(97, 76)
        Me.TextBox_BottomRight_X.Name = "TextBox_BottomRight_X"
        Me.TextBox_BottomRight_X.Size = New System.Drawing.Size(74, 22)
        Me.TextBox_BottomRight_X.TabIndex = 4
        '
        'Label_Duplicate_Clear_Data
        '
        Me.Label_Duplicate_Clear_Data.AutoSize = True
        Me.Label_Duplicate_Clear_Data.Location = New System.Drawing.Point(15, 134)
        Me.Label_Duplicate_Clear_Data.Name = "Label_Duplicate_Clear_Data"
        Me.Label_Duplicate_Clear_Data.Size = New System.Drawing.Size(125, 12)
        Me.Label_Duplicate_Clear_Data.TabIndex = 8
        Me.Label_Duplicate_Clear_Data.Text = "4: Duplicate && Clear Data"
        '
        'Label_SaveImage_TopLeft
        '
        Me.Label_SaveImage_TopLeft.AutoSize = True
        Me.Label_SaveImage_TopLeft.Location = New System.Drawing.Point(15, 53)
        Me.Label_SaveImage_TopLeft.Name = "Label_SaveImage_TopLeft"
        Me.Label_SaveImage_TopLeft.Size = New System.Drawing.Size(55, 12)
        Me.Label_SaveImage_TopLeft.TabIndex = 0
        Me.Label_SaveImage_TopLeft.Text = "1: TopLeft"
        '
        'TextBox_SaveImageName
        '
        Me.TextBox_SaveImageName.Location = New System.Drawing.Point(97, 20)
        Me.TextBox_SaveImageName.Name = "TextBox_SaveImageName"
        Me.TextBox_SaveImageName.Size = New System.Drawing.Size(155, 22)
        Me.TextBox_SaveImageName.TabIndex = 7
        Me.TextBox_SaveImageName.Text = "./"
        '
        'TextBox_TopLeft_X
        '
        Me.TextBox_TopLeft_X.Location = New System.Drawing.Point(97, 48)
        Me.TextBox_TopLeft_X.Name = "TextBox_TopLeft_X"
        Me.TextBox_TopLeft_X.Size = New System.Drawing.Size(74, 22)
        Me.TextBox_TopLeft_X.TabIndex = 1
        '
        'Label_SaveImage
        '
        Me.Label_SaveImage.AutoSize = True
        Me.Label_SaveImage.Location = New System.Drawing.Point(15, 108)
        Me.Label_SaveImage.Name = "Label_SaveImage"
        Me.Label_SaveImage.Size = New System.Drawing.Size(68, 12)
        Me.Label_SaveImage.TabIndex = 6
        Me.Label_SaveImage.Text = "3: SaveImage"
        '
        'TextBox_TopLeft_Y
        '
        Me.TextBox_TopLeft_Y.Location = New System.Drawing.Point(178, 48)
        Me.TextBox_TopLeft_Y.Name = "TextBox_TopLeft_Y"
        Me.TextBox_TopLeft_Y.Size = New System.Drawing.Size(74, 22)
        Me.TextBox_TopLeft_Y.TabIndex = 2
        '
        'TextBox_BottomRight_Y
        '
        Me.TextBox_BottomRight_Y.Location = New System.Drawing.Point(178, 76)
        Me.TextBox_BottomRight_Y.Name = "TextBox_BottomRight_Y"
        Me.TextBox_BottomRight_Y.Size = New System.Drawing.Size(74, 22)
        Me.TextBox_BottomRight_Y.TabIndex = 5
        '
        'Label_BottomRight
        '
        Me.Label_BottomRight.AutoSize = True
        Me.Label_BottomRight.Location = New System.Drawing.Point(15, 81)
        Me.Label_BottomRight.Name = "Label_BottomRight"
        Me.Label_BottomRight.Size = New System.Drawing.Size(78, 12)
        Me.Label_BottomRight.TabIndex = 3
        Me.Label_BottomRight.Text = "2: BottomRight"
        '
        'Label_ColorCoordinate
        '
        Me.Label_ColorCoordinate.AutoSize = True
        Me.Label_ColorCoordinate.Location = New System.Drawing.Point(242, 35)
        Me.Label_ColorCoordinate.Name = "Label_ColorCoordinate"
        Me.Label_ColorCoordinate.Size = New System.Drawing.Size(101, 12)
        Me.Label_ColorCoordinate.TabIndex = 35
        Me.Label_ColorCoordinate.Text = "Color coordinates(c)"
        '
        'TextBox_Color_X
        '
        Me.TextBox_Color_X.Location = New System.Drawing.Point(347, 32)
        Me.TextBox_Color_X.Name = "TextBox_Color_X"
        Me.TextBox_Color_X.Size = New System.Drawing.Size(48, 22)
        Me.TextBox_Color_X.TabIndex = 33
        Me.TextBox_Color_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_Color_Y
        '
        Me.TextBox_Color_Y.Location = New System.Drawing.Point(401, 32)
        Me.TextBox_Color_Y.Name = "TextBox_Color_Y"
        Me.TextBox_Color_Y.Size = New System.Drawing.Size(48, 22)
        Me.TextBox_Color_Y.TabIndex = 34
        Me.TextBox_Color_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_GetColorFromPosition
        '
        Me.Button_GetColorFromPosition.Location = New System.Drawing.Point(347, 87)
        Me.Button_GetColorFromPosition.Name = "Button_GetColorFromPosition"
        Me.Button_GetColorFromPosition.Size = New System.Drawing.Size(106, 29)
        Me.Button_GetColorFromPosition.TabIndex = 32
        Me.Button_GetColorFromPosition.Text = "Get Color"
        Me.Button_GetColorFromPosition.UseVisualStyleBackColor = True
        '
        'CheckBox_Detect_LockWnd
        '
        Me.CheckBox_Detect_LockWnd.AutoSize = True
        Me.CheckBox_Detect_LockWnd.Checked = True
        Me.CheckBox_Detect_LockWnd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Detect_LockWnd.Location = New System.Drawing.Point(346, 162)
        Me.CheckBox_Detect_LockWnd.Name = "CheckBox_Detect_LockWnd"
        Me.CheckBox_Detect_LockWnd.Size = New System.Drawing.Size(107, 16)
        Me.CheckBox_Detect_LockWnd.TabIndex = 31
        Me.CheckBox_Detect_LockWnd.Text = "Lock &Window(w)"
        Me.CheckBox_Detect_LockWnd.UseVisualStyleBackColor = True
        '
        'Button_Duplicate
        '
        Me.Button_Duplicate.Location = New System.Drawing.Point(477, 17)
        Me.Button_Duplicate.Name = "Button_Duplicate"
        Me.Button_Duplicate.Size = New System.Drawing.Size(108, 30)
        Me.Button_Duplicate.TabIndex = 30
        Me.Button_Duplicate.Text = "Duplicate(&d)"
        Me.Button_Duplicate.UseVisualStyleBackColor = True
        '
        'Label_Detect_Color
        '
        Me.Label_Detect_Color.AutoSize = True
        Me.Label_Detect_Color.Location = New System.Drawing.Point(308, 62)
        Me.Label_Detect_Color.Name = "Label_Detect_Color"
        Me.Label_Detect_Color.Size = New System.Drawing.Size(32, 12)
        Me.Label_Detect_Color.TabIndex = 29
        Me.Label_Detect_Color.Text = "Color"
        '
        'TextBox_Detect_Color
        '
        Me.TextBox_Detect_Color.Location = New System.Drawing.Point(346, 59)
        Me.TextBox_Detect_Color.Name = "TextBox_Detect_Color"
        Me.TextBox_Detect_Color.Size = New System.Drawing.Size(103, 22)
        Me.TextBox_Detect_Color.TabIndex = 28
        Me.TextBox_Detect_Color.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox_MouseScrollCount, 5, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label_MouseScrollCount, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label_Position, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label_ImgSize, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label_PixelLowLim, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label_PixelHiLim, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox_Position, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox_ImgSize, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox_PixelLowLim, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox_PixelHiLim, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label_Position_Up, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox_Position_Up, 1, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(587, 54)
        Me.TableLayoutPanel2.TabIndex = 30
        '
        'TextBox_MouseScrollCount
        '
        Me.TextBox_MouseScrollCount.Location = New System.Drawing.Point(488, 30)
        Me.TextBox_MouseScrollCount.Name = "TextBox_MouseScrollCount"
        Me.TextBox_MouseScrollCount.Size = New System.Drawing.Size(96, 22)
        Me.TextBox_MouseScrollCount.TabIndex = 41
        Me.TextBox_MouseScrollCount.Text = "0"
        Me.TextBox_MouseScrollCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_MouseScrollCount
        '
        Me.Label_MouseScrollCount.AutoSize = True
        Me.Label_MouseScrollCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_MouseScrollCount.Location = New System.Drawing.Point(488, 0)
        Me.Label_MouseScrollCount.Name = "Label_MouseScrollCount"
        Me.Label_MouseScrollCount.Size = New System.Drawing.Size(96, 27)
        Me.Label_MouseScrollCount.TabIndex = 41
        Me.Label_MouseScrollCount.Text = "MouseScrollCount"
        Me.Label_MouseScrollCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_Position
        '
        Me.Label_Position.AutoSize = True
        Me.Label_Position.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Position.Location = New System.Drawing.Point(3, 0)
        Me.Label_Position.Name = "Label_Position"
        Me.Label_Position.Size = New System.Drawing.Size(91, 27)
        Me.Label_Position.TabIndex = 1
        Me.Label_Position.Text = "Position"
        Me.Label_Position.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_ImgSize
        '
        Me.Label_ImgSize.AutoSize = True
        Me.Label_ImgSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_ImgSize.Location = New System.Drawing.Point(197, 0)
        Me.Label_ImgSize.Name = "Label_ImgSize"
        Me.Label_ImgSize.Size = New System.Drawing.Size(91, 27)
        Me.Label_ImgSize.TabIndex = 2
        Me.Label_ImgSize.Text = "Image Size"
        Me.Label_ImgSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_PixelLowLim
        '
        Me.Label_PixelLowLim.AutoSize = True
        Me.Label_PixelLowLim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_PixelLowLim.Location = New System.Drawing.Point(294, 0)
        Me.Label_PixelLowLim.Name = "Label_PixelLowLim"
        Me.Label_PixelLowLim.Size = New System.Drawing.Size(91, 27)
        Me.Label_PixelLowLim.TabIndex = 3
        Me.Label_PixelLowLim.Text = "Low Limit of Pixel"
        Me.Label_PixelLowLim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_PixelHiLim
        '
        Me.Label_PixelHiLim.AutoSize = True
        Me.Label_PixelHiLim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_PixelHiLim.Location = New System.Drawing.Point(391, 0)
        Me.Label_PixelHiLim.Name = "Label_PixelHiLim"
        Me.Label_PixelHiLim.Size = New System.Drawing.Size(91, 27)
        Me.Label_PixelHiLim.TabIndex = 4
        Me.Label_PixelHiLim.Text = "Hi Limit of Pixel"
        Me.Label_PixelHiLim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_Position
        '
        Me.TextBox_Position.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Position.Location = New System.Drawing.Point(3, 30)
        Me.TextBox_Position.Name = "TextBox_Position"
        Me.TextBox_Position.Size = New System.Drawing.Size(91, 22)
        Me.TextBox_Position.TabIndex = 6
        Me.TextBox_Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_ImgSize
        '
        Me.TextBox_ImgSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_ImgSize.Location = New System.Drawing.Point(197, 30)
        Me.TextBox_ImgSize.Name = "TextBox_ImgSize"
        Me.TextBox_ImgSize.Size = New System.Drawing.Size(91, 22)
        Me.TextBox_ImgSize.TabIndex = 7
        Me.TextBox_ImgSize.Text = "(1,1)"
        Me.TextBox_ImgSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_PixelLowLim
        '
        Me.TextBox_PixelLowLim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_PixelLowLim.Location = New System.Drawing.Point(294, 30)
        Me.TextBox_PixelLowLim.Name = "TextBox_PixelLowLim"
        Me.TextBox_PixelLowLim.Size = New System.Drawing.Size(91, 22)
        Me.TextBox_PixelLowLim.TabIndex = 8
        Me.TextBox_PixelLowLim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_PixelHiLim
        '
        Me.TextBox_PixelHiLim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_PixelHiLim.Location = New System.Drawing.Point(391, 30)
        Me.TextBox_PixelHiLim.Name = "TextBox_PixelHiLim"
        Me.TextBox_PixelHiLim.Size = New System.Drawing.Size(91, 22)
        Me.TextBox_PixelHiLim.TabIndex = 9
        Me.TextBox_PixelHiLim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Position_Up
        '
        Me.Label_Position_Up.AutoSize = True
        Me.Label_Position_Up.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Position_Up.Location = New System.Drawing.Point(100, 0)
        Me.Label_Position_Up.Name = "Label_Position_Up"
        Me.Label_Position_Up.Size = New System.Drawing.Size(91, 27)
        Me.Label_Position_Up.TabIndex = 10
        Me.Label_Position_Up.Text = "Position(Up)"
        Me.Label_Position_Up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_Position_Up
        '
        Me.TextBox_Position_Up.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Position_Up.Location = New System.Drawing.Point(100, 30)
        Me.TextBox_Position_Up.Name = "TextBox_Position_Up"
        Me.TextBox_Position_Up.Size = New System.Drawing.Size(91, 22)
        Me.TextBox_Position_Up.TabIndex = 11
        Me.TextBox_Position_Up.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_TypeString
        '
        Me.Label_TypeString.AutoSize = True
        Me.Label_TypeString.Location = New System.Drawing.Point(8, 75)
        Me.Label_TypeString.Name = "Label_TypeString"
        Me.Label_TypeString.Size = New System.Drawing.Size(89, 12)
        Me.Label_TypeString.TabIndex = 10
        Me.Label_TypeString.Text = "Type String / Path"
        Me.Label_TypeString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_TypeString
        '
        Me.TextBox_TypeString.Location = New System.Drawing.Point(103, 70)
        Me.TextBox_TypeString.Name = "TextBox_TypeString"
        Me.TextBox_TypeString.Size = New System.Drawing.Size(288, 22)
        Me.TextBox_TypeString.TabIndex = 11
        Me.TextBox_TypeString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.73779!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.26221!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label_WndClass, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label_WndTitle, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBox_WndTitle, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBox_WndClass, 1, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 102)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(389, 61)
        Me.TableLayoutPanel3.TabIndex = 31
        '
        'Label_WndClass
        '
        Me.Label_WndClass.AutoSize = True
        Me.Label_WndClass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_WndClass.Location = New System.Drawing.Point(3, 30)
        Me.Label_WndClass.Name = "Label_WndClass"
        Me.Label_WndClass.Size = New System.Drawing.Size(62, 31)
        Me.Label_WndClass.TabIndex = 22
        Me.Label_WndClass.Text = "Class"
        Me.Label_WndClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_WndTitle
        '
        Me.Label_WndTitle.AutoSize = True
        Me.Label_WndTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_WndTitle.Location = New System.Drawing.Point(3, 0)
        Me.Label_WndTitle.Name = "Label_WndTitle"
        Me.Label_WndTitle.Size = New System.Drawing.Size(62, 30)
        Me.Label_WndTitle.TabIndex = 20
        Me.Label_WndTitle.Text = "Title"
        Me.Label_WndTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_WndTitle
        '
        Me.TextBox_WndTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_WndTitle.Location = New System.Drawing.Point(71, 3)
        Me.TextBox_WndTitle.Name = "TextBox_WndTitle"
        Me.TextBox_WndTitle.Size = New System.Drawing.Size(315, 22)
        Me.TextBox_WndTitle.TabIndex = 23
        Me.TextBox_WndTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_WndClass
        '
        Me.TextBox_WndClass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_WndClass.Location = New System.Drawing.Point(71, 33)
        Me.TextBox_WndClass.Name = "TextBox_WndClass"
        Me.TextBox_WndClass.Size = New System.Drawing.Size(315, 22)
        Me.TextBox_WndClass.TabIndex = 24
        Me.TextBox_WndClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_DeleteStep
        '
        Me.Button_DeleteStep.Location = New System.Drawing.Point(636, 178)
        Me.Button_DeleteStep.Name = "Button_DeleteStep"
        Me.Button_DeleteStep.Size = New System.Drawing.Size(82, 29)
        Me.Button_DeleteStep.TabIndex = 33
        Me.Button_DeleteStep.Text = "Delete"
        Me.Button_DeleteStep.UseVisualStyleBackColor = True
        '
        'Button_InsertStep
        '
        Me.Button_InsertStep.Location = New System.Drawing.Point(636, 144)
        Me.Button_InsertStep.Name = "Button_InsertStep"
        Me.Button_InsertStep.Size = New System.Drawing.Size(82, 29)
        Me.Button_InsertStep.TabIndex = 32
        Me.Button_InsertStep.Text = "Insert"
        Me.Button_InsertStep.UseVisualStyleBackColor = True
        '
        'Button_ClearCmd
        '
        Me.Button_ClearCmd.Location = New System.Drawing.Point(636, 260)
        Me.Button_ClearCmd.Name = "Button_ClearCmd"
        Me.Button_ClearCmd.Size = New System.Drawing.Size(82, 29)
        Me.Button_ClearCmd.TabIndex = 34
        Me.Button_ClearCmd.Text = "Clear"
        Me.Button_ClearCmd.UseVisualStyleBackColor = True
        '
        'Button_GetStep
        '
        Me.Button_GetStep.Location = New System.Drawing.Point(636, 225)
        Me.Button_GetStep.Name = "Button_GetStep"
        Me.Button_GetStep.Size = New System.Drawing.Size(82, 29)
        Me.Button_GetStep.TabIndex = 35
        Me.Button_GetStep.Text = "Get"
        Me.Button_GetStep.UseVisualStyleBackColor = True
        '
        'TabControl_ParamSet
        '
        Me.TabControl_ParamSet.Controls.Add(Me.TabPage_Window)
        Me.TabControl_ParamSet.Controls.Add(Me.TabPage_Variable)
        Me.TabControl_ParamSet.Controls.Add(Me.TabPage_File)
        Me.TabControl_ParamSet.Controls.Add(Me.TabPage_System)
        Me.TabControl_ParamSet.Location = New System.Drawing.Point(12, 75)
        Me.TabControl_ParamSet.Name = "TabControl_ParamSet"
        Me.TabControl_ParamSet.SelectedIndex = 0
        Me.TabControl_ParamSet.Size = New System.Drawing.Size(618, 224)
        Me.TabControl_ParamSet.TabIndex = 36
        '
        'TabPage_Window
        '
        Me.TabPage_Window.Controls.Add(Me.CheckBox_TempWinHandle)
        Me.TabPage_Window.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage_Window.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPage_Window.Controls.Add(Me.Label_TypeString)
        Me.TabPage_Window.Controls.Add(Me.TextBox_TypeString)
        Me.TabPage_Window.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Window.Name = "TabPage_Window"
        Me.TabPage_Window.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Window.Size = New System.Drawing.Size(610, 198)
        Me.TabPage_Window.TabIndex = 0
        Me.TabPage_Window.Text = "Window"
        Me.TabPage_Window.UseVisualStyleBackColor = True
        '
        'CheckBox_TempWinHandle
        '
        Me.CheckBox_TempWinHandle.AutoSize = True
        Me.CheckBox_TempWinHandle.Location = New System.Drawing.Point(7, 174)
        Me.CheckBox_TempWinHandle.Name = "CheckBox_TempWinHandle"
        Me.CheckBox_TempWinHandle.Size = New System.Drawing.Size(233, 16)
        Me.CheckBox_TempWinHandle.TabIndex = 32
        Me.CheckBox_TempWinHandle.Text = "&Temporary Window Handle(Mouse Click)(t)"
        Me.CheckBox_TempWinHandle.UseVisualStyleBackColor = True
        '
        'TabPage_Variable
        '
        Me.TabPage_Variable.Controls.Add(Me.Label_SVARCheck)
        Me.TabPage_Variable.Controls.Add(Me.TextBox_SVARCheck)
        Me.TabPage_Variable.Controls.Add(Me.TableLayoutPanel6)
        Me.TabPage_Variable.Controls.Add(Me.TableLayoutPanel5)
        Me.TabPage_Variable.Controls.Add(Me.TableLayoutPanel4)
        Me.TabPage_Variable.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Variable.Name = "TabPage_Variable"
        Me.TabPage_Variable.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Variable.Size = New System.Drawing.Size(610, 198)
        Me.TabPage_Variable.TabIndex = 1
        Me.TabPage_Variable.Text = "Variable"
        Me.TabPage_Variable.UseVisualStyleBackColor = True
        '
        'Label_SVARCheck
        '
        Me.Label_SVARCheck.AutoSize = True
        Me.Label_SVARCheck.Location = New System.Drawing.Point(353, 106)
        Me.Label_SVARCheck.Name = "Label_SVARCheck"
        Me.Label_SVARCheck.Size = New System.Drawing.Size(68, 12)
        Me.Label_SVARCheck.TabIndex = 5
        Me.Label_SVARCheck.Text = "SVAR Check"
        Me.Label_SVARCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_SVARCheck
        '
        Me.TextBox_SVARCheck.Location = New System.Drawing.Point(319, 128)
        Me.TextBox_SVARCheck.Name = "TextBox_SVARCheck"
        Me.TextBox_SVARCheck.Size = New System.Drawing.Size(128, 22)
        Me.TextBox_SVARCheck.TabIndex = 4
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label_VARHiLim, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label_VARLowLim, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.NumericUpDown_VARHiLim, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.NumericUpDown_VARLowLim, 1, 1)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(395, 27)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(189, 53)
        Me.TableLayoutPanel6.TabIndex = 2
        '
        'Label_VARHiLim
        '
        Me.Label_VARHiLim.AutoSize = True
        Me.Label_VARHiLim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_VARHiLim.Location = New System.Drawing.Point(3, 0)
        Me.Label_VARHiLim.Name = "Label_VARHiLim"
        Me.Label_VARHiLim.Size = New System.Drawing.Size(88, 26)
        Me.Label_VARHiLim.TabIndex = 2
        Me.Label_VARHiLim.Text = "VAR Hi Limit"
        Me.Label_VARHiLim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_VARLowLim
        '
        Me.Label_VARLowLim.AutoSize = True
        Me.Label_VARLowLim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_VARLowLim.Location = New System.Drawing.Point(97, 0)
        Me.Label_VARLowLim.Name = "Label_VARLowLim"
        Me.Label_VARLowLim.Size = New System.Drawing.Size(89, 26)
        Me.Label_VARLowLim.TabIndex = 9
        Me.Label_VARLowLim.Text = "VAR Low Limit"
        Me.Label_VARLowLim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUpDown_VARHiLim
        '
        Me.NumericUpDown_VARHiLim.DecimalPlaces = 3
        Me.NumericUpDown_VARHiLim.Location = New System.Drawing.Point(3, 29)
        Me.NumericUpDown_VARHiLim.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown_VARHiLim.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.NumericUpDown_VARHiLim.Name = "NumericUpDown_VARHiLim"
        Me.NumericUpDown_VARHiLim.Size = New System.Drawing.Size(88, 22)
        Me.NumericUpDown_VARHiLim.TabIndex = 10
        '
        'NumericUpDown_VARLowLim
        '
        Me.NumericUpDown_VARLowLim.DecimalPlaces = 3
        Me.NumericUpDown_VARLowLim.Location = New System.Drawing.Point(97, 29)
        Me.NumericUpDown_VARLowLim.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown_VARLowLim.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.NumericUpDown_VARLowLim.Name = "NumericUpDown_VARLowLim"
        Me.NumericUpDown_VARLowLim.Size = New System.Drawing.Size(89, 22)
        Me.NumericUpDown_VARLowLim.TabIndex = 11
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.68635!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.856089!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.45757!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.ComboBox_SVARIndex, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label_SVARIndex, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label_SVAR_Equal, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label_SVAR_String, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TextBox_SVAR_String, 2, 1)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(27, 99)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(271, 53)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'ComboBox_SVARIndex
        '
        Me.ComboBox_SVARIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_SVARIndex.FormattingEnabled = True
        Me.ComboBox_SVARIndex.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.ComboBox_SVARIndex.Location = New System.Drawing.Point(3, 29)
        Me.ComboBox_SVARIndex.Name = "ComboBox_SVARIndex"
        Me.ComboBox_SVARIndex.Size = New System.Drawing.Size(84, 20)
        Me.ComboBox_SVARIndex.TabIndex = 10
        '
        'Label_SVARIndex
        '
        Me.Label_SVARIndex.AutoSize = True
        Me.Label_SVARIndex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_SVARIndex.Location = New System.Drawing.Point(3, 0)
        Me.Label_SVARIndex.Name = "Label_SVARIndex"
        Me.Label_SVARIndex.Size = New System.Drawing.Size(87, 26)
        Me.Label_SVARIndex.TabIndex = 0
        Me.Label_SVARIndex.Text = "SVAR Index"
        Me.Label_SVARIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_SVAR_Equal
        '
        Me.Label_SVAR_Equal.AutoSize = True
        Me.Label_SVAR_Equal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_SVAR_Equal.Location = New System.Drawing.Point(96, 26)
        Me.Label_SVAR_Equal.Name = "Label_SVAR_Equal"
        Me.Label_SVAR_Equal.Size = New System.Drawing.Size(17, 27)
        Me.Label_SVAR_Equal.TabIndex = 11
        Me.Label_SVAR_Equal.Text = "="
        Me.Label_SVAR_Equal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_SVAR_String
        '
        Me.Label_SVAR_String.AutoSize = True
        Me.Label_SVAR_String.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_SVAR_String.Location = New System.Drawing.Point(119, 0)
        Me.Label_SVAR_String.Name = "Label_SVAR_String"
        Me.Label_SVAR_String.Size = New System.Drawing.Size(149, 26)
        Me.Label_SVAR_String.TabIndex = 12
        Me.Label_SVAR_String.Text = "String"
        Me.Label_SVAR_String.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_SVAR_String
        '
        Me.TextBox_SVAR_String.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_SVAR_String.Location = New System.Drawing.Point(119, 29)
        Me.TextBox_SVAR_String.Name = "TextBox_SVAR_String"
        Me.TextBox_SVAR_String.Size = New System.Drawing.Size(149, 22)
        Me.TextBox_SVAR_String.TabIndex = 13
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.78797!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.303725!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.3553!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.46705!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.79943!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label_VARIndex, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label_VAR_Equal, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label_VARs, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label_Numeric, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.ComboBox_VAR_Operator, 3, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.ComboBox_VARIndex, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.ComboBox_VARsIndex, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.NumericUpDown_VARr, 4, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(27, 27)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(349, 53)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'Label_VARIndex
        '
        Me.Label_VARIndex.AutoSize = True
        Me.Label_VARIndex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_VARIndex.Location = New System.Drawing.Point(3, 0)
        Me.Label_VARIndex.Name = "Label_VARIndex"
        Me.Label_VARIndex.Size = New System.Drawing.Size(84, 26)
        Me.Label_VARIndex.TabIndex = 0
        Me.Label_VARIndex.Text = "VAR Index"
        Me.Label_VARIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_VAR_Equal
        '
        Me.Label_VAR_Equal.AutoSize = True
        Me.Label_VAR_Equal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_VAR_Equal.Location = New System.Drawing.Point(93, 26)
        Me.Label_VAR_Equal.Name = "Label_VAR_Equal"
        Me.Label_VAR_Equal.Size = New System.Drawing.Size(16, 27)
        Me.Label_VAR_Equal.TabIndex = 4
        Me.Label_VAR_Equal.Text = "="
        Me.Label_VAR_Equal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_VARs
        '
        Me.Label_VARs.AutoSize = True
        Me.Label_VARs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_VARs.Location = New System.Drawing.Point(115, 0)
        Me.Label_VARs.Name = "Label_VARs"
        Me.Label_VARs.Size = New System.Drawing.Size(79, 26)
        Me.Label_VARs.TabIndex = 5
        Me.Label_VARs.Text = "VAR Index"
        Me.Label_VARs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_Numeric
        '
        Me.Label_Numeric.AutoSize = True
        Me.Label_Numeric.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Numeric.Location = New System.Drawing.Point(247, 0)
        Me.Label_Numeric.Name = "Label_Numeric"
        Me.Label_Numeric.Size = New System.Drawing.Size(99, 26)
        Me.Label_Numeric.TabIndex = 7
        Me.Label_Numeric.Text = "Numeric"
        Me.Label_Numeric.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox_VAR_Operator
        '
        Me.ComboBox_VAR_Operator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_VAR_Operator.FormattingEnabled = True
        Me.ComboBox_VAR_Operator.Items.AddRange(New Object() {"+", "-", "*", "/", "%", "\"})
        Me.ComboBox_VAR_Operator.Location = New System.Drawing.Point(200, 29)
        Me.ComboBox_VAR_Operator.Name = "ComboBox_VAR_Operator"
        Me.ComboBox_VAR_Operator.Size = New System.Drawing.Size(41, 20)
        Me.ComboBox_VAR_Operator.TabIndex = 8
        '
        'ComboBox_VARIndex
        '
        Me.ComboBox_VARIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_VARIndex.FormattingEnabled = True
        Me.ComboBox_VARIndex.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.ComboBox_VARIndex.Location = New System.Drawing.Point(3, 29)
        Me.ComboBox_VARIndex.Name = "ComboBox_VARIndex"
        Me.ComboBox_VARIndex.Size = New System.Drawing.Size(84, 20)
        Me.ComboBox_VARIndex.TabIndex = 9
        '
        'ComboBox_VARsIndex
        '
        Me.ComboBox_VARsIndex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox_VARsIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_VARsIndex.FormattingEnabled = True
        Me.ComboBox_VARsIndex.Items.AddRange(New Object() {"NONE", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.ComboBox_VARsIndex.Location = New System.Drawing.Point(115, 29)
        Me.ComboBox_VARsIndex.Name = "ComboBox_VARsIndex"
        Me.ComboBox_VARsIndex.Size = New System.Drawing.Size(79, 20)
        Me.ComboBox_VARsIndex.TabIndex = 10
        '
        'NumericUpDown_VARr
        '
        Me.NumericUpDown_VARr.DecimalPlaces = 3
        Me.NumericUpDown_VARr.Location = New System.Drawing.Point(247, 29)
        Me.NumericUpDown_VARr.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown_VARr.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.NumericUpDown_VARr.Name = "NumericUpDown_VARr"
        Me.NumericUpDown_VARr.Size = New System.Drawing.Size(99, 22)
        Me.NumericUpDown_VARr.TabIndex = 11
        '
        'TabPage_File
        '
        Me.TabPage_File.Controls.Add(Me.ComboBox_FileToSVAR)
        Me.TabPage_File.Controls.Add(Me.Label_ToSVAR)
        Me.TabPage_File.Controls.Add(Me.TableLayoutPanel7)
        Me.TabPage_File.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_File.Name = "TabPage_File"
        Me.TabPage_File.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_File.Size = New System.Drawing.Size(610, 198)
        Me.TabPage_File.TabIndex = 2
        Me.TabPage_File.Text = "File"
        Me.TabPage_File.UseVisualStyleBackColor = True
        '
        'ComboBox_FileToSVAR
        '
        Me.ComboBox_FileToSVAR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_FileToSVAR.FormattingEnabled = True
        Me.ComboBox_FileToSVAR.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.ComboBox_FileToSVAR.Location = New System.Drawing.Point(497, 21)
        Me.ComboBox_FileToSVAR.Name = "ComboBox_FileToSVAR"
        Me.ComboBox_FileToSVAR.Size = New System.Drawing.Size(84, 20)
        Me.ComboBox_FileToSVAR.TabIndex = 11
        '
        'Label_ToSVAR
        '
        Me.Label_ToSVAR.AutoSize = True
        Me.Label_ToSVAR.Location = New System.Drawing.Point(443, 25)
        Me.Label_ToSVAR.Name = "Label_ToSVAR"
        Me.Label_ToSVAR.Size = New System.Drawing.Size(51, 12)
        Me.Label_ToSVAR.TabIndex = 3
        Me.Label_ToSVAR.Text = "To SVAR"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.61905!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.38095!))
        Me.TableLayoutPanel7.Controls.Add(Me.Label_SourcePath, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label_DestPath, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.TextBox_SourcePath, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label_String, 0, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.TextBox_FileString, 1, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.TextBox_DestPath, 1, 1)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(17, 18)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 3
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(420, 86)
        Me.TableLayoutPanel7.TabIndex = 2
        '
        'Label_SourcePath
        '
        Me.Label_SourcePath.AutoSize = True
        Me.Label_SourcePath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_SourcePath.Location = New System.Drawing.Point(3, 0)
        Me.Label_SourcePath.Name = "Label_SourcePath"
        Me.Label_SourcePath.Size = New System.Drawing.Size(89, 28)
        Me.Label_SourcePath.TabIndex = 0
        Me.Label_SourcePath.Text = "Source Path"
        Me.Label_SourcePath.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_DestPath
        '
        Me.Label_DestPath.AutoSize = True
        Me.Label_DestPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_DestPath.Location = New System.Drawing.Point(3, 28)
        Me.Label_DestPath.Name = "Label_DestPath"
        Me.Label_DestPath.Size = New System.Drawing.Size(89, 28)
        Me.Label_DestPath.TabIndex = 1
        Me.Label_DestPath.Text = "Destination Path"
        Me.Label_DestPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox_SourcePath
        '
        Me.TextBox_SourcePath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_SourcePath.Location = New System.Drawing.Point(98, 3)
        Me.TextBox_SourcePath.Name = "TextBox_SourcePath"
        Me.TextBox_SourcePath.Size = New System.Drawing.Size(319, 22)
        Me.TextBox_SourcePath.TabIndex = 2
        '
        'Label_String
        '
        Me.Label_String.AutoSize = True
        Me.Label_String.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_String.Location = New System.Drawing.Point(3, 56)
        Me.Label_String.Name = "Label_String"
        Me.Label_String.Size = New System.Drawing.Size(89, 30)
        Me.Label_String.TabIndex = 5
        Me.Label_String.Text = "String"
        Me.Label_String.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox_FileString
        '
        Me.TextBox_FileString.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_FileString.Location = New System.Drawing.Point(98, 59)
        Me.TextBox_FileString.Name = "TextBox_FileString"
        Me.TextBox_FileString.Size = New System.Drawing.Size(319, 22)
        Me.TextBox_FileString.TabIndex = 4
        '
        'TextBox_DestPath
        '
        Me.TextBox_DestPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_DestPath.Location = New System.Drawing.Point(98, 31)
        Me.TextBox_DestPath.Name = "TextBox_DestPath"
        Me.TextBox_DestPath.Size = New System.Drawing.Size(319, 22)
        Me.TextBox_DestPath.TabIndex = 3
        '
        'TabPage_System
        '
        Me.TabPage_System.Controls.Add(Me.TableLayoutPanel8)
        Me.TabPage_System.Controls.Add(Me.Label_ForceAboutTimer_Minute)
        Me.TabPage_System.Controls.Add(Me.Label_ForceAboutTimer)
        Me.TabPage_System.Controls.Add(Me.TextBox_ForceAboutTimer)
        Me.TabPage_System.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_System.Name = "TabPage_System"
        Me.TabPage_System.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_System.Size = New System.Drawing.Size(610, 198)
        Me.TabPage_System.TabIndex = 3
        Me.TabPage_System.Text = "System"
        Me.TabPage_System.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 3
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.27586!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.68966!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.37931!))
        Me.TableLayoutPanel8.Controls.Add(Me.Label_WatchDogIndex, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.Label_WatchDogFeedTime, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.Label_WatchDogFeedTime_Minute, 2, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.ComboBox_WatchDogIndex, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.TextBox_WatchDogFeedTime, 1, 1)
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(6, 16)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(290, 57)
        Me.TableLayoutPanel8.TabIndex = 8
        '
        'Label_WatchDogIndex
        '
        Me.Label_WatchDogIndex.AutoSize = True
        Me.Label_WatchDogIndex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_WatchDogIndex.Location = New System.Drawing.Point(3, 0)
        Me.Label_WatchDogIndex.Name = "Label_WatchDogIndex"
        Me.Label_WatchDogIndex.Size = New System.Drawing.Size(104, 28)
        Me.Label_WatchDogIndex.TabIndex = 0
        Me.Label_WatchDogIndex.Text = "WatchDogIndex"
        Me.Label_WatchDogIndex.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_WatchDogFeedTime
        '
        Me.Label_WatchDogFeedTime.AutoSize = True
        Me.Label_WatchDogFeedTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_WatchDogFeedTime.Location = New System.Drawing.Point(3, 28)
        Me.Label_WatchDogFeedTime.Name = "Label_WatchDogFeedTime"
        Me.Label_WatchDogFeedTime.Size = New System.Drawing.Size(104, 29)
        Me.Label_WatchDogFeedTime.TabIndex = 2
        Me.Label_WatchDogFeedTime.Text = "WatchDogFeedTime"
        Me.Label_WatchDogFeedTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_WatchDogFeedTime_Minute
        '
        Me.Label_WatchDogFeedTime_Minute.AutoSize = True
        Me.Label_WatchDogFeedTime_Minute.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_WatchDogFeedTime_Minute.Location = New System.Drawing.Point(230, 28)
        Me.Label_WatchDogFeedTime_Minute.Name = "Label_WatchDogFeedTime_Minute"
        Me.Label_WatchDogFeedTime_Minute.Size = New System.Drawing.Size(57, 29)
        Me.Label_WatchDogFeedTime_Minute.TabIndex = 4
        Me.Label_WatchDogFeedTime_Minute.Text = "(Minutes)"
        Me.Label_WatchDogFeedTime_Minute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox_WatchDogIndex
        '
        Me.ComboBox_WatchDogIndex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox_WatchDogIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_WatchDogIndex.FormattingEnabled = True
        Me.ComboBox_WatchDogIndex.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "ALL"})
        Me.ComboBox_WatchDogIndex.Location = New System.Drawing.Point(113, 3)
        Me.ComboBox_WatchDogIndex.Name = "ComboBox_WatchDogIndex"
        Me.ComboBox_WatchDogIndex.Size = New System.Drawing.Size(111, 20)
        Me.ComboBox_WatchDogIndex.TabIndex = 1
        '
        'TextBox_WatchDogFeedTime
        '
        Me.TextBox_WatchDogFeedTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_WatchDogFeedTime.Location = New System.Drawing.Point(113, 31)
        Me.TextBox_WatchDogFeedTime.Name = "TextBox_WatchDogFeedTime"
        Me.TextBox_WatchDogFeedTime.Size = New System.Drawing.Size(111, 22)
        Me.TextBox_WatchDogFeedTime.TabIndex = 3
        '
        'Label_ForceAboutTimer_Minute
        '
        Me.Label_ForceAboutTimer_Minute.AutoSize = True
        Me.Label_ForceAboutTimer_Minute.Location = New System.Drawing.Point(236, 105)
        Me.Label_ForceAboutTimer_Minute.Name = "Label_ForceAboutTimer_Minute"
        Me.Label_ForceAboutTimer_Minute.Size = New System.Drawing.Size(50, 12)
        Me.Label_ForceAboutTimer_Minute.TabIndex = 7
        Me.Label_ForceAboutTimer_Minute.Text = "(Minutes)"
        '
        'Label_ForceAboutTimer
        '
        Me.Label_ForceAboutTimer.AutoSize = True
        Me.Label_ForceAboutTimer.Location = New System.Drawing.Point(20, 105)
        Me.Label_ForceAboutTimer.Name = "Label_ForceAboutTimer"
        Me.Label_ForceAboutTimer.Size = New System.Drawing.Size(88, 12)
        Me.Label_ForceAboutTimer.TabIndex = 5
        Me.Label_ForceAboutTimer.Text = "ForceAboutTimer"
        '
        'TextBox_ForceAboutTimer
        '
        Me.TextBox_ForceAboutTimer.Location = New System.Drawing.Point(119, 102)
        Me.TextBox_ForceAboutTimer.Name = "TextBox_ForceAboutTimer"
        Me.TextBox_ForceAboutTimer.Size = New System.Drawing.Size(111, 22)
        Me.TextBox_ForceAboutTimer.TabIndex = 6
        '
        'Button_ReplaceStep
        '
        Me.Button_ReplaceStep.Location = New System.Drawing.Point(636, 100)
        Me.Button_ReplaceStep.Name = "Button_ReplaceStep"
        Me.Button_ReplaceStep.Size = New System.Drawing.Size(82, 29)
        Me.Button_ReplaceStep.TabIndex = 37
        Me.Button_ReplaceStep.Text = "Replace"
        Me.Button_ReplaceStep.UseVisualStyleBackColor = True
        '
        'StatusStrip_DetectForm
        '
        Me.StatusStrip_DetectForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel_DetectForm})
        Me.StatusStrip_DetectForm.Location = New System.Drawing.Point(0, 699)
        Me.StatusStrip_DetectForm.Name = "StatusStrip_DetectForm"
        Me.StatusStrip_DetectForm.Size = New System.Drawing.Size(741, 22)
        Me.StatusStrip_DetectForm.TabIndex = 38
        Me.StatusStrip_DetectForm.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel_DetectForm
        '
        Me.ToolStripStatusLabel_DetectForm.Name = "ToolStripStatusLabel_DetectForm"
        Me.ToolStripStatusLabel_DetectForm.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel_DetectForm.Text = "Status"
        '
        'DetectFormEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 721)
        Me.Controls.Add(Me.StatusStrip_DetectForm)
        Me.Controls.Add(Me.Button_ReplaceStep)
        Me.Controls.Add(Me.Button_ClearCmd)
        Me.Controls.Add(Me.Button_GetStep)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TabControl_ParamSet)
        Me.Controls.Add(Me.GroupBox_Detect)
        Me.Controls.Add(Me.Button_InsertStep)
        Me.Controls.Add(Me.Button_DeleteStep)
        Me.Name = "DetectFormEvent"
        Me.Text = "DetectForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox_Detect.ResumeLayout(False)
        Me.GroupBox_Detect.PerformLayout()
        Me.GroupBox_ImageDetect.ResumeLayout(False)
        Me.GroupBox_ImageDetect.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TabControl_ParamSet.ResumeLayout(False)
        Me.TabPage_Window.ResumeLayout(False)
        Me.TabPage_Window.PerformLayout()
        Me.TabPage_Variable.ResumeLayout(False)
        Me.TabPage_Variable.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        CType(Me.NumericUpDown_VARHiLim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_VARLowLim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.NumericUpDown_VARr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_File.ResumeLayout(False)
        Me.TabPage_File.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TabPage_System.ResumeLayout(False)
        Me.TabPage_System.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.StatusStrip_DetectForm.ResumeLayout(False)
        Me.StatusStrip_DetectForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer_Detect As System.Windows.Forms.Timer
    Friend WithEvents TextBox_Detect_WndTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label_AbsoluteCoordinate As System.Windows.Forms.Label
    Friend WithEvents TextBox_Axis_X As System.Windows.Forms.TextBox
    Friend WithEvents Label_RelativeCoordinate As System.Windows.Forms.Label
    Friend WithEvents Label_Axis_X As System.Windows.Forms.Label
    Friend WithEvents TextBox_Relative_Y As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Axis_Y As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Relative_X As System.Windows.Forms.TextBox
    Friend WithEvents Label_WinTitle As System.Windows.Forms.Label
    Friend WithEvents Label_WinClass As System.Windows.Forms.Label
    Friend WithEvents TextBox_Detect_WndClass As System.Windows.Forms.TextBox
    Friend WithEvents Label_Axis_Y As System.Windows.Forms.Label
    Friend WithEvents Button_Detect As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label_CommandType As System.Windows.Forms.Label
    Friend WithEvents Label_StepName As System.Windows.Forms.Label
    Friend WithEvents Label_StepNum As System.Windows.Forms.Label
    Friend WithEvents ComboBox_CommandType As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox_StepNum As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_StepName As System.Windows.Forms.TextBox
    Friend WithEvents Label_Delay As System.Windows.Forms.Label
    Friend WithEvents Label_NextStep As System.Windows.Forms.Label
    Friend WithEvents Label_LastStep As System.Windows.Forms.Label
    Friend WithEvents GroupBox_Detect As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_Delay As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_NextStep As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_LastStep As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label_Position As System.Windows.Forms.Label
    Friend WithEvents Label_ImgSize As System.Windows.Forms.Label
    Friend WithEvents Label_PixelLowLim As System.Windows.Forms.Label
    Friend WithEvents Label_PixelHiLim As System.Windows.Forms.Label
    Friend WithEvents TextBox_Position As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_ImgSize As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_PixelLowLim As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_PixelHiLim As System.Windows.Forms.TextBox
    Friend WithEvents Label_Detect_Color As System.Windows.Forms.Label
    Friend WithEvents TextBox_Detect_Color As System.Windows.Forms.TextBox
    Friend WithEvents Button_Duplicate As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label_WndClass As System.Windows.Forms.Label
    Friend WithEvents Label_WndTitle As System.Windows.Forms.Label
    Friend WithEvents TextBox_WndTitle As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_WndClass As System.Windows.Forms.TextBox
    Friend WithEvents Button_DeleteStep As System.Windows.Forms.Button
    Friend WithEvents Button_InsertStep As System.Windows.Forms.Button
    Friend WithEvents Button_ClearCmd As System.Windows.Forms.Button
    Friend WithEvents CheckBox_Detect_LockWnd As System.Windows.Forms.CheckBox
    Friend WithEvents Label_TypeString As System.Windows.Forms.Label
    Friend WithEvents TextBox_TypeString As System.Windows.Forms.TextBox
    Friend WithEvents Button_GetStep As System.Windows.Forms.Button
    Friend WithEvents TabControl_ParamSet As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Window As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Variable As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label_SVARIndex As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label_VARIndex As System.Windows.Forms.Label
    Friend WithEvents Label_SVARCheck As System.Windows.Forms.Label
    Friend WithEvents TextBox_SVARCheck As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label_VARHiLim As System.Windows.Forms.Label
    Friend WithEvents Label_VARLowLim As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown_VARHiLim As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown_VARLowLim As System.Windows.Forms.NumericUpDown
    Friend WithEvents ComboBox_SVARIndex As System.Windows.Forms.ComboBox
    Friend WithEvents Label_SVAR_Equal As System.Windows.Forms.Label
    Friend WithEvents Label_SVAR_String As System.Windows.Forms.Label
    Friend WithEvents TextBox_SVAR_String As System.Windows.Forms.TextBox
    Friend WithEvents Label_VAR_Equal As System.Windows.Forms.Label
    Friend WithEvents Label_VARs As System.Windows.Forms.Label
    Friend WithEvents Label_Numeric As System.Windows.Forms.Label
    Friend WithEvents ComboBox_VAR_Operator As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_VARIndex As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_VARsIndex As System.Windows.Forms.ComboBox
    Friend WithEvents NumericUpDown_VARr As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button_GetColorFromPosition As System.Windows.Forms.Button
    Friend WithEvents Button_ReplaceStep As System.Windows.Forms.Button
    Friend WithEvents TextBox_Color_X As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Color_Y As System.Windows.Forms.TextBox
    Friend WithEvents Label_ColorCoordinate As System.Windows.Forms.Label
    Friend WithEvents TabPage_File As System.Windows.Forms.TabPage
    Friend WithEvents ComboBox_FileToSVAR As System.Windows.Forms.ComboBox
    Friend WithEvents Label_ToSVAR As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label_SourcePath As System.Windows.Forms.Label
    Friend WithEvents Label_DestPath As System.Windows.Forms.Label
    Friend WithEvents TextBox_SourcePath As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_DestPath As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_FileString As System.Windows.Forms.TextBox
    Friend WithEvents Label_String As System.Windows.Forms.Label
    Friend WithEvents CheckBox_TempWinHandle As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage_System As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label_WatchDogIndex As System.Windows.Forms.Label
    Friend WithEvents Label_WatchDogFeedTime As System.Windows.Forms.Label
    Friend WithEvents Label_WatchDogFeedTime_Minute As System.Windows.Forms.Label
    Friend WithEvents ComboBox_WatchDogIndex As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox_WatchDogFeedTime As System.Windows.Forms.TextBox
    Friend WithEvents Label_ForceAboutTimer_Minute As System.Windows.Forms.Label
    Friend WithEvents Label_ForceAboutTimer As System.Windows.Forms.Label
    Friend WithEvents TextBox_ForceAboutTimer As System.Windows.Forms.TextBox
    Friend WithEvents Label_Duplicate_Clear_Data As System.Windows.Forms.Label
    Friend WithEvents TextBox_SaveImageName As System.Windows.Forms.TextBox
    Friend WithEvents Label_SaveImage As System.Windows.Forms.Label
    Friend WithEvents TextBox_BottomRight_Y As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_BottomRight_X As System.Windows.Forms.TextBox
    Friend WithEvents Label_BottomRight As System.Windows.Forms.Label
    Friend WithEvents TextBox_TopLeft_Y As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_TopLeft_X As System.Windows.Forms.TextBox
    Friend WithEvents Label_SaveImage_TopLeft As System.Windows.Forms.Label
    Friend WithEvents CheckBox_LockName As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox_ImageDetect As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip_DetectForm As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel_DetectForm As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label_ImageName As System.Windows.Forms.Label
    Friend WithEvents Label_Detect_MouseScrollCount As System.Windows.Forms.Label
    Friend WithEvents TextBox_Detect_MouseScrollCount As System.Windows.Forms.TextBox
    Friend WithEvents Label_Position_Up As System.Windows.Forms.Label
    Friend WithEvents TextBox_Position_Up As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_MouseScrollCount As System.Windows.Forms.TextBox
    Friend WithEvents Label_MouseScrollCount As System.Windows.Forms.Label
    Friend WithEvents Label_Color_Axis_Y As System.Windows.Forms.Label
    Friend WithEvents Label_Color_Axis_X As System.Windows.Forms.Label
    Friend WithEvents TextBox_Relative_X_BottomRight As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Relative_Y_BottomRight As System.Windows.Forms.TextBox
    Friend WithEvents Label_RelativeCoordinate_2 As System.Windows.Forms.Label
End Class
