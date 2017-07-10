<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="nuevaEvidenciaMenu.aspx.cs" Inherits="ReconocimientoAmbientalWeb.nuevaEvidenciaMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <p>
        Desea agregar:</p>
    <p>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/verAcciones.aspx">Acción administrativa</asp:HyperLink>
    </p>
    <p>
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/verNormativas.aspx">Normativa universitaria</asp:HyperLink>
    </p>
    <p>
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/VerDocumentos.aspx">Documento</asp:HyperLink>
    </p>
    <p>
        <asp:HyperLink ID="HyperLink5" runat="server">Actividad realizada</asp:HyperLink>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
