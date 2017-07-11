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
    public partial class verSubcriterio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString.Get("id"));
            SubcriterioBusiness subcriterioBusiness = new SubcriterioBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            DVsubcriterios.DataSource = subcriterioBusiness.obtenerSubcriterioPorId(id);
            DVsubcriterios.DataBind();
        }
    }
}