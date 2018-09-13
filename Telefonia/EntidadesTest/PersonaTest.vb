Imports TelefoniaEntidades
Module PersonaTest
    Sub main()

        Dim persona1 As New Persona("Balanda", "Nate", 27588986, 555889958)

        Console.WriteLine("Apellido: " & persona1.Apellido)
        Console.WriteLine("Nombre: " & persona1.Nombre)
        Console.WriteLine("Documento: " & persona1.Documento)
        Console.WriteLine("tostring: " & persona1.tostring)
        Console.ReadKey()

    End Sub
End Module
