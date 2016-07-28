
Imports System.Runtime.InteropServices

Public Class Utility

    Const MOUSEEVENTF_ABSOLUTE As UInteger = &H8000
    Const MOUSEEVENTF_LEFTDOWN As UInteger = &H2
    Const MOUSEEVENTF_LEFTUP As UInteger = &H4
    Const MOUSEEVENTF_MIDDLEDOWN As UInteger = &H20
    Const MOUSEEVENTF_MIDDLEUP As UInteger = &H40
    Const MOUSEEVENTF_MOVE As UInteger = &H1
    Const MOUSEEVENTF_RIGHTDOWN As UInteger = &H8
    Const MOUSEEVENTF_RIGHTUP As UInteger = &H10
    Const MOUSEEVENTF_XDOWN As UInteger = &H80
    Const MOUSEEVENTF_XUP As UInteger = &H100
    Const MOUSEEVENTF_WHEEL As UInteger = &H800
    Const MOUSEEVENTF_HWHEEL As UInteger = &H1000

    Const WHEEL_DELTA As UInteger = 120 ' One wheel click is defined as WHEEL_DELTA, which is 120.

    Public Declare Function WindowFromPoint Lib "user32" Alias "WindowFromPoint" (ByVal xPoint As Integer, ByVal yPoint As Integer) As Integer
    Private Declare Function GetWindowText Lib "user32" Alias "GetWindowTextA" (ByVal hwnd As IntPtr, ByVal lpString As String, ByVal cch As Integer) As Integer
    Private Declare Function GetClassName Lib "User32" Alias "GetClassNameA" (ByVal hwnd As Integer, ByVal lpClassName As String, ByVal nMaxCount As Integer) As Integer
    Public Declare Function GetWindowRect Lib "user32" (ByVal hwnd As Integer, ByRef lpRect As Rectangle) As Integer
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Integer
    Public Declare Function GetDC Lib "user32" (ByVal hwnd As Integer) As Integer
    Public Declare Function ReleaseDC Lib "user32" (ByVal hwnd As Integer, ByVal hdc As Integer) As Integer
    Public Declare Function GetPixel Lib "gdi32" (ByVal hdc As Integer, ByVal x As Integer, ByVal y As Integer) As Integer

    Public Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Private Declare Auto Function SetCursorPos Lib "User32.dll" (ByVal X As Integer, ByVal Y As Integer) As Integer
    Private Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Public Declare Function SetForegroundWindow Lib "user32" (ByVal hwnd As Integer) As IntPtr
    Public Declare Function GetForegroundWindow Lib "user32" Alias "GetForegroundWindow" () As Integer
    'Private Shared Function keybd_event(bVk As Byte, bScan As Byte, dwFlags As UInteger, dwExtraInfo As UIntPtr) As Boolean

    'Public Delegate Function EnumWindowProcess(ByVal Handle As IntPtr, ByVal Parameter As IntPtr) As Boolean
    'Public Declare Function EnumChildWindows Lib "user32" (ByVal hWndParent As Integer, ByVal Callback As EnumWindowProcess, ByVal lParam As Integer) As Boolean

    'Public Shared Function GetChildWindows(ByVal ParentHandle As IntPtr) As IntPtr()
    '    Dim ChildrenList As New List(Of IntPtr)
    '    Dim ListHandle As GCHandle = GCHandle.Alloc(ChildrenList)
    '    Try
    '        EnumChildWindows(ParentHandle, AddressOf EnumWindow, GCHandle.ToIntPtr(ListHandle))
    '    Finally
    '        If ListHandle.IsAllocated Then ListHandle.Free()
    '    End Try
    '    Return ChildrenList.ToArray
    'End Function

    'Public Shared Function EnumWindow(ByVal Handle As IntPtr, ByVal Parameter As IntPtr) As Boolean
    '    Dim ChildrenList As List(Of IntPtr) = GCHandle.FromIntPtr(Parameter).Target
    '    If ChildrenList Is Nothing Then Throw New Exception("GCHandle Target could not be cast as List(Of IntPtr)")
    '    ChildrenList.Add(Handle)
    '    Return True
    'End Function

    Public Shared Function GetWindowTitle(ByVal hwnd As Integer) As String

        Dim strWndTitle As String = New String(Chr(0), 256)

        GetWindowText(hwnd, strWndTitle, 255)

        Return strWndTitle

    End Function

    Public Shared Function GetForegroundWindowTitle() As String
        Dim strWndTitle As String = New String(Chr(0), 256)
        Dim hwnd As Integer = GetForegroundWindow()

        If hwnd <> 0 Then

            GetWindowText(hwnd, strWndTitle, strWndTitle.Length - 1)

        End If

        Return strWndTitle

    End Function

    Public Shared Function GetWindowClass(ByVal hwnd As Integer) As String

        Dim strWndClass As String = New String(Chr(0), 256)

        GetClassName(hwnd, strWndClass, 255)

        Return strWndClass

    End Function

    Public Shared Function GetWindowHandle(ByVal strWindowTitle As String, ByVal strWindowClass As String) As Integer

        Dim iWndHandle As Integer = 0
        Dim strWndTitle As String
        Dim strWndClass As String

        ' need to copy out, or contents will be modified by FindWindow() (I have no idea why)
        strWndTitle = strWindowTitle
        If strWndTitle = "" Then
            strWndTitle = Nothing
        End If
        strWndClass = strWindowClass
        If strWndClass = "" Then
            strWndClass = Nothing
        End If

        iWndHandle = Utility.FindWindow(strWndClass, strWndTitle)

        Return iWndHandle

    End Function

    Public Shared Sub MouseClick(ByVal x As Integer, ByVal y As Integer)

        SetCursorPos(x, y)
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)

    End Sub

    Public Shared Sub MouseClick_Right(ByVal x As Integer, ByVal y As Integer)

        SetCursorPos(x, y)
        mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
        mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)

    End Sub

    Public Shared Sub MouseDrag(posClickDown As Point, posClickUp As Point)
        SetCursorPos(posClickDown.X, posClickDown.Y)
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        SetCursorPos(posClickUp.X, posClickUp.Y)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)

    End Sub

    Public Shared Sub MouseWheel(posMouse As Point, iScrollCnt As Integer)

        SetCursorPos(posMouse.X, posMouse.Y)
        ' A positive value indicates that the wheel was rotated forward, away from the user; a negative value indicates that the wheel was rotated backward, toward the user. One wheel click is defined as WHEEL_DELTA, which is 120.
        ' Becase of this reason, need to invert iScrollCnt for rotating toward user in positive value
        mouse_event(MOUSEEVENTF_WHEEL, 0, 0, -WHEEL_DELTA * iScrollCnt, 0)

    End Sub


    Public Shared Function AbsPositionGet(ByVal iWndHandle As Integer, ByVal posRelativePos As Point) As Point

        Dim posAbsPosition As Point = New Point(0, 0)
        Dim rectWnd As Rectangle
        Dim iIsGetRectOK As Integer = 0
        iIsGetRectOK = GetWindowRect(iWndHandle, rectWnd)

        If iIsGetRectOK Then
            posAbsPosition.X = posRelativePos.X + rectWnd.Left
            posAbsPosition.Y = posRelativePos.Y + rectWnd.Top
        Else
            posAbsPosition.X = posRelativePos.X
            posAbsPosition.Y = posRelativePos.Y
        End If

        Return posAbsPosition

    End Function

    Public Shared Function PixelColorGet(ByVal posPixel As Point) As Color

        Dim colorPixel As Color
        Dim iWndColorCode As Integer
        Dim iDC As Integer = GetDC(0)

        iWndColorCode = GetPixel(iDC, posPixel.X, posPixel.Y)
        colorPixel = ColorTranslator.FromWin32(iWndColorCode)
        ReleaseDC(0, iDC)

        Return colorPixel

    End Function

    Public Shared Function DetectColorPosition(posStartPos As Point, sizeImg As Size, colorHiLim As Color, colorLowLim As Color) As Point

        Dim posDetectedPixel As Point = New Point(-1, -1)
        Dim colorPixel As Color
        Dim bmpDetectImg As New Bitmap(sizeImg.Width, sizeImg.Height)
        Dim g As Graphics = Graphics.FromImage(bmpDetectImg)

        g.CopyFromScreen(posStartPos, New Size(0, 0), sizeImg)
        'bmpDetectImg.Save("DetectColorPosition.jpg")

        For iSizeX As Integer = 0 To sizeImg.Width - 1
            For iSizeY As Integer = 0 To sizeImg.Height - 1

                colorPixel = bmpDetectImg.GetPixel(iSizeX, iSizeY)

                If colorPixel.R <= colorHiLim.R _
                    And colorPixel.G <= colorHiLim.G _
                    And colorPixel.B <= colorHiLim.B _
                    And colorPixel.R >= colorLowLim.R _
                    And colorPixel.G >= colorLowLim.G _
                    And colorPixel.B >= colorLowLim.B Then

                    posDetectedPixel.X = posStartPos.X + iSizeX
                    posDetectedPixel.Y = posStartPos.Y + iSizeY

                    g.Dispose()
                    bmpDetectImg.Dispose()

                    Return posDetectedPixel

                End If
            Next
        Next

        g.Dispose()
        bmpDetectImg.Dispose()

        Return posDetectedPixel

    End Function

    Public Shared Sub SaveScreenImage(ByVal posStartPoint As Point, ByVal sizeImg As Size, ByVal strImgName As String)

        Dim bmpDetectImg As New Bitmap(sizeImg.Width, sizeImg.Height)
        Dim g As Graphics = Graphics.FromImage(bmpDetectImg)

        g.CopyFromScreen(posStartPoint, New Point(0, 0), bmpDetectImg.Size)

        bmpDetectImg.Save(strImgName, Imaging.ImageFormat.Jpeg)

        bmpDetectImg.Dispose()
        g.Dispose()

    End Sub

    Public Shared Function Position_Str2Pos(ByVal strPos As String) As Point

        Dim posRet As Point = New Point(0, 0)
        Dim strCoordinate() As String = strPos.Trim("(").Trim(")").Split(",")

        If strCoordinate.Length = 2 Then
            posRet.X = Convert.ToInt32(strCoordinate(0))
            posRet.Y = Convert.ToInt32(strCoordinate(1))
        End If

        Return posRet

    End Function

    Public Shared Function Color_Str2Color(ByVal strColor As String) As Color

        Dim colorRet As Color = Color.FromArgb(0, 0, 0)
        Dim strRGB() As String = strColor.Trim("(").Trim(")").Split(",")

        If strRGB.Length = 3 Then
            colorRet = Color.FromArgb(Convert.ToInt32(strRGB(0)), Convert.ToInt32(strRGB(1)), Convert.ToInt32(strRGB(2)))
        End If

        Return colorRet

    End Function

    Public Shared Sub CreateFolder(ByVal strPath As String)
        If Not System.IO.Directory.Exists(strPath) Then
            System.IO.Directory.CreateDirectory(strPath)
        End If
    End Sub


End Class
