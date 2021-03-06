﻿Public Class StepData_MouseScroll
    Inherits StepDataItem
    Implements StepDataParam

    Public Function GetParam1() As String Implements StepDataParam.GetParam1
        Return DetectFormEvent.TextBox_Position.Text
    End Function

    Public Function GetParam2() As String Implements StepDataParam.GetParam2
        Return DetectFormEvent.TextBox_MouseScrollCount.Text
    End Function

    Public Function GetParam3() As String Implements StepDataParam.GetParam3
        Return DetectFormEvent.TextBox_WndTitle.Text
    End Function

    Public Function GetParam4() As String Implements StepDataParam.GetParam4
        Return DetectFormEvent.TextBox_WndClass.Text
    End Function

    Public Function GetParam5() As String Implements StepDataParam.GetParam5
        Return ""
    End Function

    Public Overrides Function GetPosition(iRowIndex As Integer) As String
        Return MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM1).Value
    End Function

    Public Overrides Function GetScrollCount(iRowIndex As Integer) As Integer
        Return Convert.ToInt32(MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM2).Value)
    End Function

    Public Overrides Function GetWindowTitle(iRowIndex As Integer) As String
        Return MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM3).Value
    End Function

    Public Overrides Function GetWindowClass(iRowIndex As Integer) As String
        Return MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM4).Value
    End Function

End Class
