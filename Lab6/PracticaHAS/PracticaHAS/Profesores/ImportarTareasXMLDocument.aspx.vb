Imports System.Data.SqlClient
Imports System.Xml
Imports System.Xml.Schema

Public Class ImportarTareasXMLDocument
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

    Protected Sub AsignaturasProfe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AsignaturasProfe.SelectedIndexChanged
        Try
            xml = AsignaturasProfe.SelectedValue & ".xml"
            'Comprobamos que existe el archivo.
            If My.Computer.FileSystem.FileExists(Server.MapPath("/App_Data/" & xml)) Then
                Xml1.DocumentSource = Server.MapPath("/App_Data/" & xml)
                Xml1.TransformSource = Server.MapPath("/App_Data/XSLTFile.xsl")
                Mensaje.Text = " "
            Else
                Mensaje.Text = "No hay ningún XML que mostrar para esta asignatura."
            End If
        Catch ex As Exception
            Mensaje.Text = MsgBox(ex.Message)
        End Try
    End Sub

    Protected Sub BotonImportar_Click(sender As Object, e As EventArgs) Handles BotonImportar.Click
        Try
            Dim miAsignatura As String = AsignaturasProfe.SelectedValue
            Dim docxml As New XmlDocument
            Dim conexion As New System.Data.SqlClient.SqlConnection("Server=tcp:serverlab4.database.windows.net,1433;Database=Lab4;User ID=has17@serverlab4;Password=J0s3B3g0;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
            docxml.Load(Server.MapPath("/App_Data/" & AsignaturasProfe.SelectedValue & ".xml"))

            dataAdapter = New SqlDataAdapter("SELECT * FROM TareasGenericas ", conexion)
            dataAdapter.Fill(dataSet, "TareasGenericas")
            dataTable = dataSet.Tables("TareasGenericas")
            Dim nuevasTareas As XmlNodeList = docxml.GetElementsByTagName("tarea")
            Dim i As Integer
            Dim fin As Integer = nuevasTareas.Count - 1
            For i = 0 To fin
                Dim codigo As String = nuevasTareas(i).ChildNodes(0).ChildNodes(0).Value
                Dim descripcion As String = nuevasTareas(i).ChildNodes(1).ChildNodes(0).Value
                Dim codasig As String = miAsignatura
                Dim hestimadas As String = Integer.Parse(nuevasTareas(i).ChildNodes(2).ChildNodes(0).Value)
                Dim explotacion As String = Boolean.Parse(nuevasTareas(i).ChildNodes(3).ChildNodes(0).Value)
                Dim tipotarea As String = nuevasTareas(i).ChildNodes(4).ChildNodes(0).Value
                dataTable.Rows.Add(codigo, descripcion, codasig, hestimadas, explotacion, tipotarea)
            Next

            Dim myCmd As SqlCommandBuilder = New SqlCommandBuilder(dataAdapter)
            dataAdapter.Update(dataSet, "TareasGenericas")
            dataSet.AcceptChanges()


            dataTable = dataSet.Tables("TareasGenericas")
            GridView1.DataSource = dataTable
            GridView1.DataBind()

            Session("datos") = dataSet
            Session("adapter") = dataAdapter

            Mensaje.Text = "Las entradas del archivo XML se han añadido a la base de datos"

        Catch ex As Exception
            MsgBox(ex.Message)
            Mensaje.Text = "Las entradas del archivo XML no se han podido añadir a la base de datos"
        End Try
    End Sub


End Class