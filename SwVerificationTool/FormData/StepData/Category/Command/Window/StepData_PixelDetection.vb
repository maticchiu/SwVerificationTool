Public Class StepData_PixelDetection
    Inherits StepDataItem
    Implements StepDataParam

    Public Function GetParam1() As String Implements StepDataParam.GetParam1
        Return DetectFormEvent.TextBox_Position.Text
    End Function

    Public Function GetParam2() As String Implements StepDataParam.GetParam2
        Return DetectFormEvent.TextBox_ImgSize.Text
    End Function

    Public Function GetParam3() As String Implements StepDataParam.GetParam3
        Return DetectFormEvent.TextBox_PixelHiLim.Text & ";" & DetectFormEvent.TextBox_PixelLowLim.Text
        'Return DetectFormEvent.TextBox_PixelHiLim.Text
    End Function

    Public Function GetParam4() As String Implements StepDataParam.GetParam4
        Return ""
        'Return DetectFormEvent.TextBox_PixelLowLim.Text
    End Function

    Public Function GetParam5() As String Implements StepDataParam.GetParam5
        Return ""
    End Function

    Public Overrides Function GetPosition(ByVal iRowIndex As Integer) As String

        Return MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM1).Value

    End Function

    Public Overrides Function GetImageSize(ByVal iRowIndex As Integer) As String

        Return MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM2).Value

    End Function

    Public Overrides Function GetHiLimitOfPixel(ByVal iRowIndex As Integer) As String
        Dim strLimit() As String = MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM3).Value.ToString.Split(";")
        If strLimit.Length = 1 Then
            MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM3).Value = MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM3).Value & ";" & MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM4).Value
            MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM4).Value = ""
        End If
        Return strLimit(0)
        'Return MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM3).Value

    End Function

    Public Overrides Function GetLowLimitOfPixel(ByVal iRowIndex As Integer) As String
        Dim strLimit() As String = MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM3).Value.ToString.Split(";")
        If strLimit.Length = 2 Then
            Return strLimit(1)
        End If
        Return MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM4).Value
        'Return MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM4).Value

    End Function

End Class
