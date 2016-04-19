Public Class TareasProfesor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim hora As Date = TimeValue(Now)
        Label2.Text = hora

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles BotonInsertar.Click
        Response.Redirect("InsertarTarea.aspx")
    End Sub


    Protected Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class