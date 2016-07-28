Public Class StepData_File
    Inherits StepDataBase

    Public strFileSourcePath As String
    Public strFileDestPath As String
    Public iFileReadSvarIndex As Integer
    Public strFileString As String

    Public Overrides Sub SetSpecificData(stepinfo As StepDataBase, iRowIndex As Integer, iCommandType As Integer)

        Dim StepDataObj As StepData_File = stepinfo

        StepDataObj.strFileSourcePath = AppCommandData.GetFileSourcePath(iRowIndex, iCommandType)
        StepDataObj.strFileDestPath = AppCommandData.GetFileDestPath(iRowIndex, iCommandType)
        StepDataObj.iFileReadSvarIndex = AppCommandData.GetFileRead_SVARIndex(iRowIndex, iCommandType)
        StepDataObj.strFileString = AppCommandData.GetFileString(iRowIndex, iCommandType)


    End Sub

End Class
