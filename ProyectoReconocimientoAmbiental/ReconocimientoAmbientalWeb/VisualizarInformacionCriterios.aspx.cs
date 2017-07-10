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
    public partial class VisualizarInformacionCriterios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FuncionarioBusiness funcionarioBusiness = new FuncionarioBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            CriterioBusiness criterioBusiness = new CriterioBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);

            Session["usuarioFuncionario"] = "Juan Solís";
            GVCriterios.DataSource = criterioBusiness.obtenerCriteriosPorIdArea(funcionarioBusiness.obtenerIdArea(Session["usuarioFuncionario"].ToString()));
            GVCriterios.DataBind();
        }

        protected void irASubcriterios(object sender, EventArgs e)
        {
            int id = int.Parse((sender as LinkButton).CommandArgument);

            Response.Redirect("VisualizarIinformacionSubcriterios.aspx?id=" + id);
        }

        
    }
}