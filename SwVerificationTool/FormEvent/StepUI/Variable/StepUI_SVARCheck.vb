Public Class StepUI_SVARCheck

    Inherits StepUIBase

    Public Overrides Sub StepUISetting()

        MyBase.StepUISetting()

        'DetectFormEvent.Label_VARIndex.Visible = True
        'DetectFormEvent.ComboBox_VARIndex.Visible = True
        'DetectFormEvent.Label_VAR_Equal.Visible = True
        'DetectFormEvent.Label_VARs.Visible = True
        'DetectFormEvent.ComboBox_VARsIndex.Visible = True
        'DetectFormEvent.ComboBox_VAR_Operator.Visible = True
        'DetectFormEvent.Label_Numeric.Visible = True
        'DetectFormEvent.NumericUpDown_VARr.Visible = True
        'DetectFormEvent.Label_VARHiLim.Visible = True
        'DetectFormEvent.NumericUpDown_VARHiLim.Visible = True
        'DetectFormEvent.Label_VARLowLim.Visible = True
        'DetectFormEvent.NumericUpDown_VARLowLim.Visible = True
        DetectFormEvent.Label_SVARIndex.Visible = True
        DetectFormEvent.ComboBox_SVARIndex.Visible = True
        'DetectFormEvent.Label_SVAR_Equal.Visible = True
        'DetectFormEvent.Label_SVAR_String.Visible = True
        'DetectFormEvent.TextBox_SVAR_String.Visible = True
        DetectFormEvent.Label_SVARCheck.Visible = True
        DetectFormEvent.TextBox_SVARCheck.Visible = True
    End Sub

End Class
