using ReconocimientoAmbientalLibrary.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReconocimientoAmbientalWeb
{
    public partial class verNormativas : System.Web.UI.Page
    {
        private NormativaBusiness normativaBusiness;

        protected void Page_Load(object sender, EventArgs e)
        {
            normativaBusiness = new NormativaBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            if (!IsPostBack)
            {
                cargarArchivos();
            }
        }

        public void cargarArchivos()
        {
            normativaBusiness.getAll(GridView1);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idAccionSeleccionado = (int)GridView1.SelectedValue;
            Response.Redirect("~/verAccion.aspx?idAccion=" + idAccionSeleccionado);
        }
    }
}