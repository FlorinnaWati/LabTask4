Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form4.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Form3.Show()
    End Sub

    Private Sub txtemail_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
    End Sub
End Class