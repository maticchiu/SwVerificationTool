Public Class StepData_VARCheck
    Inherits StepDataItem
    Implements StepDataParam

    Public Function GetParam1() As String Implements StepDataParam.GetParam1
        Return DetectFormEvent.ComboBox_VARIndex.Text
    End Function

    Public Function GetParam2() As String Implements StepDataParam.GetParam2
        Return DetectFormEvent.NumericUpDown_VARHiLim.Value
    End Function

    Public Function GetParam3() As String Implements StepDataParam.GetParam3
        Return DetectFormEvent.NumericUpDown_VARLowLim.Value
    End Function

    Public Function GetParam4() As String Implements StepDataParam.GetParam4
        Return ""
    End Function

    Public Function GetParam5() As String Implements StepDataParam.GetParam5
        Return ""
    End Function

    Public Overrides Function GetVARIndex(ByVal iRowIndex As Integer) As Integer

        Return Convert.ToInt32(MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM1).Value)

    End Function

    Public Overrides Function GetVARHiLim(ByVal iRowIndex As Integer) As Double

        Return Convert.ToDouble(MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM2).Value)

    End Function

    Public Overrides Function GetVARLowLim(ByVal iRowIndex As Integer) As Double

        Return Convert.ToDouble(MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM3).Value)

    End Function
End Class
