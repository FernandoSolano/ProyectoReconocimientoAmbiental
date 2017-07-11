<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="ReporteGuia.aspx.cs" Inherits="ReconocimientoAmbientalWeb.ReporteGuia" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <asp:scriptmanager id="ScriptManager1" runat="server"/>
    <asp:Label ID="Label1" runat="server" Text="Reporte de Guía de Reconocimiento Ambiental"></asp:Label>

    <br />
    <br />
    Seleccione una de las guías disponibles:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    
    <asp:DropDownList ID="ddlGuias" runat="server" Height="27px" style="margin-bottom: 0px" Width="239px">
    </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnGenerarReporte" runat="server" OnClick="btnGenerarReporte_Click" Text="Ver Reporte" />
    <br />
<br />
<br />
&nbsp;
<br />
<br />
    
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Height="438px" Width="662px" Visible="False" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt">
        <LocalReport ReportPath="ReporteGuia.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="dsArea" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="ReconocimientoAmbientalWeb.PRA_DFGKPDataSetTableAdapters.sp_generar_reporte_guiaTableAdapter"></asp:ObjectDataSource>
<br />
    <br />

</asp:Content>