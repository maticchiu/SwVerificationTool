Public Class StepAction_VARSet

    Implements StepAction

    Public Function DoCommand(ByRef hwndCurWnd As Integer, curStepInfo As StepDataBase, ByRef strLogMessage As String) As Integer Implements StepAction.DoCommand
        Dim StepInfoObj As StepData_Variable = curStepInfo
        Dim dVar As Double = 0
        Dim dVars As Double = 0
        Dim dNum As Double = StepInfoObj.dVarNumeric

        If StepInfoObj.iVarsIndex <> -1 Then
            dVars = MainFormData.VAR(StepInfoObj.iVarsIndex) 'MainFormData.VarGet(curStepInfo.iVarsIndex)
        End If

        If StepInfoObj.strVarOp = "+" Then
            dVar = dVars + dNum
        ElseIf StepInfoObj.strVarOp = "-" Then
            dVar = dVars - dNum
        ElseIf StepInfoObj.strVarOp = "*" Then
            dVar = dVars * dNum
        ElseIf StepInfoObj.strVarOp = "/" Then
            dVar = dVars / dNum
        ElseIf StepInfoObj.strVarOp = "%" Then
            dVar = dVars Mod dNum
        ElseIf StepInfoObj.strVarOp = "\" Then
            dVar = dVars \ dNum
        End If

        If StepInfoObj.iVarsIndex <> -1 Then
            ' MainFormData.VarSet(curStepInfo.iVarIndex, dVar)
            MainFormData.VAR(StepInfoObj.iVarIndex) = dVar
        End If

        strLogMessage = vbTab & " - New VAR(" & StepInfoObj.iVarIndex & "): " & dVar


        Return True
    End Function

End Class
