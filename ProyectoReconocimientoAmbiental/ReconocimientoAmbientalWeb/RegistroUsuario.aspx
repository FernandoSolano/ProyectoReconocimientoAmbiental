<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="ReconocimientoAmbientalWeb.RegistroUsuario" %>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <h1>Registro de usuarios</h1><br />
    <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
    <asp:TextBox ID="tbNombre" runat="server" Width="369px"></asp:TextBox>
    <br />
    <asp:Label ID="lblNombreUsuario" runat="server" Text="Nombre de usuario:"></asp:Label>
    <asp:TextBox ID="tbNombreUsuario" runat="server" Width="139px"></asp:TextBox>
    <br />
    <asp:Label ID="lblContrasenia" runat="server" Text="Contraseña:"></asp:Label>
    <asp:TextBox ID="tbContrasenia" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblConfirmarContrasenia" runat="server" Text="Confirmar contraseña:"></asp:Label>
    <asp:TextBox ID="tbConfirmarContrasenia" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblTelefono" runat="server" Text="Teléfono:"></asp:Label>
    <asp:TextBox ID="tbTelefono" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblEmail" runat="server" Text="Correo Electrónico:"></asp:Label>
    <asp:TextBox ID="tbEmail" runat="server" Width="249px"></asp:TextBox>
    <br />
    <asp:Label ID="lblRol" runat="server" Text="Rol:"></asp:Label>
    <asp:DropDownList ID="ddlRol" runat="server">
        <asp:ListItem Value="1">Administrador</asp:ListItem>
        <asp:ListItem Value="2">Encargado de Área</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" />
    <br />
</asp:Content>
