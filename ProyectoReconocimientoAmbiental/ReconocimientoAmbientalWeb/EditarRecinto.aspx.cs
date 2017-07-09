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
    public partial class EditarRecinto : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Recinto recinto = null;
                RecintoBusiness recintoBusiness = new RecintoBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
                recinto = recintoBusiness.obtenerRecinto();
                tbNombre.Text = recinto.NombreRecinto;
                tbDireccion.Text = recinto.DireccionRecinto;
                tbTelefono.Text = recinto.TelefonoRecinto;
                tbCorreo.Text = recinto.CorreoEectronicoRecinto;
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Recinto recinto = new Recinto();
            recinto.IdRecinto = 1;
            recinto.NombreRecinto = tbNombre.Text;
            recinto.DireccionRecinto = tbDireccion.Text;
            recinto.CorreoEectronicoRecinto = tbCorreo.Text;
            recinto.TelefonoRecinto = tbTelefono.Text;

            RecintoBusiness recintoBusiness = new RecintoBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            recintoBusiness.actualizarRecinto(recinto);
        }
    }
}