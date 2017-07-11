using Microsoft.Reporting.WebForms;
using ReconocimientoAmbientalLibrary.Business;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReconocimientoAmbientalWeb
{
    public partial class ReporteEvaluacion : System.Web.UI.Page
    {
        private EvaluacionBusiness evaluacionBusiness;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.evaluacionBusiness = new EvaluacionBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);

            if (!IsPostBack) {
                cargarEvaluaciones();
            }
        }

        private void cargarEvaluaciones() {
            ddlEvaluaciones.DataSource = evaluacionBusiness.obtenerEvaluaciones();
            this.ddlEvaluaciones.DataTextField = "fechaFinal";
            this.ddlEvaluaciones.DataValueField = "codigoEvaluacion";
            ddlEvaluaciones.DataBind();
        }

        protected void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            // se obtiiene el id de la guia seleccionada
            int codEvaluacion = Int32.Parse(ddlEvaluaciones.SelectedValue.ToString());

            DataTable datatable = evaluacionBusiness.getReporte(codEvaluacion);
            ReportViewer1.Visible = true;
            ReportViewer1.LocalReport.ReportPath = @"C:\Users\dmadr\Source\Repos\ProyectoReconocimientoAmbiental\ProyectoReconocimientoAmbiental\ReconocimientoAmbientalWeb\ReporteEvaluacion.rdlc";
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", datatable));
            ReportViewer1.LocalReport.Refresh();
            
        }
    }
}