<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipalFuncionario.Master" AutoEventWireup="true" CodeBehind="verSubcriterio.aspx.cs" Inherits="ReconocimientoAmbientalWeb.verSubcriterio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

     <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#0000CC" Text="Subcriterio seleccionado"></asp:Label>
     <br />
    <p>
        <br />
    </p>
    <p>
    </p>
    <p>
        <asp:DetailsView ID="DVsubcriterios" runat="server" AutoGenerateRows="False" Height="50px" Width="350px">
            <Fields>
                <asp:BoundField DataField="idSubcriterio" HeaderText="ID" SortExpression="idSubcriterio" />
                <asp:BoundField DataField="nombreSubcriterio" HeaderText="Nombre" SortExpression="nombreSubcriterio" />
                <asp:BoundField DataField="descripcionSubcriterio" HeaderText="Descripcion" SortExpression="descripcionSubcriterio" />
            </Fields>
        </asp:DetailsView>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
