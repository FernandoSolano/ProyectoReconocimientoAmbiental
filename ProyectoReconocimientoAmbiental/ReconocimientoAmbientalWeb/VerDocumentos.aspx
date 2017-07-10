<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="VerDocumentos.aspx.cs" Inherits="ReconocimientoAmbientalWeb.VerDocumentos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <p>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/NuevoDocumento.aspx">Nuevo documento</asp:HyperLink>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Documentos existentes"></asp:Label>
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <br />
    </p>
</asp:Content>
