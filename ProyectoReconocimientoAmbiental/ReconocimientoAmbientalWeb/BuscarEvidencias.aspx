<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="BuscarEvidencias.aspx.cs" Inherits="ReconocimientoAmbientalWeb.BuscarEvidencias" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <span class="auto-style1"><strong>Busqueda de Evidencias:<br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Área Tematica:&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblAreaActual" runat="server" Text="areaX"></asp:Label>
&nbsp;
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="Criterio"></asp:Label>
&nbsp;
    <asp:DropDownList ID="ddlCriterio" runat="server" AutoPostBack="True" Height="26px" Width="141px" OnLoad="ddlCriterio_Load" OnSelectedIndexChanged="ddlCriterio_SelectedIndexChanged">
    </asp:DropDownList>
&nbsp;
    <asp:Label ID="Label3" runat="server" Text="SubCriterio"></asp:Label>
&nbsp;
    <asp:DropDownList ID="ddlSubcriterio" runat="server" AutoPostBack="True" Height="23px" Width="143px">
    </asp:DropDownList>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
    <br />
    <br />
&nbsp;
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="660px">
        <Columns>
            <asp:BoundField DataField="idEvidencia" HeaderText="Id" SortExpression="idEvidencia" />
            <asp:BoundField DataField="tituloEvidencia" HeaderText="Titulo" SortExpression="tituloEvidencia" />
            <asp:BoundField DataField="fechaEvidencia" HeaderText="Fecha" SortExpression="fechaEvidencia" />
        </Columns>
    </asp:GridView>
    <br />
    <br />
    <br />
    </strong></span>

</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
    </style>
</asp:Content>

