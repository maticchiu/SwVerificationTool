Public Class DetectFormData

    Public Enum CommandCategory

        NONE = -1
        WINDOW
        VARIABLE
        FILE
        SYSTEM
        TOTAL

    End Enum


    Private Shared TabCommand_Window As Dictionary(Of Integer, String)
    Private Shared TabCommand_Variable As Dictionary(Of Integer, String)
    Private Shared TabCommand_File As Dictionary(Of Integer, String)
    Private Shared TabCommand_System As Dictionary(Of Integer, String)


    Public Shared Sub Init()

        Dim Items_Window() As Integer = {MainFormData.CommandType.MOUSE_CLICK, MainFormData.CommandType.MOUSE_CLICK_COLOR, MainFormData.CommandType.MOUSE_CLICK_RIGHT, _
                                         MainFormData.CommandType.MOUSE_DRAG, MainFormData.CommandType.MOUSE_SCROLL, _
                                         MainFormData.CommandType.TYPE_STRING, MainFormData.CommandType.PIXEL_DETECTION, MainFormData.CommandType.IMAGE_DETECTION, _
                                         MainFormData.CommandType.IMAGE_CATCH, MainFormData.CommandType.DELAY, MainFormData.CommandType.WINDOW_SET, _
                                         MainFormData.CommandType.WINDOW_DETECTION, MainFormData.CommandType.EXECUTE}
        Dim Items_Variable() As Integer = {MainFormData.CommandType.VAR_SET, MainFormData.CommandType.VAR_CHECK, MainFormData.CommandType.SVAR_SET, _
                                           MainFormData.CommandType.SVAR_CHECK}
        Dim Items_File() As Integer = {MainFormData.CommandType.FILE_WRITE, MainFormData.CommandType.FILE_APPEND, MainFormData.CommandType.FILE_READ, _
                                       MainFormData.CommandType.FILE_COPY, MainFormData.CommandType.FILE_STRING_CHECK}
        Dim Items_System() As Integer = {MainFormData.CommandType.WATCHDOG_ENABLE, MainFormData.CommandType.WATCHDOG_FEED, MainFormData.CommandType.WATCHDOG_DISABLE, _
                                         MainFormData.CommandType.FORCEABORT_TIMER}

        ' Set items into Dictionaries of Window/Variable/File
        TabCommand_Window = New Dictionary(Of Integer, String)
        For Each item In Items_Window
            TabCommand_Window.Add(item, MainFormData.CommandDict.Item(item))
        Next

        TabCommand_Variable = New Dictionary(Of Integer, String)
        For Each item In Items_Variable
            TabCommand_Variable.Add(item, MainFormData.CommandDict.Item(item))
        Next

        TabCommand_File = New Dictionary(Of Integer, String)
        For Each item In Items_File
            TabCommand_File.Add(item, MainFormData.CommandDict.Item(item))
        Next

        TabCommand_System = New Dictionary(Of Integer, String)
        For Each item In Items_System
            TabCommand_System.Add(item, MainFormData.CommandDict.Item(item))
        Next


        ' Add commands to ComboBox_CommandType
        DetectFormEvent.ComboBox_CommandType.Items.Clear()
        For Each iCommandIndex In TabCommand_Window.Keys
            DetectFormEvent.ComboBox_CommandType.Items.Add(TabCommand_Window.Item(iCommandIndex))
        Next

        For Each iCommandIndex In TabCommand_Variable.Keys
            DetectFormEvent.ComboBox_CommandType.Items.Add(TabCommand_Variable.Item(iCommandIndex))
        Next

        For Each iCommandIndex In TabCommand_File.Keys
            DetectFormEvent.ComboBox_CommandType.Items.Add(TabCommand_File.Item(iCommandIndex))
        Next

        For Each iCommandIndex In TabCommand_System.Keys
            DetectFormEvent.ComboBox_CommandType.Items.Add(TabCommand_System.Item(iCommandIndex))
        Next

    End Sub

    Public Shared Function IsKeyInTabCommand_Window(iKey As Integer) As Boolean

        Return TabCommand_Window.ContainsKey(iKey)

    End Function

    Public Shared Function IsValueInTableCommand_Window(strValue As String) As Boolean

        Return TabCommand_Window.ContainsValue(strValue)

    End Function

    Public Shared Function IsKeyInTabCommand_Variable(iKey As Integer) As Boolean

        Return TabCommand_Variable.ContainsKey(iKey)

    End Function

    Public Shared Function IsValueInTableCommand_Variable(strValue As String) As Boolean

        Return TabCommand_Variable.ContainsValue(strValue)

    End Function

    Public Shared Function IsKeyInTabCommand_File(iKey As Integer) As Boolean

        Return TabCommand_File.ContainsKey(iKey)

    End Function


    Public Shared Function IsValueInTableCommand_File(strValue As String) As Boolean

        Return TabCommand_File.ContainsValue(strValue)

    End Function

    Public Shared Function IsKeyInTabCommand_System(iKey As Integer) As Boolean

        Return TabCommand_System.ContainsKey(iKey)

    End Function

    Public Shared Function IsValueInTableCommand_System(strValue As String) As Boolean

        Return TabCommand_System.ContainsValue(strValue)

    End Function

    Public Shared Function GetCommandCategoryFromCommandType(iCommandType As Integer) As CommandCategory

        Dim iCommandCategory As CommandCategory = CommandCategory.NONE

        If IsKeyInTabCommand_Window(iCommandType) Then
            iCommandCategory = CommandCategory.WINDOW
        ElseIf IsKeyInTabCommand_Variable(iCommandType) Then
            iCommandCategory = CommandCategory.VARIABLE
        ElseIf IsKeyInTabCommand_File(iCommandType) Then
            iCommandCategory = CommandCategory.FILE
        ElseIf IsKeyInTabCommand_System(iCommandType) Then
            iCommandCategory = CommandCategory.SYSTEM
        End If

        Return iCommandCategory

    End Function

End Class
