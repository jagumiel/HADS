Public Class Alumno
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub TareasAlumno_Click(sender As Object, e As EventArgs) Handles TareasAlumno.Click
        Response.Redirect("TareasAlumno.aspx")
    End Sub

    Protected Sub VolverInicio_Click(sender As Object, e As EventArgs) Handles VolverInicio.Click
        Response.Redirect("LogOut.aspx")
    End Sub
End Class