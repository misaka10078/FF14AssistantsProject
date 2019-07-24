Public Class Form_Main
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub tab_click(sender As Object, e As EventArgs) Handles TabControl1.Selected
        'Me.TextBox_Output.CreateGraphics()
        Me.TextBox_Output.SelectionStart = Len(Me.TextBox_Output.Text)
        Me.TextBox_Output.ScrollToCaret() '此处将输出文本框定位到末尾位置

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MessageBox.Show("hello")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Common.Output(2， "123", 0)
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Common.Do_Output(2， "123", 1)
    End Sub

    Private Sub CheckBox_Output_level_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Output_level.CheckedChanged
        If CheckBox_Output_level.Checked = True Then
            My.Settings.Output_Level = 1
        Else
            My.Settings.Output_Level = 0
        End If
    End Sub



    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim esk As New Mission_Class
        Dim Thread As New System.Threading.Thread(AddressOf esk.Start)
        Thread.Start()
    End Sub
End Class
Public Class Mission_Class
    Sub Start()
        Call Test()
    End Sub
End Class