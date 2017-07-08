<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="Acceso.aspx.cs" Inherits="ReconocimientoAmbientalWeb.Acceso" %>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <h1>Acceso a usuarios</h1>
    <asp:Label ID="lblNombreUsuario" runat="server" Text="Nombre de usuario:"></asp:Label>
    <asp:TextBox ID="tbNombreUsuario" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblContrasenia" runat="server" Text="Contraseña:"></asp:Label>
    <asp:TextBox ID="tbContrasenia" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />
</asp:Content>
