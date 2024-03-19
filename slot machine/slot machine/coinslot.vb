Public Class coinslot
    Public Event coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer)
    Public Event buyevent(p As Image)
    Public Property totalmoney As Integer
    Public Property dollarcoin As Integer
    Public Property quarters As Integer
    Public Property dimes As Integer
    Public Property nickels As Integer
    Dim _total As Decimal

    Public ReadOnly Property total As Decimal
        Get
            _total = dollarcoin + quarters * 0.25
            Return _total
        End Get
    End Property

    Sub insertquarters()
        quarters = quarters + 1
    End Sub
    Sub insertdollarcoin()
        dollarcoin = dollarcoin + 1
    End Sub
    Sub insertmoney()
        _total = totalmoney * 10
    End Sub
    Private Sub coinslot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
