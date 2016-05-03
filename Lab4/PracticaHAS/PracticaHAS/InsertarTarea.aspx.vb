Imports System.Data.SqlClient

Public Class InsertarTarea
    Inherits System.Web.UI.Page

    'Dim miServer As SqlConnection = New SqlConnection("Server=tcp:serverlab4.database.windows.net,1433;Database=Lab4;User ID=has17@serverlab4;Password={your_password_here};Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
    'Dim tareasDataAdapter As New SqlDataAdapter
    'Dim tareasDataSet As New DataSet
    'Dim tareasTabla As New DataTable
    'Dim tareasRow As New DataRow

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' If Page.IsPostBack Then
        'tareasDataSet = Session("datos")
        'Else
        'tareasDataAdapter = New SqlDataAdapter("select* from TareasGenericas", miServer)
        'Dim tareasBuilder As New SqlCommandBuilder(tareasDataAdapter)
        'tareasDataAdapter.Fill(tareasDataSet, "Tareas")
        'tareasTabla = tareasDataSet.Tables("Tareas")
        'For Each tareasRow In tareasTabla.Rows
        'Lista.Items.Add(tareasRow("Codigo"))
        'Next
        'Session("datos") = tareasDataSet
        'Session("adaptador") = tareasDataAdapter
        ' End If
    End Sub

    Protected Sub BotonAnadir_Click(sender As Object, e As EventArgs) Handles BotonAnadir.Click
        Dim codigo As String = BoxCodigo.Text
        Dim descripcion As String = BoxDescripcion.Text
        Dim asignatura As String = ListaAsignaturas.SelectedValue
        Dim horas As Integer = BoxHoras.Text
        Dim tipo As String = ListaTipos.SelectedValue

        Dim miInsercion As New Funciones.DB_Logic
        If (miInsercion.InsertarTarea(codigo, descripcion, asignatura, horas, tipo)) Then
            Resultado.Text = "Se ha insertado correctamente la tarea."
        End If


    End Sub
End Class