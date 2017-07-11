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
    public partial class MostrarSubcriterios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CriterioBusiness criterioBusiness = new CriterioBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
                LinkedList<Criterio> criterios = new LinkedList<Criterio>();
                criterios = criterioBusiness.ObtenerCriterios();
                ddlAreasCriterios.DataSource = criterios;
                ddlAreasCriterios.DataTextField = "NombreCriterio";
                ddlAreasCriterios.DataValueField = "IdCriterio";
                ddlAreasCriterios.DataBind();
                lblSeleccionBusqueda.Text = "Criterios:";
                SubcriterioBusiness subcriterioBusiness = new SubcriterioBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
                LinkedList<Subcriterio> subcriterios = new LinkedList<Subcriterio>();
                subcriterios = subcriterioBusiness.obtenerSubcriteriosPorIdCriterio(Int32.Parse(ddlAreasCriterios.SelectedItem.Value));
                gvCriterios.DataSource = subcriterios;
                gvCriterios.DataBind();
            }
        }

        protected void ddlTipoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTipoBusqueda.SelectedItem.Value == 1 + "")
            {
                CriterioBusiness criterioBusiness = new CriterioBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
                LinkedList<Criterio> criterios = new LinkedList<Criterio>();
                criterios = criterioBusiness.ObtenerCriterios();
                ddlAreasCriterios.DataSource = criterios;
                ddlAreasCriterios.DataTextField = "NombreCriterio";
                ddlAreasCriterios.DataValueField = "IdCriterio";
                ddlAreasCriterios.DataBind();
                lblSeleccionBusqueda.Text = "Criterios:";
                SubcriterioBusiness subcriterioBusiness = new SubcriterioBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
                LinkedList<Subcriterio> subcriterios = new LinkedList<Subcriterio>();
                subcriterios = subcriterioBusiness.obtenerSubcriteriosPorIdCriterio(Int32.Parse(ddlAreasCriterios.SelectedItem.Value));
                gvCriterios.DataSource = subcriterios;
                gvCriterios.DataBind();
            }
            else
            {
                AreaTematicaBusiness areaTematicaBusiness = new AreaTematicaBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
                LinkedList<AreaTematica> areas = new LinkedList<AreaTematica>();
                areas = areaTematicaBusiness.ObtenerAreasTematicas();
                ddlAreasCriterios.DataSource = areas;
                ddlAreasCriterios.DataTextField = "NombreAreaTematica";
                ddlAreasCriterios.DataValueField = "IdArea";
                ddlAreasCriterios.DataBind();
                lblSeleccionBusqueda.Text = "Áreas:";
                SubcriterioBusiness subcriterioBusiness = new SubcriterioBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
                LinkedList<Subcriterio> subcriterios = new LinkedList<Subcriterio>();
                subcriterios = subcriterioBusiness.obtenerSubcriteriosPorIdArea(Int32.Parse(ddlAreasCriterios.SelectedItem.Value));
                gvCriterios.DataSource = subcriterios;
                gvCriterios.DataBind();
            }
        }

        protected void ddlAreasCriterios_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubcriterioBusiness subcriterioBusiness = new SubcriterioBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            LinkedList<Subcriterio> subcriterios = new LinkedList<Subcriterio>();
            if (ddlTipoBusqueda.SelectedItem.Value == 1 + "")
            {
                subcriterios = subcriterioBusiness.obtenerSubcriteriosPorIdCriterio(Int32.Parse(ddlAreasCriterios.SelectedItem.Value));
            }
            else
            {
                subcriterios = subcriterioBusiness.obtenerSubcriteriosPorIdArea(Int32.Parse(ddlAreasCriterios.SelectedItem.Value));
            }
            gvCriterios.DataSource = subcriterios;
            gvCriterios.DataBind();
        }

    }
}