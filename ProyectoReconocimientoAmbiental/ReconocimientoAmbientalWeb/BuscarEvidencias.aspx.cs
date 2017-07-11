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
    public partial class BuscarEvidencias : System.Web.UI.Page
    {

        private FuncionarioBusiness funcionarioBusiness = new FuncionarioBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
        private AreaTematicaBusiness areaTematicaBusiness = new AreaTematicaBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
        private CriterioBusiness criterioBusiness = new CriterioBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
        private SubcriterioBusiness subcriterioBusiness = new SubcriterioBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                cargarDatos();
            }
        }

        private void cargarDatos() {
            Session["username"] = "Juan Solís";

            AreaTematica area = areaTematicaBusiness.ObtenerAreaTematicaPorId(funcionarioBusiness.obtenerIdArea(Session["username"].ToString()));
            lblAreaActual.Text = area.NombreAreaTematica;

            ddlCriterio.DataSource = criterioBusiness.obtenerCriteriosPorIdArea(area.IdArea);
            ddlCriterio.DataTextField = "nombreCriterio";
            ddlCriterio.DataValueField = "idCriterio";
            ddlCriterio.DataBind();

        }

        protected void ddlCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatosSubcriterio();
        }

        protected void ddlCriterio_Load(object sender, EventArgs e)
        {
            cargarDatosSubcriterio();
        }

        private void cargarDatosSubcriterio() {
            ddlSubcriterio.DataSource = subcriterioBusiness.obtenerSubcriteriosPorIdCriterio(Int32.Parse(ddlCriterio.SelectedItem.Value));
            ddlSubcriterio.DataTextField = "nombreSubCriterio";
            ddlSubcriterio.DataValueField = "idSubcriterio";
            ddlSubcriterio.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            LinkedList<Evidencia> evidencias = criterioBusiness.obtenerEvidencias(Int32.Parse(ddlCriterio.SelectedItem.Value), Int32.Parse(ddlSubcriterio.SelectedItem.Value));
            GridView1.DataSource = evidencias;
            GridView1.DataBind();

        }
    }
}