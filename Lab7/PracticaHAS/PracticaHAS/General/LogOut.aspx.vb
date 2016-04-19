Public Class LogOut
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Session("Email") Is Nothing) Then
            Response.Redirect("Inicio.aspx")
        Else
            If (Session("Rol") = "A") Then
                Application("numAlum") -= 1
                Application("alumsOnline").Remove(Session("Email"))
            Else
                Application("numProfes") -= 1
                Application("profesOnline").Remove(Session("Email"))
            End If
            Session.Remove("Email")
            Response.Redirect("Inicio.aspx")
        End If
    End Sub

End Class