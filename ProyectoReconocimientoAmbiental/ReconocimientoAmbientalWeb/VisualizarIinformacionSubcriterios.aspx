<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipalFuncionario.Master" AutoEventWireup="true" CodeBehind="VisualizarIinformacionSubcriterios.aspx.cs" Inherits="ReconocimientoAmbientalWeb.VisualizarIinformacionSubcriterios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
     <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#0000CC" Text="Listado de subcriterios"></asp:Label>
    <p>
        <br />
    </p>
    <p id="GVSub">
        <asp:GridView ID="GVSub" runat="server" AutoGenerateColumns="False" style="margin-left: 0px; margin-right: 17px" Width="684px">
            <Columns>
                <asp:BoundField DataField="idSubcriterio" HeaderText="ID" SortExpression="idSubcriterio" />
                <asp:BoundField DataField="nombreSubcriterio" HeaderText="Nombre" SortExpression="nombreSubcriterio" />
                <asp:BoundField DataField="descripcionSubcriterio" HeaderText="Descripcion" SortExpression="descripcionSubcriterio" />
            </Columns>
        </asp:GridView>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
