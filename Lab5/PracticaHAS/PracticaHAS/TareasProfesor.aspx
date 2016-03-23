<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TareasProfesor.aspx.vb" Inherits="PracticaHAS.TareasProfesor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table border="1" style="width: 946px">
  <tr>
    <td class="auto-style1">
        <asp:Label ID="Label1" runat="server" Text="Seleccionar Asignatura:"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="Lab4_DB" DataTextField="codigo" DataValueField="codigo">
        </asp:DropDownList>
        <asp:SqlDataSource ID="Lab4_DB" runat="server" ConnectionString="<%$ ConnectionStrings:Lab4ConnectionString %>" SelectCommand="SELECT [codigo] FROM [Asignaturas]"></asp:SqlDataSource>
      </td>
    <td style="text-align: right">
        <asp:Button ID="BotonInsertar" runat="server" style="text-align: right" Text="Insertar Tarea" />
      </td>
  </tr>
  <tr>
    <td class="auto-style1" colspan="2">
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Codigo" DataSourceID="ProfeGridView_DataSource">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="Codigo" HeaderText="Codigo" ReadOnly="True" SortExpression="Codigo" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
                <asp:BoundField DataField="HEstimadas" HeaderText="HEstimadas" SortExpression="HEstimadas" />
                <asp:CheckBoxField DataField="Explotacion" HeaderText="Explotacion" SortExpression="Explotacion" />
                <asp:BoundField DataField="CodAsig" HeaderText="CodAsig" SortExpression="CodAsig" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="ProfeGridView_DataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Lab4ConnectionString %>" DeleteCommand="DELETE FROM [TareasGenericas] WHERE [Codigo] = @Codigo" InsertCommand="INSERT INTO [TareasGenericas] ([Codigo], [Descripcion], [HEstimadas], [Explotacion], [CodAsig]) VALUES (@Codigo, @Descripcion, @HEstimadas, @Explotacion, @CodAsig)" SelectCommand="SELECT [Codigo], [Descripcion], [HEstimadas], [Explotacion], [CodAsig] FROM [TareasGenericas] WHERE ([CodAsig] = @CodAsig)" UpdateCommand="UPDATE [TareasGenericas] SET [Descripcion] = @Descripcion, [HEstimadas] = @HEstimadas, [Explotacion] = @Explotacion, [CodAsig] = @CodAsig WHERE [Codigo] = @Codigo">
            <DeleteParameters>
                <asp:Parameter Name="Codigo" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Codigo" Type="String" />
                <asp:Parameter Name="Descripcion" Type="String" />
                <asp:Parameter Name="HEstimadas" Type="Int32" />
                <asp:Parameter Name="Explotacion" Type="Boolean" />
                <asp:Parameter Name="CodAsig" Type="String" />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="CodAsig" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="Descripcion" Type="String" />
                <asp:Parameter Name="HEstimadas" Type="Int32" />
                <asp:Parameter Name="Explotacion" Type="Boolean" />
                <asp:Parameter Name="CodAsig" Type="String" />
                <asp:Parameter Name="Codigo" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
      </td>
  </tr>
  <tr>
    <td class="auto-style1"><a href="LogOut.aspx">Cerrar Sesión</a></td>
    <td>&nbsp;</td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
