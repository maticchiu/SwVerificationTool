Public Class StepShowFormEvent

    Private Sub StepShowFormEvent_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TopMost = True ' Always top
    End Sub

    Private Sub TrackBar_Opacity_Scroll(sender As Object, e As EventArgs) Handles TrackBar_Opacity.Scroll
        NumericUpDown_Opacity.Value = TrackBar_Opacity.Value
        Me.Opacity = 0.3 + (TrackBar_Opacity.Value / 100.0) * 0.7
    End Sub

    Private Sub NumericUpDown_Opacity_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Opacity.ValueChanged
        TrackBar_Opacity.Value = NumericUpDown_Opacity.Value
        Me.Opacity = 0.3 + (NumericUpDown_Opacity.Value / 100.0) * 0.7
    End Sub

End Class