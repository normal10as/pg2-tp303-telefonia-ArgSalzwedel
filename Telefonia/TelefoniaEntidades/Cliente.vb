Public Class Cliente
    Private _cuenta As UInteger

    Public Sub New(Cuenta As UInteger)
        Me._cuenta = Cuenta



    End Sub
    Public Property cuenta()
        Get
            Return _cuenta
        End Get
        Set(value)
            _cuenta = value
        End Set
    End Property
End Class
