Public Class reel_control
    Public Property itemvalue As Integer
    Public Property spintime As Integer = 2000
    Dim rand As New Random
    Private Sub reel_control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Interval = spintime
    End Sub
    Public Sub spin()
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim r As Integer
        r = rand.Next(ImageList1.Images.Count)
        PictureBox1.Image = ImageList1.Images(r)
        itemvalue = r
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer1.Enabled = False
        Timer2.Enabled = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
