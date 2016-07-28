Public Class StepAction_FileStringCheck

    Implements StepAction

    Public Function DoCommand(ByRef hwndCurWnd As Integer, curStepInfo As StepDataBase, ByRef strLogMessage As String) As Integer Implements StepAction.DoCommand
        Dim StepInfoObj As StepData_File = curStepInfo
        Dim bStepPass As Boolean = False

        Try
            Dim strFileContent As String = ""
            Dim objReader As New System.IO.StreamReader(StepInfoObj.strFileSourcePath)
            strFileContent = objReader.ReadToEnd
            objReader.Close()

            If strFileContent.Contains(StepInfoObj.strFileString) Then
                bStepPass = True
            End If
        Catch ex As Exception
            MessageBox.Show("File String Check Error." & ex.Message)
        End Try

        strLogMessage = "Check string (" & StepInfoObj.strFileString & ") from file (" & StepInfoObj.strFileSourcePath & ")" & vbNewLine _
                     & "Result: " & bStepPass

        Return bStepPass
    End Function

End Class
