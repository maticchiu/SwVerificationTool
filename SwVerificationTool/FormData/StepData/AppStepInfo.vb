Public Class AppStepInfo


    Private Shared stepinfo As New List(Of StepDataBase)


    Public Shared Function GetData(iDataIndex As Integer) As StepDataBase
        Return stepinfo.Item(iDataIndex)
    End Function

    Public Shared Function GetLength() As Integer

        If stepinfo Is Nothing Then
            MessageBox.Show("StepInfo doesn't exist")
            Return 0
        End If

        Return stepinfo.Count
    End Function

    Public Shared Function IsStepInfoExist() As Boolean
        If stepinfo Is Nothing Then
            Return False
        End If
        Return True
    End Function

    Private Shared Function GetStepDataObj(iCommandType As Integer) As StepDataBase

        Dim StepDataObj As StepDataBase = Nothing
        Dim iCommandCategory As DetectFormData.CommandCategory = DetectFormData.GetCommandCategoryFromCommandType(iCommandType)

        Select Case iCommandCategory
            Case DetectFormData.CommandCategory.WINDOW
                StepDataObj = New StepData_Window
            Case DetectFormData.CommandCategory.VARIABLE
                StepDataObj = New StepData_Variable
            Case DetectFormData.CommandCategory.FILE
                StepDataObj = New StepData_File
            Case DetectFormData.CommandCategory.SYSTEM
                StepDataObj = New StepData_System

        End Select

        Return StepDataObj

    End Function

    Public Shared Sub SetDataFromDataGridView()

        Dim iStepNum As Integer = MainFormEvent.DataGridView_StepEdit.RowCount - 1
        Dim iRowIndex As Integer
        Dim iCommandType As Integer

        If iStepNum < 0 Then
            Exit Sub
        End If

        stepinfo.Clear()
        stepinfo.Add(New StepDataBase) 'ReDim stepinfo(iStepNum)

        ' stepinfo(0) will not be used
        For iStepIndex As Integer = 1 To iStepNum

            iRowIndex = iStepIndex - 1

            iCommandType = MainFormData.GetCommandTypeIndex(MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.COMMAND_TYPE).Value)

            Dim StepDataObj As StepDataBase = GetStepDataObj(iCommandType)

            StepDataObj.SetDataFromDataGridView(StepDataObj, iCommandType, iRowIndex)
            stepinfo.Add(StepDataObj)

        Next

    End Sub

End Class
