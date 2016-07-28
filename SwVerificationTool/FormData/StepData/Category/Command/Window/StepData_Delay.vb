Public Class StepData_Delay
    Inherits StepDataItem
    Implements StepDataParam

    Public Function GetParam1() As String Implements StepDataParam.GetParam1
        Return DetectFormEvent.TextBox_Delay.Text
    End Function

    Public Function GetParam2() As String Implements StepDataParam.GetParam2
        Return ""
    End Function

    Public Function GetParam3() As String Implements StepDataParam.GetParam3
        Return ""
    End Function

    Public Function GetParam4() As String Implements StepDataParam.GetParam4
        Return ""
    End Function

    Public Function GetParam5() As String Implements StepDataParam.GetParam5
        Return ""
    End Function

End Class
