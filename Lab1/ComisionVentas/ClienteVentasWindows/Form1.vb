Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ventas As New ComisionVentas.Ventas
        Dim tv As Single
        Dim nv As Integer
        tv = TextBox1.Text
        nv = TextBox2.Text
        TextBox3.Text = ventas.comision(tv, nv)
    End Sub
End Class