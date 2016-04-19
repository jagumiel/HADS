<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UsuariosOnline.aspx.vb" Inherits="PracticaHAS.UsuariosOnline" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Usuarios Online</h1>
        <p>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </p>
    </div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <table width="200">
                    <tr>
                        <td colspan="2">Alumnos</td>
                    </tr>
                    <tr>
                        <td>Número:</td>
                        <td>
                            <asp:Label ID="LabelNumAlums" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Alumnos Activos:</td>
                        <td>
                            <asp:ListBox ID="ListaAlumsOnline" runat="server"></asp:ListBox>
                        </td>
                    </tr>
                </table>
                <br />
                <asp:Timer ID="Timer1" runat="server" Interval="15000">
                </asp:Timer>
                <br />
                <table width="200">
                    <tr>
                        <td class="auto-style1" colspan="2">Profesores</td>
                    </tr>
                    <tr>
                        <td>Número:</td>
                        <td>
                            <asp:Label ID="LabelNumProfes" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Profesores Activos</td>
                        <td>
                            <asp:ListBox ID="ListaProfesOnline" runat="server"></asp:ListBox>
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
