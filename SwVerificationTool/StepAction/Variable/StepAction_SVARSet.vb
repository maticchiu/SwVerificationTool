Public Class StepAction_SVARSet

    Implements StepAction

    Public Function DoCommand(ByRef hwndCurWnd As Integer, curStepInfo As StepDataBase, ByRef strLogMessage As String) As Integer Implements StepAction.DoCommand
        Dim StepInfoObj As StepData_Variable = curStepInfo
        Dim iSvarIndex As Integer = StepInfoObj.iSVarIndex
        'gastrSVAR(iSvarIndex) = curStepInfo.strSVarString
        'MainFormData.SvarSet(iSvarIndex, curStepInfo.strSVarString)
        MainFormData.SVAR(iSvarIndex) = StepInfoObj.strSVarString
        Return True
    End Function

End Class
