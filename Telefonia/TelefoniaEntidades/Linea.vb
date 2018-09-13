Public Class Linea

    Private _codArea As UShort
    Private _Numero As UInteger
    Private _Estado As String

    Public Sub New(Area As UShort, Numero As UInteger)

        Me.Area = Area
        Me.Numero = Numero
    End Sub

    Public Property Area As UShort
        Get
            Return _codArea
        End Get
        Set(value As UShort)
            _codArea = value

        End Set
    End Property

    Public Property Numero As UInteger
        Get
            Return _Numero
        End Get
        Set(value As UInteger)
            _Numero = value
        End Set
    End Property
    Public ReadOnly Property Estado As String
        Get
            Return _Estado
        End Get
    End Property

    Public Sub Suspender()
        _Estado = "Linea suspendida"

    End Sub
    Public Sub Reactivar()

        _Estado = "Linea Activa"
    End Sub
    Public Function tostring()
        If _Estado = "Linea suspendida" Then
            Return Area & " " & Numero & Estado
        ElseIf _Estado = "Linea Activa" Then
            Return Area & " " & Numero
        End If




    End Function

End Class
