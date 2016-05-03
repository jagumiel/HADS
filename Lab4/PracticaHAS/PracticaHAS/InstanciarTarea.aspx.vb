Imports System.Data.SqlClient

Public Class InstanciarTarea
    Inherits System.Web.UI.Page

    Dim conexion As SqlConnection = New SqlConnection("Server=tcp:serverlab4.database.windows.net,1433;Database=Lab4;User ID=has17@serverlab4;Password=J0s3B3g0;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
    Dim dataAdapter As New SqlDataAdapter
    Dim dataSet As New DataSet
    Dim dataTable As New DataTable

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox1.Text = Session("Email")
        TextBox2.Text = Request.QueryString("codigo")

        dataAdapter = New SqlDataAdapter("SELECT * FROM TareasPersonales WHERE Email = '" & Session("Email") & "'", conexion)
        Dim builder As New SqlCommandBuilder(dataAdapter)
        dataAdapter.Fill(dataSet, "EstudiantesTareas")
        dataTable = dataSet.Tables("EstudiantesTareas")

        GridView1.DataSource = dataTable
        GridView1.DataBind()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dataTable = dataSet.Tables("TareasPersonales")
        Dim dataRow As DataRow = dataTable.NewRow()
        dataRow("Email") = TextBox1.Text
        dataRow("CodTarea") = TextBox2.Text
        dataRow("HEstimadas") = TextBox3.Text
        dataRow("HReales") = TextBox4.Text
        dataTable.Rows.Add(dataRow)

        dataAdapter.Update(dataSet, "TareasPersonales")
        dataSet.AcceptChanges()

        GridView1.DataSource = dataTable
        GridView1.DataBind()
    End Sub
End Class