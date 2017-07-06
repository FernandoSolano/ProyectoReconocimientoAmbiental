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
    public partial class GuiaAmbientalView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GuiaBusiness guiaBusiness = new GuiaBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            guiaBusiness.IngresarGuiaAmbiental(Int32.Parse(TX_anoPublicacion.Text), Convert.ToDateTime(TX_anno.Text+"-"+TX_mes.Text+"-"+TX_dia.Text),TX_nombreGuia.Text);
        }
    }
}