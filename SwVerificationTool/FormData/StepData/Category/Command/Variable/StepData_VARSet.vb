Public Class StepData_VARSet
    Inherits StepDataItem
    Implements StepDataParam

    Public Function GetParam1() As String Implements StepDataParam.GetParam1
        Return DetectFormEvent.ComboBox_VARIndex.Text
    End Function

    Public Function GetParam2() As String Implements StepDataParam.GetParam2
        Return DetectFormEvent.ComboBox_VARsIndex.Text
    End Function

    Public Function GetParam3() As String Implements StepDataParam.GetParam3
        Return DetectFormEvent.ComboBox_VAR_Operator.Text
    End Function

    Public Function GetParam4() As String Implements StepDataParam.GetParam4
        Return DetectFormEvent.NumericUpDown_VARr.Value
    End Function

    Public Function GetParam5() As String Implements StepDataParam.GetParam5
        Return ""
    End Function


    Public Overrides Function GetVARIndex(ByVal iRowIndex As Integer) As Integer

        Return Convert.ToInt32(MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM1).Value)

    End Function

    Public Overrides Function GetVARsIndex(ByVal iRowIndex As Integer) As Integer

        Dim iVARIndex As Integer = 0

        If MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM2).Value <> "NONE" Then
            iVARIndex = Convert.ToInt32(MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM2).Value)
        Else
            iVARIndex = -1
        End If

        Return iVARIndex

    End Function

    Public Overrides Function GetVAROperator(ByVal iRowIndex As Integer) As String

        Return MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM3).Value

    End Function

    Public Overrides Function GetVARNumeric(ByVal iRowIndex As Integer) As Integer

        Return Convert.ToInt32(MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM4).Value)

    End Function
End Class
