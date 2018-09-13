Public Class Marca
    Private _Nombre As String = "30"

    Public Sub New(Nombre As String)

        Me.Marca = Nombre

    End Sub
    Public Property Marca() As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            If value = " " Then
                Console.WriteLine("el tamanio excede el permitido")
            End If
            If value.Length < (30) Then
                _Nombre = value
            Else console.WriteLine("el tamanio excede el permitido")
            End If

        End Set

    End Property
    Public Overridable Function ToString() As String
        Return Marca


    End Function
End Class
