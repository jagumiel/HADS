<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Profesor.aspx.vb" Inherits="PracticaHAS.Profesor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 226px;
        }
        .auto-style2 {
            width: 678px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table border="1" style="width: auto" align="center">
            <tr>
                <td class="auto-style1">
                    <asp:LinkButton ID="TareaProfesor" runat="server">Agregar Tareas</asp:LinkButton>
                </td>
                <td class="auto-style2" rowspan="4">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Gestión Web de Tareas - Dedicación"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Profesores"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:LinkButton ID="ImportarXML" runat="server">Importar XML</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:LinkButton ID="ExportarXML" runat="server">Exportar XML</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:LinkButton ID="VolverInicio" runat="server">Volver Inicio</asp:LinkButton>
                </td>
            </tr>
            </table>
    </div>
    </form>
</body>
</html>
