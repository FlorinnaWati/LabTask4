Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'L4DataSet3.restaurant' table. You can move, or remove it, as needed.
        Me.RestaurantTableAdapter.Fill(Me.L4DataSet3.restaurant)
        'TODO: This line of code loads data into the 'DunhilDataSet.login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.DunhilDataSet.login)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form6.Show()
    End Sub
End Class