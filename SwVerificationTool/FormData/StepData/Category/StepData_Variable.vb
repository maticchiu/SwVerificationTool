Public Class StepData_Variable
    Inherits StepDataBase

    Public iVarIndex As Integer
    Public iVarsIndex As Integer
    Public strVarOp As String
    Public dVarNumeric As Double
    Public dVarHiLim As Double
    Public dVarLowLim As Double

    Public iSVarIndex As Integer
    Public strSVarString As String
    Public strSVarCheck As String

    Public Overrides Sub SetSpecificData(stepinfo As StepDataBase, iRowIndex As Integer, iCommandType As Integer)

        Dim StepDataObj As StepData_Variable = stepinfo

        StepDataObj.iVarIndex = AppCommandData.GetVARIndex(iRowIndex, iCommandType)
        StepDataObj.iVarsIndex = AppCommandData.GetVARsIndex(iRowIndex, iCommandType)
        StepDataObj.strVarOp = AppCommandData.GetVAROperator(iRowIndex, iCommandType)
        StepDataObj.dVarNumeric = AppCommandData.GetVARNumeric(iRowIndex, iCommandType)
        StepDataObj.dVarHiLim = AppCommandData.GetVARHiLim(iRowIndex, iCommandType)
        StepDataObj.dVarLowLim = AppCommandData.GetVARLowLim(iRowIndex, iCommandType)
        StepDataObj.iSVarIndex = AppCommandData.GetSVARIndex(iRowIndex, iCommandType)
        StepDataObj.strSVarCheck = AppCommandData.GetSVARCheck(iRowIndex, iCommandType)

    End Sub


End Class
