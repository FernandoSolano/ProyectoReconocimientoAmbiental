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
    public partial class AccesoFuncionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {

            }//IsPostBack
        }//Page_Load

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            FuncionarioBusiness funcionarioBusiness = new FuncionarioBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            int acceso = funcionarioBusiness.iniciarSesion(tbNombreUsuario.Text, tbContrasenia.Text);

            if (acceso == 0)
            {
                LBmensaje.Text = "Lo siento, no puedes iniciar sesión";
            }//if
            if (acceso == 2)
            {
                Session["usuarioFuncionario"] = tbNombreUsuario.Text;
                LBmensaje.Text = "Iniciaste sesión con éxito";
                //Response.Redirect("/AccesoFuncionario.aspx");
                Response.Redirect("/Default.aspx");
            }//else
        }
    }
}