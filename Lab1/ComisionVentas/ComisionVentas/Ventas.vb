Public Class Ventas
    Public Function comision(ByVal tv As Single, ByVal nv As Integer) As Single
        comision = tv * 0.025 + (tv / nv) * 0.05
    End Function
End Class
