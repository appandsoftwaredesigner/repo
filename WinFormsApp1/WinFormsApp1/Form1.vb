Public Class frm2dplatformer
    Dim movespeed As Integer = 15
    Dim isjumping As Boolean
    Dim score As Integer
    Private Sub frm2dplatformer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TmrGameLogic.Start()
    End Sub

    Private Sub frm2dplatformer_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                TmrRight.Start()
            Case Keys.Up
                TmrUp.Start()
            Case Keys.Left
                TmrLeft.Start()
                isjumping = True
        End Select
    End Sub

    Private Sub TmrRight_Tick(sender As Object, e As EventArgs) Handles TmrRight.Tick
        PicPlayer.Left += movespeed
    End Sub

    Private Sub frm2dplatformer_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                TmrRight.Stop()
            Case Keys.Up
                TmrUp.Stop()
            Case Keys.Left
                TmrLeft.Stop()
                isjumping = False
        End Select
    End Sub

    Private Sub TmrLeft_Tick(sender As Object, e As EventArgs) Handles TmrLeft.Tick
        PicPlayer.Left -= movespeed
    End Sub

    Private Sub TmrUp_Tick(sender As Object, e As EventArgs) Handles TmrUp.Tick
        PicPlayer.Top -= movespeed
    End Sub

    Private Sub TmrGameLogic_Tick(sender As Object, e As EventArgs) Handles TmrGameLogic.Tick
        If PicPlayer.Bounds.IntersectsWith(PicAir.Bounds) Then
            If isjumping = False Then
                TmrGravity.Start()
            End If
        ElseIf PicPlayer.Bounds.IntersectsWith(PicGround.bounds) Then
            TmrGravity.Stop()
        End If
        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "Bound" Then
                    If PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        TmrGravity.Stop()
                    End If
                End If
            End If
            If PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                If b.Tag = "coin" Then
                    b.Visible = False
                End If
            End If
            If PictureBox4.Visible = False And PictureBox5.Visible = False And PictureBox6.Visible = False And PictureBox7.Visible = False Then
                If b.Tag = "coin" Then
                    PictureBox4.Visible = True
                    PictureBox5.Visible = True
                    PictureBox6.Visible = True
                    PictureBox7.Visible = True
                    score = score + 1
                    Label1.Text = score
                End If
            End If

        Next
    End Sub

    Private Sub TmrGravity_Tick(sender As Object, e As EventArgs) Handles TmrGravity.Tick
        PicPlayer.Top += movespeed
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PicAir_Click(sender As Object, e As EventArgs) Handles PicAir.Click

    End Sub

    Private Sub Mover1_Load(sender As Object, e As EventArgs) Handles Mover1.Load

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class
