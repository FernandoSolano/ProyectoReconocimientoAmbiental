using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReconocimientoAmbientalWeb
{
    public partial class PaginaPrincipal : System.Web.UI.MasterPage
    {
        string usuario;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                usuario = Convert.ToString(Session["usuario"]);

                if (Convert.ToString(Session["usuario"]) != "")
                {
                    LinkAbrirSesion.Visible=false;
                    LinkCerrarSesion.Visible = true;
                    LBususesion.Text= Convert.ToString(Session["usuario"]);
                    MenuGuiaAmbiental.Enabled = true;
                    MenuUsuarios.Enabled = true;
                    MenuResponsableArea.Enabled = true;
                    MenuEvaluacion.Enabled = true;
                    MenuRecinto.Enabled = true;
                }//if si existe sesion
                if (Convert.ToString(Session["usuario"]) == "")
                {
                    LinkAbrirSesion.Visible = true;
                    LinkCerrarSesion.Visible = false;
                    LBususesion.Text = "";
                    MenuGuiaAmbiental.Enabled = false;
                    MenuUsuarios.Enabled = false;
                    MenuResponsableArea.Enabled = false;
                    MenuEvaluacion.Enabled = false;
                    MenuRecinto.Enabled = false;
                }//if si existe sesion
            }//IsPostBack
            
        }//Page_Load

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

        protected void LinkCerrarSesion_Click(object sender, EventArgs e)
        {
            LinkCerrarSesion.Visible = false;
            LinkAbrirSesion.Visible = true;
            Session["usuario"] = "";
            Response.Redirect("/Acceso.aspx");
        }

        protected void Menu3_MenuItemClick(object sender, MenuEventArgs e)
        {

        }
    }
}