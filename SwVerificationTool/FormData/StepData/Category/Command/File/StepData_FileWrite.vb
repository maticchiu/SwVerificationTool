Public Class StepData_FileWrite
    Inherits StepDataItem
    Implements StepDataParam

    Public Function GetParam1() As String Implements StepDataParam.GetParam1
        Return DetectFormEvent.TextBox_SourcePath.Text
    End Function

    Public Function GetParam2() As String Implements StepDataParam.GetParam2
        Return DetectFormEvent.TextBox_FileString.Text
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

    Public Overrides Function GetFileSourcePath(ByVal iRowIndex As Integer) As String

        Return MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM1).Value

    End Function

    Public Overrides Function GetFileString(ByVal iRowIndex As Integer) As String

        Return MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM2).Value

    End Function

End Class
