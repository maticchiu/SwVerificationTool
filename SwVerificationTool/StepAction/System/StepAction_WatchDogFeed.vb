Public Class StepAction_WatchDogFeed

    Implements StepAction

    Public Function DoCommand(ByRef hwndCurWnd As Integer, curStepInfo As StepDataBase, ByRef strLogMessage As String) As Integer Implements StepAction.DoCommand

        Dim StepInfoObj As StepData_System = curStepInfo

        AppWatchDogInfo.WatchDog_Feed(StepInfoObj.iWatchDogIndex)

        Return 0

    End Function

End Class
