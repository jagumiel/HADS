<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Coordinador.aspx.vb" Inherits="PracticaHAS.Coordinador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="200" border="1">
  <tr>
    <td colspan="2"><h1>Coordinador</h1></td>
  </tr>
  <tr>
    <td>Asignatura:</td>
    <td>
        <asp:DropDownList ID="miAsignatura" runat="server" DataSourceID="SqlDataSource1" DataTextField="codigo" DataValueField="codigo">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Lab4ConnectionString %>" SelectCommand="SELECT DISTINCT [codigo] FROM [Asignaturas]"></asp:SqlDataSource>
      </td>
  </tr>
  <tr>
    <td>Media:</td>
    <td>
        <asp:Label ID="LabelResultado" runat="server"></asp:Label>
      </td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>
        <asp:Button ID="Button1" runat="server" Text="Button" />
      </td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
