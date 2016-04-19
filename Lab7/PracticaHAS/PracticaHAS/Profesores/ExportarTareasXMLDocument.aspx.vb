Imports System.Data.SqlClient

Public Class ExportarTareasXMLDocument
    Inherits System.Web.UI.Page
    Dim dataAdapter As New SqlDataAdapter
    Dim dataSet As New DataSet
    Dim dataTable As New DataTable
    Dim xml As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack Then
        Else
            Dim conexion As New System.Data.SqlClient.SqlConnection("Server=tcp:serverlab4.database.windows.net,1433;Database=Lab4;User ID=has17@serverlab4;Password=J0s3B3g0;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
            dataAdapter = New SqlDataAdapter("SELECT codigoasig from GruposClase WHERE codigo in (SELECT codigogrupo from ProfesoresGrupo where email='" & Session("Email") & "')", conexion)
            dataAdapter.Fill(dataSet, "AsignaturasProfe")

            dataTable = dataSet.Tables("AsignaturasProfe")
            AsignaturasProfe.DataTextField = "codigoasig"
            AsignaturasProfe.DataSource = dataTable
            AsignaturasProfe.DataBind()
        End If
    End Sub


    Protected Sub BotonExportar_Click(sender As Object, e As EventArgs) Handles BotonExportar.Click
        Dim miDSet As DataSet = New DataSet
        miDSet.DataSetName = "tareas"
        miDSet.Namespace = "http://ji.ehu.es/" & AsignaturasProfe.SelectedValue.ToLower()
        miDSet.Prefix = AsignaturasProfe.SelectedValue.ToLower()
        miDSet.Tables.Add(Session("tabla"))
        Session("export") = miDSet

        Try
            dataSet = Session("export")
            dataSet.WriteXml(Server.MapPath("/App_Data/MisExportaciones/" & AsignaturasProfe.SelectedValue & ".xml"))
            Mensaje.Text = "Se han exportado las tareas."
        Catch ex As Exception
            Mensaje.Text = "Error al exportar las tareas. "
        End Try
    End Sub

    Protected Sub AsignaturasProfe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AsignaturasProfe.SelectedIndexChanged
        Try
            Dim conexion As New System.Data.SqlClient.SqlConnection("Server=tcp:serverlab4.database.windows.net,1433;Database=Lab4;User ID=has17@serverlab4;Password=J0s3B3g0;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
            dataAdapter = New SqlDataAdapter("SELECT DISTINCT TareasGenericas.Codigo, TareasGenericas.Descripcion, TareasGenericas.HEstimadas, TareasGenericas.Explotacion, TareasGenericas.TipoTarea, TareasGenericas.CodAsig FROM TareasGenericas JOIN Asignaturas ON Asignaturas.codigo = TareasGenericas.CodAsig JOIN GruposClase ON Asignaturas.codigo = GruposClase.codigoasig JOIN ProfesoresGrupo ON ProfesoresGrupo.codigogrupo = GruposClase.codigo WHERE ProfesoresGrupo.email = '" & Session("Email") & "'", conexion)
            dataAdapter.Fill(dataSet, "TareasProfe")
            dataTable = dataSet.Tables("TareasProfe")

            'Comienzo filtrado por asignatura
            Dim expression As String
            expression = "CodAsig='" & AsignaturasProfe.SelectedValue & "'"
            Dim foundRows() As DataRow
            ' Use the Select method to find all rows matching the filter.
            foundRows = dataTable.Select(expression)

            Dim i As Integer
            ' Guardamos las filas en la tabla
            For i = 0 To foundRows.GetUpperBound(0)
                dataTable = foundRows.CopyToDataTable()
            Next i
            'Final filtrado

            'Fuente: https://msdn.microsoft.com/es-es/library/det4aw50%28v=vs.110%29.aspx

            Session("tabla") = dataTable
            GridView1.DataSource = Session("tabla")
            GridView1.DataBind()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class