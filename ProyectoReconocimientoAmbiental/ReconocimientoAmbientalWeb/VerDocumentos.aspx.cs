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
    public partial class VerDocumentos : System.Web.UI.Page
    {
        private DocumentoBusiness documentoBusiness;

        protected void Page_Load(object sender, EventArgs e)
        {
            documentoBusiness = new DocumentoBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            if (!IsPostBack)
            {
                cargarArchivos();
            }
        }

        public void cargarArchivos()
        {
            documentoBusiness.getAll(GridView1);
        }
    }
}