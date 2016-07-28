Public Class StepDataItem

    ' At the view of DetectFormEvent, to get variables from MainFormUI

    Public Overridable Function GetPosition(ByVal iRowIndex As Integer) As String

        Return ""

    End Function

    Public Overridable Function GetPositionUp(ByVal iRowIndex As Integer) As String

        Return ""

    End Function
    Public Overridable Function GetImageSize(ByVal iRowIndex As Integer) As String

        Return ""

    End Function

    Public Overridable Function GetHiLimitOfPixel(ByVal iRowIndex As Integer) As String

        Return ""

    End Function

    Public Overridable Function GetLowLimitOfPixel(ByVal iRowIndex As Integer) As String

        Return ""

    End Function

    Public Overridable Function GetScrollCount(iRowIndex As Integer) As Integer

        Return 0

    End Function

    Public Overridable Function GetTypeString(ByVal iRowIndex As Integer) As String

        Return ""

    End Function

    Public Overridable Function GetWindowTitle(ByVal iRowIndex As Integer) As String

        Return ""

    End Function

    Public Overridable Function GetWindowClass(ByVal iRowIndex As Integer) As String

        Return ""

    End Function

    Public Overridable Function GetVARIndex(ByVal iRowIndex As Integer) As Integer

        Return 0

    End Function

    Public Overridable Function GetVARsIndex(ByVal iRowIndex As Integer) As Integer

        Return 0

    End Function

    Public Overridable Function GetVAROperator(ByVal iRowIndex As Integer) As String

        Return ""

    End Function

    Public Overridable Function GetVARNumeric(ByVal iRowIndex As Integer) As Integer

        Return 0

    End Function
    Public Overridable Function GetVARHiLim(ByVal iRowIndex As Integer) As Double

        Return 0

    End Function

    Public Overridable Function GetVARLowLim(ByVal iRowIndex As Integer) As Double

        Return 0

    End Function

    Public Overridable Function GetSVARIndex(ByVal iRowIndex As Integer) As Integer

        Return 0

    End Function

    Public Overridable Function GetSVARString(ByVal iRowIndex As Integer) As String

        Return ""

    End Function

    Public Overridable Function GetSVARCheck(ByVal iRowIndex As Integer) As String

        Return ""

    End Function

    Public Overridable Function GetFileSourcePath(ByVal iRowIndex As Integer) As String

        Return ""

    End Function

    Public Overridable Function GetFileString(ByVal iRowIndex As Integer) As String

        Return ""

    End Function

    Public Overridable Function GetFileRead_SVARIndex(ByVal iRowIndex As Integer) As Integer

        Return 0

    End Function

    Public Overridable Function GetFileDestPath(ByVal iRowIndex As Integer) As String

        Return ""

    End Function

    Public Overridable Function GetWatchDogIndex(iRowIndex As Integer) As Integer

        Return -1

    End Function

    Public Overridable Function GetWatchDogFeedTime(iRowIndex As Integer) As Integer

        Return 0

    End Function

    Public Overridable Function GetForceAboutTimer(iRowIndex As Integer) As Integer

        Return 0

    End Function

End Class
