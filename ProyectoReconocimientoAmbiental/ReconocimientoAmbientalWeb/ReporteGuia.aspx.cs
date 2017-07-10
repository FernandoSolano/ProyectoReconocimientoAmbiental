using Microsoft.Reporting.WebForms;
using ReconocimientoAmbientalLibrary.Business;
using ReconocimientoAmbientalLibrary.Domain;
using System;
using System.Collections.Generic;
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
        private AreaTematicaBusiness areaBusiness;
        private CriterioBusiness criterioBusiness;
        private SubcriterioBusiness subcriterioBusiness;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.guiaBusiness = new GuiaBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            this.areaBusiness = new AreaTematicaBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            this.criterioBusiness = new CriterioBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            this.subcriterioBusiness = new SubcriterioBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);

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

            // se traen de la bd los datos de la guia
            LinkedList<Guia> guias = guiaBusiness.obtenerGuisAmbiental(idGuia);
            // se traen los datos de las area asociadas a la guia
            LinkedList<AreaTematica> areas = areaBusiness.obtenerAreasPorIdGuia(guias.First.Value.IdGuia);
            // se traen los criterios  asociados a el area tematica
            LinkedList<Criterio> criterios = new LinkedList<Criterio>();
            foreach (AreaTematica area in areas)
            {
                area.Criterios = criterioBusiness.obtenerCriteriosPorIdArea(area.IdArea);
            }
            // se traen los subcriterios por criterio en cada area tematica de una guia

            foreach (AreaTematica area in areas)
            {
                foreach (Criterio criterio in area.Criterios)
                {
                    criterio.Subcriterios = subcriterioBusiness.obtenerSubcriteriosPorIdCriterio(criterio.IdCriterio);
                }
            }

            // ahora se pasan lo datos anidados de area a lista externas
            LinkedList<Criterio> listaCriterios = new LinkedList<Criterio>();
            LinkedList<Subcriterio> listaSubcriterios = new LinkedList<Subcriterio>();

            foreach (AreaTematica area in areas)
            {
                foreach (Criterio criterio in area.Criterios)
                {
                    foreach (Subcriterio subcriterio in criterio.Subcriterios)
                    {
                        listaSubcriterios.AddLast(subcriterio);
                    }
                    listaCriterios.AddLast(criterio);
                }
            }

            ReportDataSource dsGuia = new ReportDataSource("dsGuia", guias);

            ReportDataSource dsArea = new ReportDataSource("dsArea", areas);

            ReportDataSource dsCriterio = new ReportDataSource("dsCriterio", listaCriterios);

            ReportDataSource dsSubcreiterio = new ReportDataSource("dsSubcriterios", listaSubcriterios);

            ReportViewer1.ProcessingMode = ProcessingMode.Local;
            ReportViewer1.LocalReport.ReportPath = @"C:\Users\dmadr\Source\Repos\ProyectoReconocimientoAmbiental\ProyectoReconocimientoAmbiental\ReconocimientoAmbientalLibrary\Reports\GuiaAmbientalReport.rdlc";
            ReportViewer1.LocalReport.DataSources.Add(dsGuia);
            ReportViewer1.LocalReport.DataSources.Add(dsArea);
            ReportViewer1.LocalReport.DataSources.Add(dsCriterio);
            ReportViewer1.LocalReport.DataSources.Add(dsSubcreiterio);

            ReportViewer1.LocalReport.Refresh();
            //se hace visible el reporte en la vista
            ReportViewer1.Visible = true;
            
        }

    }
}