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
    public partial class verActividades : System.Web.UI.Page
    {
        private ActividadBusiness actividadBusiness;

        protected void Page_Load(object sender, EventArgs e)
        {
            actividadBusiness = new ActividadBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            if (!IsPostBack)
            {
                cargarArchivos();
            }
        }

        public void cargarArchivos()
        {
            actividadBusiness.getAll(GridView1, Convert.ToString(Session["usuarioFuncionario"]));
        }
    }
}