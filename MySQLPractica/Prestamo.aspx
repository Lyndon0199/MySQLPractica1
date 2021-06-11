<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prestamos.aspx.cs" Inherits="MysqlProyect.Prestamos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            CodAutor<br />
            <asp:TextBox ID="txtcodAutor" runat="server"></asp:TextBox>
            <br />
            CodLibro<br />
            <asp:TextBox ID="txtcodLibro" runat="server"></asp:TextBox>
            <br />
            Fecha Prestamo<br />
            <asp:TextBox ID="txtFecha" runat="server" ></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" Width="122px" />
            <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" Width="120px" />
            <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" Width="123px" />
            <br />
            <br />
            <asp:GridView ID="gvTabla" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
