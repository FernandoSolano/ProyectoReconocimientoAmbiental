<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipalFuncionario.Master" AutoEventWireup="true" CodeBehind="VisualizarInformacionCriterios.aspx.cs" Inherits="ReconocimientoAmbientalWeb.VisualizarInformacionCriterios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#0000CC" Text="Listado de criterios"></asp:Label>
     <br />
    <br />
    <asp:GridView ID="GVCriterios" runat="server" AutoGenerateColumns="False" Width="654px" >
        <Columns>
            <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <asp:LinkButton HeaderText="Ver info" ID="lnkDownload1" runat="server" Text="Ver" OnClick="irACriterio" 
                            CommandArgument='<%# Eval("idCriterio") %>'></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            <asp:BoundField DataField="idCriterio" HeaderText="ID" SortExpression="idCriterio" />
            <asp:BoundField DataField="nombreCriterio" HeaderText="Nombre" SortExpression="nombreCriterio" />
            <asp:BoundField DataField="descripcionCriterio" HeaderText="Descripcion" SortExpression="descripcionCriterio" />
            <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <asp:LinkButton HeaderText="Ir a subcriterios" ID="lnkDownload" runat="server" Text="Ver subcriterios" OnClick="irASubcriterios" 
                            CommandArgument='<%# Eval("idCriterio") %>'></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
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
