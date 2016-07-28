Public Class StepData_WatchDogFeed
    Inherits StepDataItem
    Implements StepDataParam

    Public Function GetParam1() As String Implements StepDataParam.GetParam1
        Return DetectFormEvent.ComboBox_WatchDogIndex.SelectedIndex
    End Function

    Public Function GetParam2() As String Implements StepDataParam.GetParam2
        Return ""
    End Function

    Public Function GetParam3() As String Implements StepDataParam.GetParam3
        Return ""
    End Function

    Public Function GetParam4() As String Implements StepDataParam.GetParam4
        Return ""
    End Function

    Public Function GetParam5() As String Implements StepDataParam.GetParam5
        Return ""
    End Function

    Public Overrides Function GetWatchDogIndex(iRowIndex As Integer) As Integer

        Return Convert.ToInt32(MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM1).Value)

    End Function

End Class
