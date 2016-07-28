<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StepShowFormEvent
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
        Me.TrackBar_Opacity = New System.Windows.Forms.TrackBar()
        Me.NumericUpDown_Opacity = New System.Windows.Forms.NumericUpDown()
        Me.Label_CurrentStepStatus = New System.Windows.Forms.Label()
        CType(Me.TrackBar_Opacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Opacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrackBar_Opacity
        '
        Me.TrackBar_Opacity.Location = New System.Drawing.Point(12, 12)
        Me.TrackBar_Opacity.Maximum = 100
        Me.TrackBar_Opacity.Name = "TrackBar_Opacity"
        Me.TrackBar_Opacity.Size = New System.Drawing.Size(123, 45)
        Me.TrackBar_Opacity.TabIndex = 0
        Me.TrackBar_Opacity.Value = 100
        '
        'NumericUpDown_Opacity
        '
        Me.NumericUpDown_Opacity.Location = New System.Drawing.Point(141, 12)
        Me.NumericUpDown_Opacity.Name = "NumericUpDown_Opacity"
        Me.NumericUpDown_Opacity.Size = New System.Drawing.Size(59, 22)
        Me.NumericUpDown_Opacity.TabIndex = 1
        Me.NumericUpDown_Opacity.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label_CurrentStepStatus
        '
        Me.Label_CurrentStepStatus.AutoSize = True
        Me.Label_CurrentStepStatus.Font = New System.Drawing.Font("PMingLiU", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label_CurrentStepStatus.Location = New System.Drawing.Point(12, 60)
        Me.Label_CurrentStepStatus.Name = "Label_CurrentStepStatus"
        Me.Label_CurrentStepStatus.Size = New System.Drawing.Size(174, 24)
        Me.Label_CurrentStepStatus.TabIndex = 2
        Me.Label_CurrentStepStatus.Text = "CurrentStepStatus"
        '
        'StepShowFormEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 114)
        Me.Controls.Add(Me.Label_CurrentStepStatus)
        Me.Controls.Add(Me.NumericUpDown_Opacity)
        Me.Controls.Add(Me.TrackBar_Opacity)
        Me.Name = "StepShowFormEvent"
        Me.Text = "StepShowFormEvent"
        CType(Me.TrackBar_Opacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Opacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TrackBar_Opacity As System.Windows.Forms.TrackBar
    Friend WithEvents NumericUpDown_Opacity As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label_CurrentStepStatus As System.Windows.Forms.Label
End Class
