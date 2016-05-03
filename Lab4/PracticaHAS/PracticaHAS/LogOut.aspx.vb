Public Class LogOut
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Session("Email") Is Nothing) Then
            Response.Redirect("Inicio.aspx")
        Else
            Session.Remove("Email")
            Response.Redirect("Inicio.aspx")
        End If
    End Sub

End Class