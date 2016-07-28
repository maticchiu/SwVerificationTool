Public Class StepData_System
    Inherits StepDataBase

    Public iWatchDogIndex As Integer
    Public iWatchDogFeedInterval As Integer
    Public WatchDogLastFeedTime As TimeSpan
    'Public IsWatchDogEnable As Boolean

    Public iForceAbortTimeout As Integer

    Public Overrides Sub SetSpecificData(stepinfo As StepDataBase, iRowIndex As Integer, iCommandType As Integer)

        Dim StepDataObj As StepData_System = stepinfo

        StepDataObj.iWatchDogIndex = AppCommandData.GetWatchDogIndex(iRowIndex, iCommandType)
        StepDataObj.iWatchDogFeedInterval = AppCommandData.GetWatchDogFeedTime(iRowIndex, iCommandType)
        StepDataObj.iForceAbortTimeout = AppCommandData.GetForceAbortTimer(iRowIndex, iCommandType)

    End Sub

End Class
