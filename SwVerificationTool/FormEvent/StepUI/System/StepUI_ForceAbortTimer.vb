Public Class StepUI_ForceAbortTimer

    Inherits StepUIBase

    Public Overrides Sub StepUISetting()

        MyBase.StepUISetting()

        'DetectFormEvent.Label_WatchDogIndex.Visible = True
        'DetectFormEvent.ComboBox_WatchDogIndex.Visible = True
        'DetectFormEvent.Label_WatchDogFeedTime.Visible = True
        'DetectFormEvent.TextBox_WatchDogFeedTime.Visible = True
        'DetectFormEvent.Label_WatchDogFeedTime_Minute.Visible = True
        DetectFormEvent.Label_ForceAboutTimer.Visible = True
        DetectFormEvent.TextBox_ForceAboutTimer.Visible = True
        DetectFormEvent.Label_ForceAboutTimer_Minute.Visible = True
    End Sub

End Class
