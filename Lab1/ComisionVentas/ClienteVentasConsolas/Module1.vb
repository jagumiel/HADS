Module Module1

    Sub Main()
        Dim comision As New ComisionVentas.Ventas
        Console.WriteLine("Introducir Total Ventas")
        Dim tv As Single
        tv = Console.ReadLine
        Console.WriteLine("Introducir Número Ventas")
        Dim nv As Integer
        nv = Console.ReadLine
        Console.Write("Total Comisión:")
        Console.WriteLine(comision.comision(tv, nv))
        Console.WriteLine("Return...")
        Console.ReadLine()
    End Sub

End Module
