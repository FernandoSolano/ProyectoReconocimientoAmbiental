
﻿using Microsoft.Reporting.WebForms;
using ReconocimientoAmbientalLibrary.Business;
using ReconocimientoAmbientalLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReconocimientoAmbientalWeb
{
    public partial class ReporteGuia : System.Web.UI.Page
    {

        private GuiaBusiness guiaBusiness;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.guiaBusiness = new GuiaBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            if (!IsPostBack) {
                
                cargarGuias();
            }
        }
        
        private void cargarGuias() {
            ddlGuias.DataSource = guiaBusiness.obtenerGuiasAmbientales();
            this.ddlGuias.DataTextField = "nombreGuia";
            this.ddlGuias.DataValueField = "idGuia";
            ddlGuias.DataBind();
        }

        protected void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            // se obtiiene el id de la guia seleccionada
            int idGuia = Int32.Parse(ddlGuias.SelectedValue.ToString());

            DataTable datatable = guiaBusiness.getReporte(idGuia);
            ReportViewer1.Visible = true;
            ReportViewer1.LocalReport.ReportPath = @"C:\Users\dmadr\Source\Repos\ProyectoReconocimientoAmbiental\ProyectoReconocimientoAmbiental\ReconocimientoAmbientalWeb\ReporteGuia.rdlc";
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsArea", datatable));
            ReportViewer1.LocalReport.Refresh();
            
        }

    }
}