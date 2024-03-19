Public Class Clicker
    Public Property count As Integer
<<<<<<< HEAD
    Public Property increment As Integer = 1
    Public Sub click()
        count = count + increment
=======
    Public Sub click()
        count = count + 1
>>>>>>> main
    End Sub
    Public Sub reset()
        count = 0
    End Sub

End Class
