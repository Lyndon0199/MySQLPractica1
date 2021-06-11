<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lista.aspx.cs" Inherits="MysqlProyect.Lista" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            CodLibro<br />
            <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
            <br />
            Titulo<br />
            <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
            <br />
            Editorial<br />
            <asp:TextBox ID="txtEditorial" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" style="height: 26px" Text="Agregar" Width="122px" />
            <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" Width="129px" />
            <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" Width="163px" />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
