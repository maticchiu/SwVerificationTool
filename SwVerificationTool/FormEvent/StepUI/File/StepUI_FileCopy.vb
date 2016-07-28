Public Class StepUI_FileCopy
    Inherits StepUIBase

    Public Overrides Sub StepUISetting()

        MyBase.StepUISetting()
        DetectFormEvent.Label_SourcePath.Visible = True
        DetectFormEvent.TextBox_SourcePath.Visible = True
        DetectFormEvent.Label_DestPath.Visible = True
        DetectFormEvent.TextBox_DestPath.Visible = True
        'DetectFormEvent.Label_String.Visible = True
        'DetectFormEvent.TextBox_FileString.Visible = True
        'DetectFormEvent.Label_ToSVAR.Visible = True
        'DetectFormEvent.ComboBox_FileToSVAR.Visible = True

    End Sub
End Class
