<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipalFuncionario.Master" AutoEventWireup="true" CodeBehind="verCriterio.aspx.cs" Inherits="ReconocimientoAmbientalWeb.verCriterio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
     <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#0000CC" Text="Criterio seleccionado"></asp:Label>
     <br />
    <p>
        <br />
    </p>
    <p>
        <asp:DetailsView ID="DVcriterio" runat="server" AutoGenerateRows="False" Height="51px" Width="371px">
            <Fields>
                <asp:BoundField DataField="idCriterio" HeaderText="ID" SortExpression="idCriterio" />
                <asp:BoundField DataField="nombreCriterio" HeaderText="Nombre" SortExpression="nombreCriterio" />
                <asp:BoundField DataField="descripcionCriterio" HeaderText="Descripcion" SortExpression="descripcionCriterio" />
            </Fields>
        </asp:DetailsView>
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
