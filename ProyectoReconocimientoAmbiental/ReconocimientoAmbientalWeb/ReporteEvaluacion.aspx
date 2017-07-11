<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="ReporteEvaluacion.aspx.cs" Inherits="ReconocimientoAmbientalWeb.ReporteEvaluacion" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
     <asp:scriptmanager id="ScriptManager1" runat="server"/>
    <asp:Label ID="Label1" runat="server" Text="Reporte de Evaluación de Reconocimiento Ambiental" style="font-weight: 700"></asp:Label>

    <br />
    <br />
     Seleccione una de las evaluaciones existentes:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    
    <asp:DropDownList ID="ddlEvaluaciones" runat="server" Height="28px" style="margin-bottom: 0px" Width="209px">
    </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnGenerarReporte" runat="server" OnClick="btnGenerarReporte_Click" Text="Ver Reporte" />
    <br />
    <br />
    <br />
    &nbsp;
    <br />
     <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="660px" Visible="false">
     </rsweb:ReportViewer>
    <br />
    
    <br />
    <br />
</asp:Content>
