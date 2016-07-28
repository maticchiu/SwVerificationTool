Public Class AppScriptInfo


    Public Structure Script_Info

        Public iScriptNum As Integer
        Public sScriptName As String
        Public iNextScript As Integer
        Public sTimeScript As String
        Public bIsSkip As Boolean
    End Structure

    Private Shared scriptinfo() As Script_Info

    Public Shared Function GetData(ByVal iDataIndex) As Script_Info
        Return scriptinfo(iDataIndex)
    End Function

    Public Shared Function GetLength() As Integer
        Return scriptinfo.Length
    End Function

    Public Shared Function IsScriptInfoExist() As Boolean
        If scriptinfo Is Nothing Then
            Return False
        End If
        Return True
    End Function

    Public Shared Sub SetDataFromDataGridView()

        Dim iScriptNum As Integer = MainFormEvent.DataGridView_Sequence.RowCount - 1
        Dim iRowIndex As Integer

        If iScriptNum < 0 Then
            Exit Sub
        End If

        ReDim scriptinfo(iScriptNum)

        ' scriptinfo(0) will not be used
        For iScriptIndex As Integer = 1 To iScriptNum

            iRowIndex = iScriptIndex - 1

            scriptinfo(iScriptIndex).iScriptNum = Convert.ToInt32(MainFormEvent.DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.SCRIPT_NUM).Value)
            scriptinfo(iScriptIndex).sScriptName = MainFormEvent.DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.SCRIPT_NAME).Value
            scriptinfo(iScriptIndex).iNextScript = Convert.ToInt32(MainFormEvent.DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.NEXT_SCRIPT).Value)
            scriptinfo(iScriptIndex).sTimeScript = MainFormEvent.DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.TIME_SCRIPT).Value
            scriptinfo(iScriptIndex).bIsSkip = False
        Next

    End Sub

    Public Shared Sub SetData_bIsSkip(ByVal iDataIndex As Integer, ByVal bIsSkip As Boolean)
        scriptinfo(iDataIndex).bIsSkip = bIsSkip
    End Sub

End Class
