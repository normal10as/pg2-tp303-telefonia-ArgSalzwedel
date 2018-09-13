Public Class Equipo
    Inherits Modelo

    Private _Serie As String
    Private _FechadeVenta As Date



    Public Sub New(Marca As String, Modelo As String, Serie As String)
        MyBase.New(Marca, Modelo)
        Me.Serie = Serie

    End Sub
    Public Property Serie() As String
        Get
            Return _Serie
        End Get
        Set(value As String)
            _Serie = value
        End Set
    End Property
    Public ReadOnly Property FechaVenta() As Date
        Get
            Return _FechadeVenta
        End Get
    End Property
    Public Overridable Function tostring() As String
        Return Marca & " " & Modelo & " " & Serie
    End Function
    Public Sub Vender()
        _FechadeVenta = Date.Now
    End Sub

End Class

