Public Class Form_Main
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MessageBox.Show("hello")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Common.Do_Output(2， "123", 0)
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Common.Do_Output(2， "123", 1)
    End Sub

    Private Sub CheckBox_Output_level_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Output_level.CheckedChanged
        If CheckBox_Output_level.Checked = True Then
            My.Settings.Output_Level = 0
        Else
            My.Settings.Output_Level = 1
        End If
    End Sub
End Class
