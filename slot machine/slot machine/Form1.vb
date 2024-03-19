Public Class Form1
    Dim WithEvents cs As New coinslot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = Not Timer1.Enabled
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = True
        If cs.total >= 2 Then
            Reel_control4.spin()
            Reel_control5.spin()
            Reel_control6.spin()
            Label1.Text = Reel_control4.itemvalue
            Label2.Text = Reel_control5.itemvalue
            Label3.Text = Reel_control6.itemvalue
            Label4.Text = cs.totalmoney.ToString("c2")
            BackColor = Color.White
        Else

            BackColor = Color.Maroon
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertquarters()
        Label4.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertdollarcoin()
        Label4.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Reel_control4.itemvalue
        Label2.Text = Reel_control5.itemvalue
        Label3.Text = Reel_control6.itemvalue
        Timer1.Enabled = False
        If Reel_control4.itemvalue = Reel_control5.itemvalue And
                Reel_control5.itemvalue = Reel_control6.itemvalue Then
            BackColor = Color.Green
            Label4.Text = "$20.00"


        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
