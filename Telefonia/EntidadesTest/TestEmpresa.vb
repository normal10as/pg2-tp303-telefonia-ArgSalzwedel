Imports TelefoniaEntidades
Module TestEmpresa

    Sub main()

        Dim empresa1 As New Empresa("granadas Felices", "23-553132581-9", 252317837)

        Console.WriteLine("Razonsocial: " & empresa1.razonsocial)
        Console.WriteLine("Cuit: " & empresa1.cuit)

        Console.WriteLine("tostring: " & empresa1.tostring)

        Console.ReadKey()
    End Sub
End Module
