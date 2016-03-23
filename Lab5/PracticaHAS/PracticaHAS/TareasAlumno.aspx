<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TareasAlumno.aspx.vb" Inherits="PracticaHAS.TareasAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {}
        .auto-style2 {
            width: 190px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table border="1" style="width: 533px">
            <tr>
                <td class="auto-style2">
                    <asp:DropDownList ID="ListaAsignaturas" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
                <td class="auto-style2" rowspan="2">
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True">
                        <asp:ListItem Selected="True">Código</asp:ListItem>
                        <asp:ListItem>Descripción</asp:ListItem>
                        <asp:ListItem>Horas</asp:ListItem>
                        <asp:ListItem>Tipo Tarea</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" Text="Ver Tareas" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="2">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="InstanciarButton" Text="Instanciar" />
                            <asp:BoundField DataField="Codigo" HeaderText="Codigo" SortExpression="Codigo" />
                            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
                            <asp:BoundField DataField="HEstimadas" HeaderText="Horas Estimadas" SortExpression="HEstimadas" />
                            <asp:BoundField DataField="TipoTarea" HeaderText="Tipo Tarea" SortExpression="TipoTarea" />
                            <asp:BoundField DataField="CodAsig" HeaderText="CodAsig" SortExpression="CodAsig" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
