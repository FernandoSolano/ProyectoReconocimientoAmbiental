<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="ReconocimientoAmbientalWeb.RegistroUsuario" %>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <h1>Registro de usuarios</h1><br />
    <br />
    <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
    <asp:TextBox ID="tbNombre" runat="server" Width="369px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="tbNombre" ErrorMessage="Debe ingresar este campo" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lblNombreUsuario" runat="server" Text="Nombre de usuario:"></asp:Label>
    <asp:TextBox ID="tbNombreUsuario" runat="server" Width="139px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tbNombreUsuario" ErrorMessage="Debe ingresar este campo" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lblContrasenia" runat="server" Text="Contraseña:"></asp:Label>
    <asp:TextBox ID="tbContrasenia" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblConfirmarContrasenia" runat="server" Text="Confirmar contraseña:"></asp:Label>
    <asp:TextBox ID="tbConfirmarContrasenia" runat="server" TextMode="Password"></asp:TextBox>
    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="tbConfirmarContrasenia" ControlToValidate="tbContrasenia" ErrorMessage="Las contraseñas deben coincidir" ForeColor="Red"></asp:CompareValidator>
    <br />
    <asp:Label ID="lblTelefono" runat="server" Text="Teléfono:"></asp:Label>
    <asp:TextBox ID="tbTelefono" runat="server" TextMode="Phone"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbTelefono" ErrorMessage="Debe ingresar este campo" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lblEmail" runat="server" Text="Correo Electrónico:"></asp:Label>
    <asp:TextBox ID="tbEmail" runat="server" Width="249px" TextMode="Email"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbEmail" ErrorMessage="Debe ingresar este campo" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lblRol" runat="server" Text="Rol:"></asp:Label>
    <asp:DropDownList ID="ddlRol" runat="server">
        <asp:ListItem Value="1">Administrador</asp:ListItem>
        <asp:ListItem Value="2">Encargado de Área</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
    <br />
    <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
    <br />
</asp:Content>
