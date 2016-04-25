Public Class Coordinador
    Inherits System.Web.UI.Page
    Dim misFunciones As New Funciones.MisFunciones
    Dim miWebService As New ServiceCoordinacion.ServicioCoordinacionSoapClient

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    'Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles miAsignatura.SelectedIndexChanged
    '   MsgBox("hola")
    '  LabelResultado.Text = miWebService.MediaDedicacionAlumnos(miAsignatura.SelectedItem.Value)
    'End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LabelResultado.Text = miWebService.MediaDedicacionAlumnos(miAsignatura.SelectedItem.Value)
    End Sub
End Class