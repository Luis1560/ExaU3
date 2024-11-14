<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="ExaU3.Views.Agregar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <form id="formAgregarProducto" runat="server" enctype="multipart/form-data">
        <div>
            <asp:Label for="txtNombre" runat="server">Nombre: </asp:Label>
            <asp:TextBox ID="txtNombre" runat="server" Required="true"></asp:TextBox>
            <br/>

            <asp:Label for="txtCantidad" runat="server">Cantidad: </asp:Label>
            <asp:TextBox ID="txtCantidad" runat="server" TextMode="Number" Required="true"></asp:TextBox>
            <br/>

            <asp:Label for="txtCosto" runat="server">Costo: </asp:Label>
            <asp:TextBox ID="txtCosto" runat="server" TextMode="Number" Required="true"></asp:TextBox>
            <br/>

            <asp:Label for="fileImagen" runat="server">Imagen: </asp:Label>
            <asp:FileUpload ID="fileImagen" runat="server" CssClass="form-control"/>
            <br/>

            <div class="button-group">
                <asp:Button ID="btnAgregarProducto" runat="server" Text="Agregar Producto" OnClick="btnAgregarProducto_Click" CssClass="aspNetButton"/>
                <asp:Button ID="btnMostrarProducto" runat="server" Text="Mostrar Lista" OnClick="btnMostrarProducto_Click" CssClass="aspNetButton"/>
            </div>
        </div>
    </form>
</body>
</html>
