Public Class Form1
    Dim WithEvents cs As New coinslot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cs.insertdimes()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertnickels()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertquarters()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertdollarcoin()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.coinreturn()
        Label1.Text = cs.total.ToString("c2")
    End Sub
    Private Sub cs_coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer) Handles cs.coinreturnevent
        If d > 0 Then
            DollarCoinPB.Visible = True
        Else
            DollarCoinPB.Visible = False
        End If
        If q > 0 Then
            QuarterPB.Visible = True
        Else
            QuarterPB.Visible = False
        End If
        If di > 0 Then
            DimePB.Visible = True
        Else
            DimePB.Visible = False
        End If
        If n > 0 Then
            NicklePB.Visible = True
        Else
            NicklePB.Visible = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case IDtextbox.Text
            Case Product_control1.productid
                cs.buy(Product_control1)
            Case Product_control2.productid
                cs.buy(Product_control2)
            Case Product_control3.productid
                cs.buy(Product_control3)
            Case Product_control4.productid
                cs.buy(Product_control4)
            Case Product_control5.productid
                cs.buy(Product_control5)
            Case Product_control6.productid
                cs.buy(Product_control6)
            Case Product_control7.productid
                cs.buy(Product_control7)
            Case Product_control8.productid
                cs.buy(Product_control8)
            Case Product_control9.productid
                cs.buy(Product_control9)
            Case Product_control10.productid
                cs.buy(Product_control10)
            Case Product_control11.productid
                cs.buy(Product_control11)
            Case Product_control12.productid
                cs.buy(Product_control12)
            Case Product_control13.productid
                cs.buy(Product_control13)
            Case Product_control14.productid
                cs.buy(Product_control14)
            Case Product_control15.productid
                cs.buy(Product_control15)
            Case Product_control16.productid
                cs.buy(Product_control16)



            Case 2


            Case Else



        End Select
        Label1.Text = cs.total.ToString("c2")

    End Sub

    Private Sub cs_buyevent(p As Image) Handles cs.buyevent
        productpicture.Image = p
    End Sub
End Class
