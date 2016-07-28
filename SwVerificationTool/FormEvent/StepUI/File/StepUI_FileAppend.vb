Public Class StepUI_FileAppend
    Inherits StepUIBase

    Public Overrides Sub StepUISetting()

        MyBase.StepUISetting()
        DetectFormEvent.Label_SourcePath.Visible = True
        DetectFormEvent.TextBox_SourcePath.Visible = True
        DetectFormEvent.Label_String.Visible = True
        DetectFormEvent.TextBox_FileString.Visible = True

    End Sub


End Class
