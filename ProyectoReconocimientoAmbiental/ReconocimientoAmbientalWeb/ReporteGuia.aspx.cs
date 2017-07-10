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
            if (!IsPostBack) {

                this.guiaBusiness = new GuiaBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
                this.areaBusiness = new AreaTematicaBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
                this.criterioBusiness = new CriterioBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
                this.subcriterioBusiness = new SubcriterioBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
                
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
            Guia guia = guiaBusiness.obtenerGuisAmbiental(idGuia);
            // se traen los datos de las area asociadas a la guia
            LinkedList<AreaTematica> areas = areaBusiness.obtenerAreasPorIdGuia(guia.IdGuia);
            // se traen los criterios  asociados a el area tematica

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

            Console.Write("LALa LALa laa");

        }

    }
}