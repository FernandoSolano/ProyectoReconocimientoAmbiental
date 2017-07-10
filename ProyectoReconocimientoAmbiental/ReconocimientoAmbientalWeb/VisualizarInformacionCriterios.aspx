<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipalFuncionario.Master" AutoEventWireup="true" CodeBehind="VisualizarInformacionCriterios.aspx.cs" Inherits="ReconocimientoAmbientalWeb.VisualizarInformacionCriterios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#0000CC" Text="Listado de criterios"></asp:Label>
     <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="idCriterio" HeaderText="ID" SortExpression="idCriterio" />
            <asp:BoundField DataField="nombreCriterio" HeaderText="Nombre" SortExpression="nombreCriterio" />
            <asp:BoundField DataField="descripcionCriterio" HeaderText="Descripcion" SortExpression="descripcionCriterio" />
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Ver subcriterios" ShowHeader="True" Text="Mostrar subcriterios" />
        </Columns>
    </asp:GridView>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
     <br />
</asp:Content>
