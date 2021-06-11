<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Autores.aspx.cs" Inherits="MysqlProyect.Autores" %>

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
            <asp:TextBox ID="txtCodigoAutor" runat="server"></asp:TextBox>
            <br />
            Nombres<br />
            <asp:TextBox ID="txtNombres" runat="server"></asp:TextBox>
            <br />
            Apellidos<br />
            <asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox>
            <br />
            Nacionalidad<br />
            <asp:TextBox ID="txtNacionalidad" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" Width="143px" />
            <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" style="height: 26px" Text="Actualizar" Width="146px" />
            <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" Width="146px" />
            <br />
            <asp:GridView ID="gvTabla" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
