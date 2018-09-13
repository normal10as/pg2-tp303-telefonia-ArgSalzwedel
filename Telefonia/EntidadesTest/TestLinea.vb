Imports TelefoniaEntidades
Module TestLinea
    Sub main()
        Dim linea1 As New Linea("3755", "21075899")
        linea1.Suspender()
        Console.WriteLine(linea1.Area)
        Console.WriteLine(linea1.Numero)
        Console.WriteLine(linea1.Estado)
        Console.WriteLine(linea1.tostring())

        Dim linea2 As New Linea("3752", "75522588")
        linea2.Reactivar()
        Console.WriteLine(linea1.Area)
        Console.WriteLine(linea1.Numero)
        Console.WriteLine(linea2.Estado)
        Console.WriteLine(linea2.tostring())

        Console.ReadLine()

    End Sub
End Module
