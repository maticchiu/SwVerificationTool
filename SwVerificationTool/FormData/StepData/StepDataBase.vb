Public Class StepDataBase

    Public iStepNum As Integer
    Public strStepName As String
    Public iCommandType As Integer
    Public strParam1 As String
    Public strParam2 As String
    Public strParam3 As String
    Public strParam4 As String
    Public strParam5 As String
    Public bIsSkip As Boolean

    Public delay As Integer
    Public iNextStep As Integer
    Public iLastStep As Integer

    Public Sub SetDataFromDataGridView(stepinfo As StepDataBase, iCommandType As Integer, iRowIndex As Integer)

        stepinfo.iStepNum = Convert.ToInt32(MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.STEP_NUM).Value)
        stepinfo.strStepName = MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.STEP_NAME).Value
        stepinfo.iCommandType = iCommandType
        stepinfo.delay = Convert.ToInt32(MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.DELAY).Value)
        stepinfo.iNextStep = Convert.ToInt32(MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.NEXT_STEP).Value)
        stepinfo.iLastStep = Convert.ToInt32(MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.LAST_STEP).Value)
        If stepinfo.iStepNum > 0 Then
            stepinfo.bIsSkip = False
        Else
            stepinfo.bIsSkip = True
        End If

        SetSpecificData(stepinfo, iRowIndex, iCommandType)

    End Sub

    Public Overridable Sub SetSpecificData(stepinfo As StepDataBase, iRowIndex As Integer, iCommandType As Integer)

    End Sub

End Class
