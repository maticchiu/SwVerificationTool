Public Class StepAction_FileAppend

    Implements StepAction

    Public Function DoCommand(ByRef hwndCurWnd As Integer, curStepInfo As StepDataBase, ByRef strLogMessage As String) As Integer Implements StepAction.DoCommand
        Dim StepInfoObj As StepData_File = curStepInfo
        Dim strContent As String = StepInfoObj.strFileString & vbNewLine

        Try
            Dim objWriter As New System.IO.StreamWriter(StepInfoObj.strFileSourcePath, True)
            objWriter.Write(strContent)
            objWriter.Close()
        Catch ex As Exception
            MessageBox.Show("File Append Error." & ex.Message)
        End Try

        strLogMessage = "Write file: " & strContent


        Return True
    End Function


End Class
