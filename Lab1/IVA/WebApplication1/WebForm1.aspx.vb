Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim miCalculo As New IVA.IVA
        Dim precio As Single
        Dim tipo As Single
        Dim IVA As Single
        precio = TextBox1.Text
        tipo = DropDownList1.SelectedValue
        IVA = miCalculo.calculoIVA(precio, tipo)
        TextBox3.Text = IVA
        TextBox4.Text = (precio - IVA)
    End Sub
End Class