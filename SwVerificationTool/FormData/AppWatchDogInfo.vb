Public Class AppWatchDogInfo

    Structure WatchDogParam
        Dim FeedIntervalTime As Integer
        Dim LastFeedTime As DateTime
        Dim IsEnable As Boolean
    End Structure


    Private Shared watchdoginfo(MainFormData.WatchDogIndex.WATCHDOG_TOTAL - 1) As WatchDogParam

    Public Shared Sub WatchDog_Enable(WatchDogIndex As Integer, FeedInterval_minutes As Integer)

        watchdoginfo(WatchDogIndex).IsEnable = True

        watchdoginfo(WatchDogIndex).FeedIntervalTime = FeedInterval_minutes

        watchdoginfo(WatchDogIndex).LastFeedTime = Now 'watchdoginfo(WatchDogIndex).LastFeedTime = TimeSpan.Parse(Now)

    End Sub

    Public Shared Sub WatchDog_Feed(WatchDogIndex As Integer)

        watchdoginfo(WatchDogIndex).LastFeedTime = Now

    End Sub

    Public Shared Function WatchDog_TimeCheck(WatchDogIndex As Integer) As Boolean

        Dim bIsTimeout As Boolean = False

        If watchdoginfo(WatchDogIndex).IsEnable Then

            If DateDiff(DateInterval.Minute, watchdoginfo(WatchDogIndex).LastFeedTime, Now) >= watchdoginfo(WatchDogIndex).FeedIntervalTime Then
                bIsTimeout = True
            End If

        End If

        Return bIsTimeout

    End Function

    Public Shared Sub WatchDog_Disable(WatchDogIndex As Integer)

        If WatchDogIndex >= MainFormData.WatchDogIndex.WATCHDOG_0 And WatchDogIndex < MainFormData.WatchDogIndex.WATCHDOG_TOTAL Then
            watchdoginfo(WatchDogIndex).IsEnable = False
        Else
            For index As Integer = MainFormData.WatchDogIndex.WATCHDOG_0 To MainFormData.WatchDogIndex.WATCHDOG_TOTAL - 1
                watchdoginfo(index).IsEnable = False
            Next
        End If

    End Sub



End Class
