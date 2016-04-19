<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CambiarPassword.aspx.vb" Inherits="PracticaHAS.CambiarPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Cambiar Contraseña</h1>

        <p>¿Desea cambiar la contraseña?</p>
        <a href="Inicio.aspx">Volver</a>
       

        <table align="center">
                        <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Email:"></asp:Label>
                </td>
                <td>
    
                    <asp:TextBox ID="BoxEmail" runat="server" TextMode="Email"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="BoxEmail" ErrorMessage="RequiredFieldValidator" Font-Size="Large" ForeColor="#993300">*</asp:RequiredFieldValidator>
    
                </td>
            </tr>
                        <tr>
                <td colspan="2">
                    <asp:Button ID="ButtonConf" runat="server" Text="Confirmar" Width="269px" />
                </td>
            </tr>
    
    </div>
    </form>
    </div>
    <p>
        Se generará una contraseña de forma automática.</p>
</body>
</html>
