Public Class Form1
<<<<<<< HEAD

=======
    Dim c As New Clicker
    Dim d As New Clicker


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ClickButton.Click
        c.click()
        TextBox1.Text = c.count
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        c.reset()
        TextBox1.Text = c.count
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        d.click()
        TextBox2.Text = d.count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        d.reset()
        TextBox2.Text = d.count
    End Sub
>>>>>>> main
End Class
