<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InsertarTarea.aspx.vb" Inherits="PracticaHAS.InsertarTarea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 128px;
        }
        .auto-style2 {
            width: 474px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 618px">
  <tr>
    <td class="auto-style1">
        <asp:Label ID="Label1" runat="server" Text="Código"></asp:Label>
      </td>
    <td class="auto-style2">
        <asp:TextBox ID="BoxCodigo" runat="server"></asp:TextBox>
      </td>
  </tr>
  <tr>
    <td class="auto-style1">
        <asp:Label ID="Label2" runat="server" Text="Descripción"></asp:Label>
      </td>
    <td class="auto-style2">
        <asp:TextBox ID="BoxDescripcion" runat="server" Height="70px" Width="439px"></asp:TextBox>
      </td>
  </tr>
  <tr>
    <td class="auto-style1">
        <asp:Label ID="Label3" runat="server" Text="Asignatura"></asp:Label>
      </td>
    <td class="auto-style2">
        <asp:DropDownList ID="ListaAsignaturas" runat="server" DataSourceID="InsertarTarea_source" DataTextField="codigo" DataValueField="codigo">
        </asp:DropDownList>
        <asp:SqlDataSource ID="InsertarTarea_source" runat="server" ConnectionString="<%$ ConnectionStrings:Lab4ConnectionString %>" SelectCommand="SELECT [codigo] FROM [Asignaturas]"></asp:SqlDataSource>
      </td>
  </tr>
  <tr>
    <td class="auto-style1">
        <asp:Label ID="Label4" runat="server" Text="Horas Estimadas"></asp:Label>
      </td>
    <td class="auto-style2">
        <asp:TextBox ID="BoxHoras" runat="server"></asp:TextBox>
      </td>
  </tr>
  <tr>
    <td class="auto-style1">
        <asp:Label ID="Label5" runat="server" Text="Tipo Tarea"></asp:Label>
      </td>
    <td class="auto-style2">
        <asp:DropDownList ID="ListaTipos" runat="server" DataSourceID="SqlDataSource1" DataTextField="TipoTarea" DataValueField="TipoTarea">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Lab4ConnectionString %>" SelectCommand="SELECT DISTINCT [TipoTarea] FROM [TareasGenericas]"></asp:SqlDataSource>
      </td>
  </tr>
  <tr>
    <td class="auto-style1">
        <br />
        <br />
        <asp:Button ID="BotonAnadir" runat="server" Text="Añadir Tareas" />
      </td>
    <td class="auto-style2" align="right"><a href="TareasProfesor.aspx">Ver Tareas</a></td>
  </tr>
  <tr>
    <td class="auto-style1">
        <asp:Label ID="Resultado" runat="server"></asp:Label>
      </td>
    <td class="auto-style2" align="right">&nbsp;</td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
