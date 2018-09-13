Public Class Modelo
    Inherits Marca
    Private _Nombre As String

    Public Sub New(Marca As String, Modelo As String)
        MyBase.New(Marca)
        Me.Modelo = Modelo

    End Sub
    Public Property Modelo() As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set

    End Property
    Public Overridable Function tostring() As String
        Return Marca & Modelo


    End Function


End Class
