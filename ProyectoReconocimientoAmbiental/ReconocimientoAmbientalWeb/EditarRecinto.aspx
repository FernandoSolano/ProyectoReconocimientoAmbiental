<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="EditarRecinto.aspx.cs" Inherits="ReconocimientoAmbientalWeb.EditarRecinto" %>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
    <asp:TextBox ID="tbNombre" runat="server" Width="414px" onfocus="javascript:this.select();"></asp:TextBox>
    <br />
    <asp:Label ID="lblDireccion" runat="server" Text="Dirección:"></asp:Label>
    <asp:TextBox ID="tbDireccion" runat="server" Height="43px" Width="406px" onfocus="javascript:this.select();"></asp:TextBox>
    <br />
    <asp:Label ID="lblTelefono" runat="server" Text="Teléfono:"></asp:Label>
    <asp:TextBox ID="tbTelefono" runat="server" onfocus="javascript:this.select();"></asp:TextBox>
    <br />
    <asp:Label ID="lblCorreo" runat="server" Text="Correo electrónico:"></asp:Label>
    <asp:TextBox ID="tbCorreo" runat="server" Width="348px" onfocus="javascript:this.select();"></asp:TextBox>
    <br />
    <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />

</asp:Content>
