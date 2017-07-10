<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="verNormativas.aspx.cs" Inherits="ReconocimientoAmbientalWeb.verNormativas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/NuevaNormativa.aspx">Nueva normativa</asp:HyperLink>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Normativas existentes"></asp:Label>
    <br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />
</asp:Content>
