Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ventas As New ComisionVentas.Ventas
        Dim tv As Single
        Dim nv As Integer
        tv = TextBox1.Text
        nv = TextBox2.Text
        TextBox3.Text = ventas.comision(tv, nv)
    End Sub
End Class