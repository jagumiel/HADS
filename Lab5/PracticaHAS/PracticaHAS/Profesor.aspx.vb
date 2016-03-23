Public Class Profesor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub TareaProfesor_Click(sender As Object, e As EventArgs) Handles TareaProfesor.Click
        Response.Redirect("TareasProfesor.aspx")
    End Sub

    Protected Sub ImportarXML_Click(sender As Object, e As EventArgs) Handles ImportarXML.Click
        Response.Redirect("ImportarTareasXMLDocument.aspx")
    End Sub

    
    Protected Sub ExportarXML_Click(sender As Object, e As EventArgs) Handles ExportarXML.Click
        Response.Redirect("ExportarTareasXMLDocument.aspx")
    End Sub

    Protected Sub VolverInicio_Click(sender As Object, e As EventArgs) Handles VolverInicio.Click
        Response.Redirect("LogOut.aspx")
    End Sub
End Class