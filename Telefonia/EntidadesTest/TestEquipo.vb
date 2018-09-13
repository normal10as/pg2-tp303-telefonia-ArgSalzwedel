Imports TelefoniaEntidades

Module TestEquipo

    Sub Main()

        Dim equipo1 As New Equipo("samsung", "s9", "1896")
        equipo1.Vender()
        Console.WriteLine("Marca: " & equipo1.Marca)
        Console.WriteLine("Modelo: " & equipo1.Modelo)
        Console.WriteLine("Serie: " & equipo1.Serie)
        Console.WriteLine("Fecha: " & equipo1.FechaVenta)
        Console.WriteLine("ToString: " & equipo1.tostring)

        Console.ReadLine()
    End Sub


End Module
