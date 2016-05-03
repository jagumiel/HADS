Imports System.Data.SqlClient

Public Class TareasAlumno
    Inherits System.Web.UI.Page

    Dim dataAdapter As New SqlDataAdapter
    Dim dataSet As New DataSet
    Dim dataTable As New DataTable

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Email") IsNot Nothing Then
            If Page.IsPostBack Then
            Else
                Dim conexion As New System.Data.SqlClient.SqlConnection("Server=tcp:serverlab4.database.windows.net,1433;Database=Lab4;User ID=has17@serverlab4;Password=J0s3B3g0;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
                dataAdapter = New SqlDataAdapter("SELECT codigoasig from GruposClase WHERE codigo in (SELECT Grupo from EstudiantesGrupo where Email='" & Session("Email") & "')", conexion)
                dataAdapter.Fill(dataSet, "AsignaturasAlumno")

                dataTable = dataSet.Tables("AsignaturasAlumno")
                ListaAsignaturas.DataTextField = "codigoasig"
                ListaAsignaturas.DataSource = dataTable
                ListaAsignaturas.DataBind()
                Try
                    'Dim conexion As New System.Data.SqlClient.SqlConnection("Server=tcp:serverlab4.database.windows.net,1433;Database=Lab4;User ID=has17@serverlab4;Password=J0s3B3g0;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
                    dataAdapter = New SqlDataAdapter("SELECT DISTINCT TareasGenericas.CodAsig, TareasGenericas.Codigo, TareasGenericas.Descripcion, TareasGenericas.HEstimadas, TareasGenericas.TipoTarea FROM TareasGenericas JOIN Asignaturas ON Asignaturas.codigo = TareasGenericas.CodAsig JOIN GruposClase ON Asignaturas.codigo = GruposClase.codigoasig JOIN EstudiantesGrupo ON EstudiantesGrupo.Grupo = GruposClase.codigo WHERE TareasGenericas.Explotacion = 'True'", conexion)
                    dataAdapter.Fill(dataSet, "TareasAsignatura")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Session("dataSet") = dataSet
                Session("dataAdapter") = dataAdapter
            End If

        Else
            Response.Redirect("Login.aspx")
        End If
    End Sub

    Protected Sub CheckBoxList1_SelectedIndexChanged(sender As Object, e As EventArgs)
        If CheckBoxList1.Items.Item(0).Selected Then
            GridView1.Columns(1).Visible = True
        Else
            GridView1.Columns(1).Visible = False
        End If

        If CheckBoxList1.Items.Item(1).Selected Then
            GridView1.Columns(2).Visible = True
        Else
            GridView1.Columns(2).Visible = False
        End If

        If CheckBoxList1.Items.Item(2).Selected Then
            GridView1.Columns(3).Visible = True
        Else
            GridView1.Columns(3).Visible = False
        End If

        If CheckBoxList1.Items.Item(3).Selected Then
            GridView1.Columns(4).Visible = True
        Else
            GridView1.Columns(4).Visible = False
        End If
    End Sub



    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Dim conexion As New System.Data.SqlClient.SqlConnection("Server=tcp:serverlab4.database.windows.net,1433;Database=Lab4;User ID=has17@serverlab4;Password=J0s3B3g0;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        Dim seleccion As String = ListaAsignaturas.SelectedValue
        dataAdapter = New SqlDataAdapter("SELECT * FROM TareasGenericas WHERE Explotacion='true' AND  CodAsig='" & seleccion & "'", conexion)
        Dim builder As New SqlCommandBuilder(dataAdapter)
        dataAdapter.Fill(dataSet, "TareasGenericas")
        dataTable = dataSet.Tables("TareasGenericas")
        'For Each row In dataTable.Rows
        'If row("CodAsig") = GridView1.SelectedRow.Cells(5).Text Then
        'GridView1.SelectedRow.Visible = True
        'Else
        'GridView1.SelectedRow.Visible = False
        'End If
        'Next
        GridView1.DataSource = dataTable
        GridView1.DataBind()

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, CheckBoxList1.SelectedIndexChanged
        Try
            'dataSet = Session("dataSet")
            'dataTable = dataSet.Tables("TareasAsignatura")
            'Esta select no la hace.
            'dataTable.Select("CodAsig = '" & ListaAsignaturas.SelectedValue & "'")

            Dim conexion As New System.Data.SqlClient.SqlConnection("Server=tcp:serverlab4.database.windows.net,1433;Database=Lab4;User ID=has17@serverlab4;Password=J0s3B3g0;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
            Dim seleccion As String = ListaAsignaturas.SelectedValue
            dataAdapter = New SqlDataAdapter("SELECT * FROM TareasGenericas WHERE Explotacion='true' AND  CodAsig='" & seleccion & "'", conexion)
            Dim builder As New SqlCommandBuilder(dataAdapter)
            dataAdapter.Fill(dataSet, "TareasGenericas")
            dataTable = dataSet.Tables("TareasGenericas")

            GridView1.DataSource = dataTable
            GridView1.DataBind()
            GridView1.Columns(1).Visible = True
            GridView1.Columns(2).Visible = False
            GridView1.Columns(3).Visible = False
            GridView1.Columns(4).Visible = False
            GridView1.Columns(5).Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Protected Sub ListaAsignaturas_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub


End Class