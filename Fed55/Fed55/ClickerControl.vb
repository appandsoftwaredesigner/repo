Public Class ClickerControl
    Dim F As New Clicker
    Public Property increment As Integer = 1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        F.increment = increment
        F.click()
        TextBox1.Text = F.count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        F.reset()
        TextBox1.Text = F.count
    End Sub
End Class
