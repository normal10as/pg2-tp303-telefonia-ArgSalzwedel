﻿
Public Class Persona
    Inherits Cliente
    Private _apellido As String
    Private _nombre As String
    Private _documento As UInteger

    Public Sub New(apellido As String, nombre As String, documento As UInteger, cuenta As UInteger)
        MyBase.New(cuenta)
        Me.Apellido = apellido
        Me.Nombre = nombre
        Me.Documento = documento

    End Sub

    Public Property Apellido() As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property Documento() As UInteger
        Get
            Return _documento
        End Get
        Set(value As UInteger)
            _documento = value
        End Set
    End Property
    Public Function tostring()
        Return Apellido & " " & Nombre & " " & Documento & " " & cuenta

    End Function
End Class
