Public Class UsuariosOnline
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Application("numAlums") Is Nothing Then
            LabelNumAlums.Text = 0
        Else
            LabelNumAlums.Text = Application("numAlums")
            Me.ListaAlumsOnline.DataSource = Application("alumsOnline")
            Me.ListaAlumsOnline.DataBind()
        End If

        If Application("numProfes") Is Nothing Then
            LabelNumProfes.Text = 0
        Else
            LabelNumProfes.Text = Application("numProfes")
            Me.ListaProfesOnline.DataSource = Application("profesOnline")
            Me.ListaProfesOnline.DataBind()
        End If
    End Sub


End Class