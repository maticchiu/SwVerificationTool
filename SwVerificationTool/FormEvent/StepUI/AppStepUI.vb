Public Class AppStepUI

    Private Shared Function GetStepUIObj(ByVal iCommandType As Integer) As Object

        Dim CmdStepInfo As Object = Nothing

        Select Case iCommandType
            Case MainFormData.CommandType.MOUSE_CLICK
                CmdStepInfo = New StepUI_MouseClick
            Case MainFormData.CommandType.MOUSE_CLICK_COLOR
                CmdStepInfo = New StepUI_MouseClick_Color
            Case MainFormData.CommandType.MOUSE_CLICK_RIGHT
                CmdStepInfo = New StepUI_MouseClick_Right
            Case MainFormData.CommandType.MOUSE_SCROLL
                CmdStepInfo = New StepUI_MouseScroll
            Case MainFormData.CommandType.MOUSE_DRAG
                CmdStepInfo = New StepUI_MouseDrag
            Case MainFormData.CommandType.PIXEL_DETECTION
                CmdStepInfo = New StepUI_PixelDetection
            Case MainFormData.CommandType.IMAGE_DETECTION
                CmdStepInfo = New StepUI_ImageDetection
            Case MainFormData.CommandType.IMAGE_CATCH
                CmdStepInfo = New StepUI_ImageCatch
            Case MainFormData.CommandType.TYPE_STRING
                CmdStepInfo = New StepUI_TypeString
            Case MainFormData.CommandType.DELAY
                CmdStepInfo = New StepUI_Delay
            Case MainFormData.CommandType.WINDOW_SET
                CmdStepInfo = New StepUI_WindowSet
            Case MainFormData.CommandType.WINDOW_DETECTION
                CmdStepInfo = New StepUI_WindowDetection
            Case MainFormData.CommandType.EXECUTE
                CmdStepInfo = New StepUI_Execute
            Case MainFormData.CommandType.VAR_SET
                CmdStepInfo = New StepUI_VARSet
            Case MainFormData.CommandType.VAR_CHECK
                CmdStepInfo = New StepUI_VARCheck
            Case MainFormData.CommandType.SVAR_SET
                CmdStepInfo = New StepUI_SVARSet
            Case MainFormData.CommandType.SVAR_CHECK
                CmdStepInfo = New StepUI_SVARCheck
            Case MainFormData.CommandType.FILE_WRITE
                CmdStepInfo = New StepUI_FileWrite
            Case MainFormData.CommandType.FILE_APPEND
                CmdStepInfo = New StepUI_FileAppend
            Case MainFormData.CommandType.FILE_READ
                CmdStepInfo = New StepUI_FileRead
            Case MainFormData.CommandType.FILE_COPY
                CmdStepInfo = New StepUI_FileCopy
            Case MainFormData.CommandType.FILE_STRING_CHECK
                CmdStepInfo = New StepUI_FileStringCheck
            Case MainFormData.CommandType.WATCHDOG_ENABLE
                CmdStepInfo = New StepUI_WatchDogEnable
            Case MainFormData.CommandType.WATCHDOG_FEED
                CmdStepInfo = New StepUI_WatchDogFeed
            Case MainFormData.CommandType.WATCHDOG_DISABLE
                CmdStepInfo = New StepUI_WatchDogDisable
            Case MainFormData.CommandType.FORCEABORT_TIMER
                CmdStepInfo = New StepUI_ForceAbortTimer
            Case Else
                CmdStepInfo = New StepUIBase
        End Select

        Return CmdStepInfo

    End Function

    Public Shared Sub StepUISetting(iCommandType As Integer)
        Dim CmdUI As StepUIBase = GetStepUIObj(iCommandType)
        CmdUI.StepUISetting()
    End Sub

End Class
