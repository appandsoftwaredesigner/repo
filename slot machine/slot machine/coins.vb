Public Class coins
    Public Event coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer)
    Public Event buyevent(p As Image)

    Public Property dollarcoin As Integer
    Public Property quarters As Integer
    Public Property dimes As Integer
    Public Property nickels As Integer
    Dim _total As Decimal
    Public ReadOnly Property total As Decimal
        Get
            _total = dollarcoin + quarters * 0.25 + dimes * 0.1 + nickels * 0.05
            Return _total
        End Get
    End Property


    Sub coinreturn()
        RaiseEvent coinreturnevent(dollarcoin, quarters, dimes, nickels)
        dollarcoin = 0
        nickels = 0
        dimes = 0
        quarters = 0

    End Sub

    Sub insertquarters()
        quarters = quarters + 1
    End Sub
    Sub insertdimes()
        dimes = dimes + 1
    End Sub
    Sub insertdollarcoin()
        dollarcoin = dollarcoin + 1
    End Sub
    Sub insertnickels()
        nickels = nickels + 1
    End Sub

End Class
