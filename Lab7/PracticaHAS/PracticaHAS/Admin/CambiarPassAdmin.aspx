<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CambiarPassAdmin.aspx.vb" Inherits="PracticaHAS.CambiarPassAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="200" align="center">
  <tr>
    <td>
        <asp:Label ID="Label1" runat="server" Text="E-mail"></asp:Label>
      </td>
    <td>
        <asp:DropDownList ID="correo" runat="server" DataSourceID="SqlDataSource1" DataTextField="email" DataValueField="email">
        </asp:DropDownList>
      </td>
    <td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="correo" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
      </td>
  </tr>
  <tr>
    <td>
        <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
      </td>
    <td>
        <asp:TextBox ID="pass" runat="server" TextMode="Password"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td>
        <asp:Label ID="Label3" runat="server" Text="Confirmar Contraseña"></asp:Label>
      </td>
    <td>
        <asp:TextBox ID="passconf" runat="server" TextMode="Password"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Lab4ConnectionString %>" SelectCommand="SELECT [email] FROM [Usuarios]"></asp:SqlDataSource>
      </td>
    <td>
        <asp:Button ID="Button1" runat="server" Text="Cambiar Contraseña" />
      </td>
    <td>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="pass" ControlToValidate="passconf" ErrorMessage="CompareValidator"></asp:CompareValidator>
      </td>
  </tr>
</table>
    </div>
    </form>



</body>
</html>
