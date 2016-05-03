Imports System.Threading

Module Module1

    Sub Main()
        Dim miCalculo As New IVA.IVA
        Dim tipo As Integer
        Dim precio As Single
        Dim porcentaje As Single
        Dim repetir As Boolean = False
        Dim comprobar As Boolean = False
        Dim respuesta As Char = "T"
        porcentaje = 0
        Dim iva As Single
        Console.WriteLine("")
        Console.WriteLine("      Averigüe el valor de su I.V.A       ")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("¿Quiere introducir su ID.  (S/N) ")
        Dim eleccion As Char = "T"
        eleccion = Console.ReadLine
        If metodoComprobar(eleccion) Then
            Dim id As Integer
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("Introduzca un ID")
            Console.WriteLine("")
            Console.WriteLine("")
            id = Console.ReadLine
            If id = 121212 Then
                precio = 1000
                porcentaje = 21
            Else
                precio = 2000
                porcentaje = 10
            End If
        Else
            Console.WriteLine("Introduzca una cantidad monetaria.  ")
            precio = 0


            While precio = 0
                Try
                    precio = Console.ReadLine
                    If precio = 0 Then
                        Console.WriteLine("Introduzca una cantidad monetaria.  ")
                    End If
                Catch ex As Exception
                    Console.WriteLine("Cantidad/Valor erronea, intentelo de nuevo")
                End Try
            End While
            Console.WriteLine("Introducir IVA")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("1.-General (21%)")
            Console.WriteLine("2.-Reducido (10%)")
            Console.WriteLine("3.-Super reducido (4%)")
            Console.WriteLine("Introduzca un numero asociado con las opciones anteriores")
            While porcentaje = 0
                Try
                    tipo = Console.ReadLine
                    If tipo = 1 Then
                        porcentaje = 21
                    ElseIf tipo = 2 Then
                        porcentaje = 10
                    ElseIf tipo = 3 Then
                        porcentaje = 4
                    Else
                        Console.WriteLine("No ha introducido un tipo válido. Introduzca un número entre 1 y 3.")
                        Console.WriteLine(" ")
                    End If
                Catch ex As Exception
                    Console.WriteLine("No ha introducido un tipo válido. Introduzca un número entre 1 y 3.")

                End Try
            End While
        End If

        iva = miCalculo.calculoIVA(precio, porcentaje)
        Console.WriteLine(" ")
        Console.Write("Parte del I.V.A:    ")
        Console.WriteLine(iva)
        Console.WriteLine(" ")
        Console.Write("Precio sin IVA:    ")
        Console.WriteLine(precio - iva)
        Console.WriteLine(" ")
        Console.WriteLine("¿Desea hacer otro cálculo? (S/N)")
        While comprobar = False
            respuesta = Console.ReadLine
            If respuesta = "S" Or respuesta = "s" Then
                repetir = True
                comprobar = True
            ElseIf respuesta = "N" Or respuesta = "n" Then
                repetir = False
                comprobar = True
            Else
                Console.WriteLine("Introduzca un valor válido.")
            End If
        End While
        If repetir Then
            Console.Clear()
            Main()
            Exit Sub
        Else
            Exit Sub
        End If
        Console.WriteLine("Return...")
        Console.ReadLine()

    End Sub

    Public Function metodoComprobar(ByVal respuesta As Char) As Boolean
        Dim chivato As Boolean = False
        Dim i As Integer = 0
        While chivato <> True And i < 3
            Try
                If respuesta = "S" Or respuesta = "s" Then
                    chivato = True
                    metodoComprobar = True
                ElseIf respuesta = "N" Or respuesta = "n" Then
                    chivato = True
                    metodoComprobar = False
                    'Else
                    '   Console.WriteLine("Introduzca un valor válido.")
                End If
            Catch ex As Exception
            End Try
            Console.WriteLine("Introduzca un valor válido.")
            respuesta = Console.ReadLine
            i = i + 1
        End While
        If i = 3 Then
            Console.WriteLine("Ha superado el número de intentos. Saliendo.")
            Thread.Sleep(2000)
            Environment.Exit(0)
        End If
        Return metodoComprobar
    End Function




End Module
