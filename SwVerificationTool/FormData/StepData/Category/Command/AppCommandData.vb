Public Class AppCommandData

    Private Shared Function GetStepDataObj(ByVal iCommandType As Integer) As Object

        Dim CmdStepInfo As Object = Nothing

        Select Case iCommandType
            Case MainFormData.CommandType.MOUSE_CLICK
                CmdStepInfo = New StepData_MouseClick
            Case MainFormData.CommandType.MOUSE_CLICK_COLOR
                CmdStepInfo = New StepData_MouseClick_Color
            Case MainFormData.CommandType.MOUSE_CLICK_RIGHT
                CmdStepInfo = New StepData_MouseClick_Right
            Case MainFormData.CommandType.MOUSE_SCROLL
                CmdStepInfo = New StepData_MouseScroll
            Case MainFormData.CommandType.MOUSE_DRAG
                CmdStepInfo = New StepData_MouseDrag
            Case MainFormData.CommandType.PIXEL_DETECTION
                CmdStepInfo = New StepData_PixelDetection
            Case MainFormData.CommandType.IMAGE_DETECTION
                CmdStepInfo = New StepData_ImageDetection
            Case MainFormData.CommandType.IMAGE_CATCH
                CmdStepInfo = New StepData_ImageCatch
            Case MainFormData.CommandType.TYPE_STRING
                CmdStepInfo = New StepData_TypeString
            Case MainFormData.CommandType.DELAY
                CmdStepInfo = New StepData_Delay
            Case MainFormData.CommandType.WINDOW_SET
                CmdStepInfo = New StepData_WindowSet
            Case MainFormData.CommandType.WINDOW_DETECTION
                CmdStepInfo = New StepData_WindowDetection
            Case MainFormData.CommandType.EXECUTE
                CmdStepInfo = New StepData_Execute
            Case MainFormData.CommandType.VAR_SET
                CmdStepInfo = New StepData_VARSet
            Case MainFormData.CommandType.VAR_CHECK
                CmdStepInfo = New StepData_VARCheck
            Case MainFormData.CommandType.SVAR_SET
                CmdStepInfo = New StepData_SVARSet
            Case MainFormData.CommandType.SVAR_CHECK
                CmdStepInfo = New StepData_SVARCheck
            Case MainFormData.CommandType.FILE_WRITE
                CmdStepInfo = New StepData_FileWrite
            Case MainFormData.CommandType.FILE_APPEND
                CmdStepInfo = New StepData_FileAppend
            Case MainFormData.CommandType.FILE_READ
                CmdStepInfo = New StepData_FileRead
            Case MainFormData.CommandType.FILE_COPY
                CmdStepInfo = New StepData_FileCopy
            Case MainFormData.CommandType.FILE_STRING_CHECK
                CmdStepInfo = New StepData_FileStringCheck
            Case MainFormData.CommandType.WATCHDOG_ENABLE
                CmdStepInfo = New StepData_WatchDogEnable
            Case MainFormData.CommandType.WATCHDOG_FEED
                CmdStepInfo = New StepData_WatchDogFeed
            Case MainFormData.CommandType.WATCHDOG_DISABLE
                CmdStepInfo = New StepData_WatchDogDisable
            Case MainFormData.CommandType.FORCEABORT_TIMER
                CmdStepInfo = New StepData_ForceAbortTimer
            Case Else

        End Select

        Return CmdStepInfo

    End Function

    Public Shared Function GetParam(ByVal ParamNum As Integer, ByVal iCommandType As Integer) As String

        Dim Param As String = ""
        Dim CmdParam As StepDataParam = GetStepDataObj(iCommandType)

        If Not IsNothing(CmdParam) Then

            Select Case ParamNum

                Case MainFormData.ParamNum.PARAM1
                    Param = CmdParam.GetParam1
                Case MainFormData.ParamNum.PARAM2
                    Param = CmdParam.GetParam2
                Case MainFormData.ParamNum.PARAM3
                    Param = CmdParam.GetParam3
                Case MainFormData.ParamNum.PARAM4
                    Param = CmdParam.GetParam4
                Case MainFormData.ParamNum.PARAM5
                    Param = CmdParam.GetParam5
            End Select

        End If

        Return Param
    End Function

    Public Shared Function GetPosition(ByVal iRowIndex As Integer, ByVal iCommandType As Integer) As String

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)

        Return CmdStepInfo.GetPosition(iRowIndex)

    End Function

    Public Shared Function GetPositionUp(ByVal iRowIndex As Integer, ByVal iCommandType As Integer) As String

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)

        Return CmdStepInfo.GetPositionUp(iRowIndex)

    End Function

    Public Shared Function GetImageSize(ByVal iRowIndex As Integer, ByVal iCommandType As Integer) As String

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)
        Return CmdStepInfo.GetImageSize(iRowIndex)

    End Function

    Public Shared Function GetHiLimitOfPixel(ByVal iRowIndex As Integer, ByVal iCommandType As Integer) As String

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)
        Return CmdStepInfo.GetHiLimitOfPixel(iRowIndex)

    End Function

    Public Shared Function GetLowLimitOfPixel(ByVal iRowIndex As Integer, ByVal iCommandType As Integer) As String

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)
        Return CmdStepInfo.GetLowLimitOfPixel(iRowIndex)

    End Function

    Public Shared Function GetScrollCount(iRowIndex As Integer, iCommandType As Integer) As Integer

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)
        Return CmdStepInfo.GetScrollCount(iRowIndex)

    End Function

    Public Shared Function GetTypeString(ByVal iRowIndex As Integer, ByVal iCommandType As Integer) As String

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)
        Return CmdStepInfo.GetTypeString(iRowIndex)

    End Function

    Public Shared Function GetWindowTitle(ByVal iRowIndex As Integer, ByVal iCommandType As Integer) As String

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)
        Return CmdStepInfo.GetWindowTitle(iRowIndex)

    End Function

    Public Shared Function GetWindowClass(ByVal iRowIndex As Integer, ByVal iCommandType As Integer) As String

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)
        Return CmdStepInfo.GetWindowClass(iRowIndex)

    End Function

    Public Shared Function GetVARIndex(ByVal iRowIndex As Integer, ByVal iCommandType As Integer) As Integer

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)
        Return CmdStepInfo.GetVARIndex(iRowIndex)

    End Function

    Public Shared Function GetVARsIndex(ByVal iRowIndex As Integer, ByVal iCommandType As Integer) As Integer

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)
        Return CmdStepInfo.GetVARsIndex(iRowIndex)

    End Function

    Public Shared Function GetVAROperator(ByVal iRowIndex As Integer, ByVal iCommandType As Integer) As String

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)
        Return CmdStepInfo.GetVAROperator(iRowIndex)

    End Function

    Public Shared Function GetVARNumeric(ByVal iRowIndex As Integer, ByVal iCommandType As Integer) As Integer

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)
        Return CmdStepInfo.GetVARNumeric(iRowIndex)

    End Function
    Public Shared Function GetVARHiLim(ByVal iRowIndex As Integer, ByVal iCommandType As Integer) As Double

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)
        Return CmdStepInfo.GetVARHiLim(iRowIndex)

    End Function

    Public Shared Function GetVARLowLim(ByVal iRowIndex As Integer, ByVal iCommandType As Integer) As Double

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)
        Return CmdStepInfo.GetVARLowLim(iRowIndex)

    End Function

    Public Shared Function GetSVARIndex(ByVal iRowIndex As Integer, ByVal iCommandType As Integer) As Integer

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)
        Return CmdStepInfo.GetSVARIndex(iRowIndex)

    End Function

    Public Shared Function GetSVARString(ByVal iRowIndex As Integer, ByVal iCommandType As Integer) As String

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)
        Return CmdStepInfo.GetSVARString(iRowIndex)

    End Function

    Public Shared Function GetSVARCheck(ByVal iRowIndex As Integer, ByVal iCommandType As Integer) As String

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)
        Return CmdStepInfo.GetSVARCheck(iRowIndex)

    End Function


    Public Shared Function GetFileSourcePath(ByVal iRowIndex As Integer, ByVal iCommandType As Integer) As String

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)
        Return CmdStepInfo.GetFileSourcePath(iRowIndex)

    End Function

    Public Shared Function GetFileString(ByVal iRowIndex As Integer, ByVal iCommandType As Integer) As String

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)
        Return CmdStepInfo.GetFileString(iRowIndex)

    End Function

    Public Shared Function GetFileRead_SVARIndex(ByVal iRowIndex As Integer, ByVal iCommandType As Integer) As Integer

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)
        Return CmdStepInfo.GetFileRead_SVARIndex(iRowIndex)

    End Function

    Public Shared Function GetFileDestPath(ByVal iRowIndex As Integer, ByVal iCommandType As Integer) As String

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)
        Return CmdStepInfo.GetFileDestPath(iRowIndex)

    End Function

    Public Shared Function GetWatchDogIndex(iRowIndex As Integer, iCommandType As Integer) As Integer

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)
        Return CmdStepInfo.GetWatchDogIndex(iRowIndex)

    End Function

    Public Shared Function GetWatchDogFeedTime(iRowIndex As Integer, iCommandType As Integer) As Integer

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)
        Return CmdStepInfo.GetWatchDogFeedTime(iRowIndex)

    End Function

    Public Shared Function GetForceAbortTimer(iRowIndex As Integer, iCommandType As Integer) As Integer

        Dim CmdStepInfo As StepDataItem = GetStepDataObj(iCommandType)
        Return CmdStepInfo.GetForceAboutTimer(iRowIndex)

    End Function

End Class
