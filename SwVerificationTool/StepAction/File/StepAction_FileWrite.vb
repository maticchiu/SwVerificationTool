Public Class StepAction_FileWrite

    Implements StepAction

    Public Function DoCommand(ByRef hwndCurWnd As Integer, curStepInfo As StepDataBase, ByRef strLogMessage As String) As Integer Implements StepAction.DoCommand
        Dim StepInfoObj As StepData_File = curStepInfo
        Dim strContent As String = StepInfoObj.strFileString & vbNewLine

        Try
            Dim objWriter As New System.IO.StreamWriter(StepInfoObj.strFileSourcePath)
            objWriter.Write(strContent)
            objWriter.Close()
        Catch ex As Exception
            MessageBox.Show("File Write Error." & ex.Message)
        End Try

        strLogMessage = strContent

        Return True
    End Function

End Class
