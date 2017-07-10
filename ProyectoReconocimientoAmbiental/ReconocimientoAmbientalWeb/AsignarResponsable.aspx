<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="AsignarResponsable.aspx.cs" Inherits="ReconocimientoAmbientalWeb.AsignarResponsable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <asp:Label ID="lblHeadArea" runat="server" Font-Bold="True" Text="Seleccione un Área Temática:"></asp:Label>
&nbsp;
    <asp:DropDownList ID="ddlAreas" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddlAreas_SelectedIndexChanged" Width="219px">
    </asp:DropDownList>
    <br />
    <br />
    <br />
    <asp:Label ID="lblHeadAreaSeleccionada" runat="server" Font-Bold="True" Text="Área Temática:"></asp:Label>
&nbsp;
    <asp:Label ID="lblArea" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Label ID="lblHeadDescripcion" runat="server" Font-Bold="True" Text="Descripción:"></asp:Label>
&nbsp;
    <asp:Label ID="lblDescripcion" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Label ID="lblHeadFuncionario" runat="server" Font-Bold="True" Text="Funcionario Evaluador:"></asp:Label>
&nbsp;
    <asp:DropDownList ID="ddlFuncionarios" runat="server" Height="16px" Width="262px">
    </asp:DropDownList>
    <br />
    <asp:Button ID="btnAsignar" runat="server" OnClick="btnAsignar_Click" Text="Asignar" />
</asp:Content>
