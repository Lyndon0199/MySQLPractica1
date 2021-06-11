<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MySQLPractica.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>CodAutor: <asp:TextBox runat="server" ID="txtCodAutor" /> </p>
            <p>Apellidos: <asp:TextBox runat="server" ID="txtApellidos"/> </p>
            <p>Nombres: <asp:TextBox runat="server" ID="txtNombres"/> </p>
            <p>Nacionalidad: <asp:TextBox runat="server" ID="txtNacionalidad"/> </p>
            <p>
                <asp:Button Text="Agregar" runat="server" ID="btnAgregar" OnClick="btnAgregar_Click" />
                <asp:Button Text="Eliminar" runat="server" ID="btnEliminar" OnClick="btnEliminar_Click" />
                <asp:Button Text="Actualizar" runat="server" ID="btnActualizar" OnClick="btnActualizar_Click" />
            </p>
            <asp:GridView runat="server" ID="gvAutor" OnSelectedIndexChanged="gvAutor_SelectedIndexChanged">


            </asp:GridView>
        </div>
    </form>
</body>
</html>
