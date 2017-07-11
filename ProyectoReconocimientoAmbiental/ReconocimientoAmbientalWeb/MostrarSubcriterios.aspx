<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="MostrarSubcriterios.aspx.cs" Inherits="ReconocimientoAmbientalWeb.MostrarSubcriterios" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">




    <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Visualizar por:"></asp:Label>
&nbsp;&nbsp;
    <asp:DropDownList ID="ddlTipoBusqueda" runat="server" AutoPostBack="True" Height="27px" OnSelectedIndexChanged="ddlTipoBusqueda_SelectedIndexChanged" Width="159px">
        <asp:ListItem Value="1">Criterio</asp:ListItem>
        <asp:ListItem Value="2">Área</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="lblSeleccionBusqueda" runat="server" Font-Bold="True" Text="Label"></asp:Label>
&nbsp;&nbsp;
    <asp:DropDownList ID="ddlAreasCriterios" runat="server" Height="28px" OnSelectedIndexChanged="ddlAreasCriterios_SelectedIndexChanged" Width="321px" AutoPostBack="True">
    </asp:DropDownList>
    <br />
    <br />
    <br />
    <asp:GridView ID="gvCriterios" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="NombreSubcriterio" HeaderText="Nombre" />
            <asp:BoundField DataField="DescripcionSubcriterio" HeaderText="Descripción" />
        </Columns>
    </asp:GridView>




</asp:Content>
