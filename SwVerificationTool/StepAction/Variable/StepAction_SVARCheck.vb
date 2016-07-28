Public Class StepAction_SVARCheck

    Implements StepAction

    Public Function DoCommand(ByRef hwndCurWnd As Integer, curStepInfo As StepDataBase, ByRef strLogMessage As String) As Integer Implements StepAction.DoCommand

        Dim StepInfoObj As StepData_Variable = curStepInfo
        Dim iSvarIndex As Integer = StepInfoObj.iSVarIndex
        Dim strSvarCheck As String = StepInfoObj.strSVarCheck
        Dim bStepPass As Boolean = True

        If MainFormData.SVAR(iSvarIndex).CompareTo(strSvarCheck) Then
            bStepPass = False
        End If

        strLogMessage = "SVAR check: (" & MainFormData.SVAR(iSvarIndex) & "), (" & strSvarCheck & ")" & vbNewLine & _
                     "Result: " & bStepPass
        Return bStepPass

    End Function

End Class
