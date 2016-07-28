Public Class StepData_Window
    Inherits StepDataBase

    Public posPosition As Point
    Public posPositionUp As Point
    Public sizeImgSize As Size
    Public colorPixelHiLim As Color
    Public colorPixelLowLim As Color
    Public iScrollCount As Integer
    Public strTypeString As String
    Public strWindowTitle As String
    Public strWindowClass As String

    Public Overrides Sub SetSpecificData(stepinfo As StepDataBase, iRowIndex As Integer, iCommandType As Integer)

        Dim StepDataObj As StepData_Window = stepinfo

        StepDataObj.posPosition = Utility.Position_Str2Pos(AppCommandData.GetPosition(iRowIndex, iCommandType))
        StepDataObj.posPositionUp = Utility.Position_Str2Pos(AppCommandData.GetPositionUp(iRowIndex, iCommandType))
        StepDataObj.sizeImgSize = Utility.Position_Str2Pos(AppCommandData.GetImageSize(iRowIndex, iCommandType))
        StepDataObj.colorPixelHiLim = Utility.Color_Str2Color(AppCommandData.GetHiLimitOfPixel(iRowIndex, iCommandType))
        StepDataObj.colorPixelLowLim = Utility.Color_Str2Color(AppCommandData.GetLowLimitOfPixel(iRowIndex, iCommandType))
        StepDataObj.iScrollCount = AppCommandData.GetScrollCount(iRowIndex, iCommandType)
        StepDataObj.strTypeString = AppCommandData.GetTypeString(iRowIndex, iCommandType)
        StepDataObj.strWindowTitle = AppCommandData.GetWindowTitle(iRowIndex, iCommandType)
        StepDataObj.strWindowClass = AppCommandData.GetWindowClass(iRowIndex, iCommandType)

    End Sub

End Class
