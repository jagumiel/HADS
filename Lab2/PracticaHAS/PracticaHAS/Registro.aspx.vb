Public Class Registro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub ButtonRegistrar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonRegistrar.Click
        Dim miConfirmacion As New Funciones.MisFunciones
        Dim valor As Single
        valor = miConfirmacion.NumConf
        'ir a la página de confirmacion y pasar el parametro valor
        'Server.Transfer("Confirmar.aspx", True)

        Response.Redirect("Confirmar.aspx?NumConf=" & valor)
    End Sub

End Class