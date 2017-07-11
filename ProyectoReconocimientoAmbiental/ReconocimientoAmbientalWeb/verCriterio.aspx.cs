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
    public partial class verCriterio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int id = Int32.Parse(Request.QueryString.Get("id"));
            CriterioBusiness criterioBusiness = new CriterioBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            DVcriterio.DataSource = criterioBusiness.obtenerCriterioPorId(id);
            DVcriterio.DataBind();
            

        }
    }
}