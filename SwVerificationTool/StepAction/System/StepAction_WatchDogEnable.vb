Public Class StepAction_WatchDogEnable

    Implements StepAction

    Public Function DoCommand(ByRef hwndCurWnd As Integer, curStepInfo As StepDataBase, ByRef strLogMessage As String) As Integer Implements StepAction.DoCommand

        Dim StepInfoObj As StepData_System = curStepInfo

        AppWatchDogInfo.WatchDog_Enable(StepInfoObj.iWatchDogIndex, StepInfoObj.iWatchDogFeedInterval)

        Return 0

    End Function


End Class
