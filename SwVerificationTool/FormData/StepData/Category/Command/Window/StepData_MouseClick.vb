Public Class StepData_MouseClick
    Inherits StepDataItem
    Implements StepDataParam

    Public Function GetParam1() As String Implements StepDataParam.GetParam1
        Return DetectFormEvent.TextBox_Position.Text
    End Function

    Public Function GetParam2() As String Implements StepDataParam.GetParam2
        Dim strWndTitle As String = ""

        If DetectFormEvent.CheckBox_TempWinHandle.Checked Then
            strWndTitle = DetectFormEvent.TextBox_WndTitle.Text
        End If

        Return strWndTitle
    End Function

    Public Function GetParam3() As String Implements StepDataParam.GetParam3
        Dim strWndClass As String = ""

        If DetectFormEvent.CheckBox_TempWinHandle.Checked Then
            strWndClass = DetectFormEvent.TextBox_WndClass.Text
        End If

        Return strWndClass
    End Function

    Public Function GetParam4() As String Implements StepDataParam.GetParam4
        Return ""
    End Function

    Public Function GetParam5() As String Implements StepDataParam.GetParam5
        Return ""
    End Function

    Public Overrides Function GetPosition(ByVal iRowIndex As Integer) As String

        Return MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM1).Value

    End Function
End Class
