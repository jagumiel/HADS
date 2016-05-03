Public Class Form1

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim miCalculo As New IVA.IVA
        Dim precio As Single
        Dim tipo As String
        Dim IVA As Single
        Dim porcentaje As Single
        Try
            precio = TextBox1.Text
            porcentaje = 0
            tipo = ComboBox1.Text
            If tipo = "General" Then
                porcentaje = 21
            ElseIf tipo = "Reducido" Then
                porcentaje = 10
            ElseIf tipo = "Super reducido" Then
                porcentaje = 4
            Else
                MessageBox.Show("Introduzca un tipo válido")
            End If
            IVA = miCalculo.calculoIVA(precio, porcentaje)
            TextBox3.Text = IVA
            TextBox4.Text = (precio - IVA)
        Catch ex As Exception
            MessageBox.Show("Introduzca un precio válido")
        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim misDatos As New IVA.IVA
        Dim IVA As Single
        Dim precio As Single
        Dim tipo As Single
        Dim id As Integer
        id = TextBox2.Text
        Dim resul(1) As Integer
        resul = misDatos.obtenerDatos(id)
        precio = resul(0)
        tipo = resul(1)
        IVA = misDatos.calculoIVA(precio, tipo)
        TextBox1.Text = precio
        TextBox3.Text = IVA
        TextBox4.Text = (precio - IVA)
    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
