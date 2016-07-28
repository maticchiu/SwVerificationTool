Public Class StepAction_VARCheck

    Implements StepAction

    Public Function DoCommand(ByRef hwndCurWnd As Integer, curStepInfo As StepDataBase, ByRef strLogMessage As String) As Integer Implements StepAction.DoCommand
        Dim StepInfoObj As StepData_Variable = curStepInfo
        Dim dVar As Double = MainFormData.VAR(StepInfoObj.iVarIndex) 'MainFormData.VarGet(curStepInfo.iVarIndex)
        Dim dVarHiLim As Double = StepInfoObj.dVarHiLim
        Dim dVarLowLim As Double = StepInfoObj.dVarLowLim
        Dim bStepPass As Boolean = True
        If dVar > dVarHiLim Or dVar < dVarLowLim Then
            bStepPass = False
        End If

        Return bStepPass
    End Function

End Class
