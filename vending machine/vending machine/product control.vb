Public Class product_control
    Public Property productid As String
    Public Property productprice As Decimal
    Public Property productpicture As Image
    Public Property productcount As Integer

    Private Sub product_control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDlabel.Text = productid
        PriceLabel.Text = productprice.ToString("c2")
        PictureBox1.Image = productpicture
    End Sub
    Sub buy()
        If productcount > 0 Then
            productcount = productcount - 1
        End If
        If productcount = Nothing Then
            PictureBox1.Visible = False
        End If

    End Sub
End Class
