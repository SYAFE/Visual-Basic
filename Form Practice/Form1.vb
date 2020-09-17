Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clock.Text = "現在時間：" & TimeOfDay
    End Sub

    Private Sub BtOK_Click(sender As Object, e As EventArgs) Handles BtOK.Click
        Textbox.Text = "OK"
    End Sub

    Private Sub BtCC_Click(sender As Object, e As EventArgs) Handles BtCC.Click
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Clock.Text = "現在時間：" & TimeOfDay
    End Sub
End Class
