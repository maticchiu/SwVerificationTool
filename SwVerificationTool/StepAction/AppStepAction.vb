Public Class AppStepAction

    Private Shared Function GetCommandObj(ByVal iCommandType As Integer) As Object

        Dim CmdStepInfo As Object = Nothing

        Select Case iCommandType
            Case MainFormData.CommandType.MOUSE_CLICK
                CmdStepInfo = New StepAction_MouseClick
            Case MainFormData.CommandType.MOUSE_CLICK_COLOR
                CmdStepInfo = New StepAction_MouseClick_Color
            Case MainFormData.CommandType.MOUSE_CLICK_RIGHT
                CmdStepInfo = New StepAction_MouseClick_Right
            Case MainFormData.CommandType.MOUSE_SCROLL
                CmdStepInfo = New StepAction_MouseScroll
            Case MainFormData.CommandType.MOUSE_DRAG
                CmdStepInfo = New StepAction_MouseDrag
            Case MainFormData.CommandType.PIXEL_DETECTION
                CmdStepInfo = New StepAction_PixelDetection
            Case MainFormData.CommandType.IMAGE_DETECTION
                CmdStepInfo = New StepAction_ImageDetection
            Case MainFormData.CommandType.IMAGE_CATCH
                CmdStepInfo = New StepAction_ImageCatch
            Case MainFormData.CommandType.TYPE_STRING
                CmdStepInfo = New StepAction_TypeString
            Case MainFormData.CommandType.DELAY
                CmdStepInfo = New StepAction_Delay
            Case MainFormData.CommandType.WINDOW_SET
                CmdStepInfo = New StepAction_WindowSet
            Case MainFormData.CommandType.WINDOW_DETECTION
                CmdStepInfo = New StepAction_WindowDetection
            Case MainFormData.CommandType.EXECUTE
                CmdStepInfo = New StepAction_Execute
            Case MainFormData.CommandType.VAR_SET
                CmdStepInfo = New StepAction_VARSet
            Case MainFormData.CommandType.VAR_CHECK
                CmdStepInfo = New StepAction_VARCheck
            Case MainFormData.CommandType.SVAR_SET
                CmdStepInfo = New StepAction_SVARSet
            Case MainFormData.CommandType.SVAR_CHECK
                CmdStepInfo = New StepAction_SVARCheck
            Case MainFormData.CommandType.FILE_WRITE
                CmdStepInfo = New StepAction_FileWrite
            Case MainFormData.CommandType.FILE_APPEND
                CmdStepInfo = New StepAction_FileAppend
            Case MainFormData.CommandType.FILE_READ
                CmdStepInfo = New StepAction_FileRead
            Case MainFormData.CommandType.FILE_COPY
                CmdStepInfo = New StepAction_FileCopy
            Case MainFormData.CommandType.FILE_STRING_CHECK
                CmdStepInfo = New StepAction_FileStringCheck
            Case MainFormData.CommandType.WATCHDOG_ENABLE
                CmdStepInfo = New StepAction_WatchDogEnable
            Case MainFormData.CommandType.WATCHDOG_FEED
                CmdStepInfo = New StepAction_WatchDogFeed
            Case MainFormData.CommandType.WATCHDOG_DISABLE
                CmdStepInfo = New StepAction_WatchDogDisable
            Case MainFormData.CommandType.FORCEABORT_TIMER
                CmdStepInfo = New StepAction_ForceAbortTimer
            Case Else

        End Select

        Return CmdStepInfo

    End Function

    Public Shared Function DoCommand(ByRef wndHandle As Integer, ByVal curStepInfo As StepDataBase, ByRef strLogMessage As String) As Integer

        Dim CmdAct As StepAction = GetCommandObj(curStepInfo.iCommandType)
        Dim iRet As Integer = 0

        iRet = CmdAct.DoCommand(wndHandle, curStepInfo, strLogMessage)

        Return iRet

    End Function

End Class
