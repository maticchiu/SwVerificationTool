Public Class MainFormData

    Public Enum CommandType

        NONE = -1
        MOUSE_CLICK = 0
        MOUSE_CLICK_COLOR
        MOUSE_CLICK_RIGHT
        MOUSE_SCROLL
        MOUSE_DRAG
        TYPE_STRING
        PIXEL_DETECTION
        IMAGE_DETECTION
        IMAGE_CATCH
        DELAY
        WINDOW_SET
        WINDOW_DETECTION
        EXECUTE
        VAR_SET
        SVAR_SET
        VAR_CHECK
        SVAR_CHECK
        FILE_WRITE
        FILE_APPEND
        FILE_READ
        FILE_COPY
        FILE_STRING_CHECK
        WATCHDOG_ENABLE
        WATCHDOG_FEED
        WATCHDOG_DISABLE
        FORCEABORT_TIMER
        TOTAL

    End Enum

    Public Enum ParamNum
        PARAM1 = 1
        PARAM2
        PARAM3
        PARAM4
        PARAM5
    End Enum


    Public Enum EditColumn

        STEP_NUM
        STEP_NAME
        COMMAND_TYPE
        NEXT_STEP
        LAST_STEP
        PARAM1
        PARAM2
        PARAM3
        PARAM4
        PARAM5
        DELAY

    End Enum

    Public Enum ScriptColumn

        SCRIPT_NUM
        SCRIPT_NAME
        NEXT_SCRIPT
        TIME_SCRIPT
        TOTAL

    End Enum

    Public Enum WatchDogIndex

        WATCHDOG_0
        WATCHDOG_1
        WATCHDOG_2
        WATCHDOG_3
        WATCHDOG_4
        WATCHDOG_5
        WATCHDOG_6
        WATCHDOG_7
        WATCHDOG_8
        WATCHDOG_9
        WATCHDOG_TOTAL

    End Enum

    Public Shared giStepInfoDataVersion As Integer = 1

    Public Shared CommandDict As Dictionary(Of Integer, String)
    Private Shared gadVAR(10) As Double
    Private Shared gastrSVAR(10) As String

    Public Shared Sub Init()

        ' Just create Dictionary in MainformData.vb. This dictionary will be often used in DetectFormData.vb.
        CommandDict = New Dictionary(Of Integer, String)
        CommandDict.Add(CommandType.MOUSE_CLICK, "Mouse Click")
        CommandDict.Add(CommandType.MOUSE_CLICK_COLOR, "Mouse Click(Color)")
        CommandDict.Add(CommandType.MOUSE_CLICK_RIGHT, "Mouse Click Right")
        CommandDict.Add(CommandType.MOUSE_SCROLL, "Mouse Scroll")
        CommandDict.Add(CommandType.MOUSE_DRAG, "Mouse Drag")
        CommandDict.Add(CommandType.TYPE_STRING, "Type String")
        CommandDict.Add(CommandType.PIXEL_DETECTION, "Pixel Detection")
        CommandDict.Add(CommandType.IMAGE_DETECTION, "Image Detection")
        CommandDict.Add(CommandType.IMAGE_CATCH, "Image Catch")
        CommandDict.Add(CommandType.DELAY, "Delay")
        CommandDict.Add(CommandType.WINDOW_SET, "Window Set")
        CommandDict.Add(CommandType.WINDOW_DETECTION, "Window Detection")
        CommandDict.Add(CommandType.EXECUTE, "Execute")
        CommandDict.Add(CommandType.VAR_SET, "VAR Set")
        CommandDict.Add(CommandType.VAR_CHECK, "VAR Check")
        CommandDict.Add(CommandType.SVAR_SET, "SVAR Set")
        CommandDict.Add(CommandType.SVAR_CHECK, "SVAR Check")

        CommandDict.Add(CommandType.FILE_WRITE, "File Write")
        CommandDict.Add(CommandType.FILE_APPEND, "File Append")
        CommandDict.Add(CommandType.FILE_READ, "File Read")
        CommandDict.Add(CommandType.FILE_COPY, "File Copy")
        CommandDict.Add(CommandType.FILE_STRING_CHECK, "File String Check")

        CommandDict.Add(CommandType.WATCHDOG_ENABLE, "WatchDog Enable")
        CommandDict.Add(CommandType.WATCHDOG_FEED, "WatchDog Feed")
        CommandDict.Add(CommandType.WATCHDOG_DISABLE, "WatchDog Disable")
        CommandDict.Add(CommandType.FORCEABORT_TIMER, "Force Abort Timer")

    End Sub

    Public Shared Sub VarInit()
        For Each dVAR In gadVAR
            dVAR = 0
        Next
    End Sub

    Public Shared Sub SvarInit()
        For Each strSVAR In gastrSVAR
            strSVAR = ""
        Next
    End Sub

    Public Shared Property VAR(ByVal VarIndex As Integer) As Double

        Get
            Return gadVAR(VarIndex)
        End Get
        Set(value As Double)
            gadVAR(VarIndex) = value
        End Set

    End Property

    Public Shared Property SVAR(ByVal SvarIndex As Integer) As String
        Get
            Return gastrSVAR(SvarIndex)
        End Get
        Set(value As String)
            gastrSVAR(SvarIndex) = value
        End Set
    End Property

    Public Shared Function GetCommandTypeIndex(ByVal strCommandType As String) As Integer

        Dim iCommandTypeIndex As Integer = CommandType.NONE

        For Each i As Integer In CommandDict.Keys
            If CommandDict.Item(i) = strCommandType Then
                Return i
            End If
        Next

        Return iCommandTypeIndex

    End Function

    Public Shared Function GetCommandTypeString(iCommandType As Integer) As String
        Return CommandDict.Item(iCommandType)
    End Function

    Public Shared Function IsStepNumExist(ByVal iStepNum As Integer) As Boolean

        For i As Integer = 0 To MainFormEvent.DataGridView_StepEdit.RowCount - 1

            If iStepNum = Math.Abs(Convert.ToInt32(MainFormEvent.DataGridView_StepEdit.Rows(i).Cells(EditColumn.STEP_NUM).Value)) Then
                Return True
            End If

        Next

        Return False

    End Function

    Public Shared Function IsScriptNumExist(ByVal iScriptNum As Integer) As Boolean

        For i As Integer = 0 To MainFormEvent.DataGridView_Sequence.RowCount - 1

            If iScriptNum = Convert.ToInt32(MainFormEvent.DataGridView_Sequence.Rows(i).Cells(ScriptColumn.SCRIPT_NUM).Value) Then
                Return True
            End If

        Next

        Return False

    End Function

    Public Shared Sub SetStepInfoFromDataGridView()

        AppStepInfo.SetDataFromDataGridView()

    End Sub

    Public Shared Sub SetScriptInfoFromDataGridView()

        AppScriptInfo.SetDataFromDataGridView()

    End Sub

    Public Shared Function GetStepInfoData(ByVal iDataIndex As Integer) As StepDataBase 'StepDataBase
        Return AppStepInfo.GetData(iDataIndex)
    End Function

    Public Shared Function GetScriptInfoData(ByVal iDataIndex As Integer) As AppScriptInfo.Script_Info
        Return AppScriptInfo.GetData(iDataIndex)
    End Function

    Public Shared Function GetStepInfoLength() As Integer
        ' involve stepinfo(0) which is empty
        Return AppStepInfo.GetLength()
    End Function

    Public Shared Function GetScriptInfoLength() As Integer
        Return AppScriptInfo.GetLength()
    End Function

    Public Shared Sub SetScriptInfoData_bIsSkip(ByVal iDataIndex As Integer, ByVal bIsSkip As Boolean)
        AppScriptInfo.SetData_bIsSkip(iDataIndex, bIsSkip)
    End Sub

    Public Shared Function SetListIntoComboBox(ByVal strFilePath As String, ByRef eComboBox As ComboBox) As Boolean
        Dim bListExist As Boolean = False
        If My.Computer.FileSystem.FileExists(strFilePath) Then
            Dim fScriptList As New System.IO.StreamReader(strFilePath)
            Dim strScriptList() As String = fScriptList.ReadToEnd.Replace(vbNewLine, ";").Trim(";").Split(";")
            eComboBox.Items.AddRange(strScriptList)
            fScriptList.Close()
            bListExist = True
            'Else
            '    MessageBox.Show("The script list (" + strFilePath + ") doesn't exist.")
        End If
        Return bListExist
    End Function

    Public Shared Sub SaveScript(ByVal strScriptFullPath As String)
        Dim fScriptSave As New System.IO.StreamWriter(strScriptFullPath)
        Dim sWriteData As String = ""

        fScriptSave.Write("# Version = " & giStepInfoDataVersion.ToString.PadLeft(4, "0") & vbNewLine & vbNewLine)

        For iRowIndex As Integer = 0 To MainFormEvent.DataGridView_StepEdit.RowCount - 2

            sWriteData = MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.STEP_NUM).Value.ToString + vbTab _
                        + MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.STEP_NAME).Value.ToString + vbTab _
                        + MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.COMMAND_TYPE).Value.ToString + vbTab _
                        + MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.NEXT_STEP).Value.ToString + vbTab _
                        + MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.LAST_STEP).Value.ToString + vbTab _
                        + MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM1).Value.ToString + vbTab _
                        + MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM2).Value.ToString + vbTab _
                        + MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM3).Value.ToString + vbTab _
                        + MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM4).Value.ToString + vbTab _
                        + MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.PARAM5).Value.ToString + vbTab _
                        + MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(MainFormData.EditColumn.DELAY).Value.ToString

            fScriptSave.WriteLine(sWriteData)
        Next

        fScriptSave.Close()
    End Sub

    Public Shared Sub SaveSequence(ByVal strSequentialFullPath As String)
        Dim fSequentialSave As New System.IO.StreamWriter(strSequentialFullPath)
        Dim sWriteData As String = ""

        For iRowIndex As Integer = 0 To MainFormEvent.DataGridView_Sequence.RowCount - 2

            sWriteData = MainFormEvent.DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.SCRIPT_NUM).Value.ToString + vbTab _
                                  + MainFormEvent.DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.SCRIPT_NAME).Value.ToString + vbTab _
                                  + MainFormEvent.DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.NEXT_SCRIPT).Value.ToString + vbTab _
                                  + MainFormEvent.DataGridView_Sequence.Rows(iRowIndex).Cells(MainFormData.ScriptColumn.TIME_SCRIPT).Value.ToString

            fSequentialSave.WriteLine(sWriteData)
        Next

        fSequentialSave.Close()
    End Sub

    Public Shared Sub LoadScriptFromFile(ByVal strScriptFullPath As String)
        MainFormEvent.DataGridView_StepEdit.Rows.Clear()

        Dim fScriptLoad As New System.IO.StreamReader(strScriptFullPath)
        Dim strStepItems() As String
        Dim strOneLineData As String = ""
        Dim iRowIndex As Integer = 0

        Do While fScriptLoad.Peek >= 0
            strOneLineData = fScriptLoad.ReadLine

            If strOneLineData.Length < 3 Then
                Continue Do
            End If

            If strOneLineData.Chars(0) = "#" Then
                Continue Do
            End If

            strStepItems = strOneLineData.Split(vbTab)
            MainFormEvent.DataGridView_StepEdit.Rows.Insert(iRowIndex, strStepItems)
            If Convert.ToInt32(MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).Cells(EditColumn.STEP_NUM).Value) < 0 Then
                MainFormEvent.DataGridView_StepEdit.Rows(iRowIndex).DefaultCellStyle.BackColor = Color.GreenYellow
            End If
            iRowIndex = iRowIndex + 1

        Loop

        fScriptLoad.Close()
    End Sub

    Public Shared Sub SaveListIntoFile(ByVal strScriptFullPath As String, ByVal ComboBoxTmp As ComboBox)
        Dim fScriptList As New System.IO.StreamWriter(strScriptFullPath)

        For Each strName As String In ComboBoxTmp.Items
            fScriptList.WriteLine(strName)
        Next

        fScriptList.Close()
    End Sub

    Public Shared Sub LoadSequentialFromFile(ByVal strSequentialFullPath As String)
        Dim fSequentialLoad As New System.IO.StreamReader(strSequentialFullPath)
        Dim strSequentialItems() As String
        Dim iRowIndex As Integer = 0

        Do While fSequentialLoad.Peek >= 0

            strSequentialItems = fSequentialLoad.ReadLine.Split(vbTab)
            MainFormEvent.DataGridView_Sequence.Rows.Insert(iRowIndex, strSequentialItems)
            iRowIndex = iRowIndex + 1

        Loop

        fSequentialLoad.Close()
    End Sub

End Class
