Public Class Empresa
    Inherits Cliente
    Private _razonsocial As String
    Private _cuit As String

    Public Sub New(razonsocial As String, cuit As String, cuenta As UInteger)
        MyBase.New(cuenta)
        Me.razonsocial = razonsocial
        Me.cuit = cuit
    End Sub
    Public Property razonsocial
        Get

            Return _razonsocial
        End Get
        Set(value)
            _razonsocial = value
        End Set
    End Property
    Public Property cuit
        Get
            Return _cuit
        End Get
        Set(value)
            _cuit = value
        End Set
    End Property
    Public Function tostring()
        Return razonsocial & " " & cuenta
    End Function
End Class
