Public Class Common
    Public Overloads Shared Sub Do_Output(ByVal type As Integer, ByVal Text As String, ByVal Level As Integer)
        Dim TypeText As String
        If Level <= My.Settings.Output_Level Then '该消息输出等级小于等于当前设定的输出等级时才输出
            If type = 1 Then
                TypeText = "错误"
            ElseIf type = 2 Then
                TypeText = "重要"
            ElseIf type = 3 Then
                TypeText = "信息"
            End If
            Debug.Print("[" & TypeText & "]" & Text) '调试输出
            Form_Main.TextBox_Output.Text = (Form_Main.TextBox_Output.Text &
                "[" & TimeOfDay & "]" & ":" & "[" & TypeText & "]" & Text & vbCrLf) '输出文本

            Form_Main.TextBox_Output.SelectionStart = Len(Form_Main.TextBox_Output.Text)
            Form_Main.TextBox_Output.ScrollToCaret() '此处将输出文本框定位到末尾位置

        End If
    End Sub '实行日志输出的函数，text为输出的文本，type为输出文本的类型，level为输出优先级
    'type1为错误信息，2为重要输出，3为正常输出
    '0为最重要4为最不重要

    Public Overloads Shared Sub Do_Output(ByVal Text As String)
        Debug.Print("[信息]" & Text) '调试输出
        Form_Main.TextBox_Output.Text = (Form_Main.TextBox_Output.Text &
            "[" & TimeOfDay & "]" & "：" & "[信息]" & Text & vbCrLf) '输出文本

        Form_Main.TextBox_Output.SelectionStart = Len(Form_Main.TextBox_Output.Text)
        Form_Main.TextBox_Output.ScrollToCaret() '此处将输出文本框定位到末尾位置

    End Sub '日志输出的重载简便方法，默认类型为信息，无视输出等级始终输出
End Class
