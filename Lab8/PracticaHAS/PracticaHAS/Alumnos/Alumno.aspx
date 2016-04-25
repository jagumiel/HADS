<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Alumno.aspx.vb" Inherits="PracticaHAS.Alumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 78px;
        }
        .auto-style2 {
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
                    <asp:LinkButton ID="TareasAlumno" runat="server">Ver Tareas</asp:LinkButton>
                </td>
                <td class="auto-style2" rowspan="3">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Gestión Web de Tareas - Dedicación"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Alumnos" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Alumnos" style="text-align: right"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
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
