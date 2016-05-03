Public Class IVA
    Public Function calculoIVA(ByVal precio As Single, ByVal tipo As Single) As Single
        calculoIVA = (precio * tipo) / 100
    End Function

    Public Function obtenerDatos(ByVal id As Integer) As Integer()
        Dim resul(1) As Integer
        resul(0) = 2000
        resul(1) = 10
        If id = 121212 Then
            resul(0) = 1000
            resul(1) = 21
        End If
        obtenerDatos = resul
    End Function
End Class
