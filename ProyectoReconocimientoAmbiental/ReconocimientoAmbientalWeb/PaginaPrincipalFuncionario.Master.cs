using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReconocimientoAmbientalWeb
{
    public partial class PaginaPrincipalFuncionario : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string usuario;
            if (Page.IsPostBack == false)
            {
                usuario = Convert.ToString(Session["usuarioFuncionario"]);

                if (Convert.ToString(Session["usuarioFuncionario"]) != "")
                {
                    LinkAbrirSesion.Visible = false;
                    LinkCerrarSesion.Visible = true;
                    LBususesion.Text = Convert.ToString(Session["usuarioFuncionario"]);
                    MenuEvidencia.Enabled = true;
                    MenuAreaTematica.Enabled = true;
                    MenuCriterio.Enabled = true;
                    MenuSubcriterio.Enabled = true;
        
                }//if si existe sesion
                if (Convert.ToString(Session["usuarioFuncionario"]) == "")
                {
                    LinkAbrirSesion.Visible = true;
                    LinkCerrarSesion.Visible = false;
                    LBususesion.Text = "";
                    MenuEvidencia.Enabled = false;
                    MenuAreaTematica.Enabled = false;
                    MenuCriterio.Enabled = false;
                    MenuSubcriterio.Enabled = false;
                }//if si existe sesion
            }//IsPostBack
        }//Page_Load

        protected void LinkCerrarSesion_Click(object sender, EventArgs e)
        {
            LinkCerrarSesion.Visible = false;
            LinkAbrirSesion.Visible = true;
            Session["usuarioFuncionario"] = "";
            Response.Redirect("/AccesoFuncionario.aspx");
        }
    }
}