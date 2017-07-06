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
    public partial class AreaTematicaView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AreaTematicaBusiness areaBusiness = new AreaTematicaBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            areaBusiness.AgregarAreaTematica(TX_nombreArea.Text,TX_descripcionArea.Text,TX_siglaArea.Text);
        }
    }
}