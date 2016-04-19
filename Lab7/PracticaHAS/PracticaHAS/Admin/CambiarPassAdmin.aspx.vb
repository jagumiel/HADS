Imports System.Security.Cryptography

Public Class CambiarPassAdmin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim miCorreo As String = correo.SelectedValue
        Dim miPass As String = pass.Text
        Dim asunto As String = "Contraseña modificada por admin"
        Dim miConfirmacion As New Funciones.MisFunciones
        Dim miCambio As New Funciones.DB_Logic
        MsgBox(miPass)
        Dim md5Hash As MD5 = MD5.Create()
        Dim passCifrada As String = Funciones.MisFunciones.GetMd5Hash(md5Hash, miPass)
        MsgBox(passCifrada)
        miConfirmacion.sendMail(miCorreo, asunto, passCifrada)
        miCambio.ModificarPass(miCorreo, passCifrada)
        MsgBox("Se ha cambiado la contraseña. Revise su correo")
        Response.Redirect("/Inicio.aspx")
    End Sub
End Class