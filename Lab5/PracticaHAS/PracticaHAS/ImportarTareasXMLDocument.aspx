<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ImportarTareasXMLDocument.aspx.vb" Inherits="PracticaHAS.ImportarTareasXMLDocument" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table border="1" style="width: 946px">
  <tr>
    <td class="auto-style1">
        <asp:Label ID="Label1" runat="server" Text="Seleccionar Asignatura:"></asp:Label>
        <br />
        <asp:DropDownList ID="AsignaturasProfe" runat="server" AutoPostBack="True">
        </asp:DropDownList>
      </td>
    <td style="text-align: left">
        <asp:Button ID="BotonImportar" runat="server" style="text-align: left" Text="Importar (XML Document)" />
      </td>
  </tr>
  <tr>
    <td class="auto-style1" colspan="2">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        </asp:GridView>
        <asp:Xml ID="Xml1" runat="server"></asp:Xml>
        <br />
        <asp:Label ID="Mensaje" runat="server"></asp:Label>
      </td>
  </tr>
  <tr>
    <td class="auto-style1"><a href="Profesor.aspx">Menú anterior</a></td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="auto-style1">&nbsp;</td>
    <td>&nbsp;</td>
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
