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
    public partial class verAcciones : System.Web.UI.Page
    {

        private AccionBusiness accionBusiness;

        protected void Page_Load(object sender, EventArgs e)
        {
            accionBusiness = new AccionBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            if (!IsPostBack)
            {
                cargarArchivos();
            }
        }

        public void cargarArchivos()
        {

            accionBusiness.getAll(GridView1, Convert.ToString(Session["usuarioFuncionario"]));
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Accion accionSeleccionada = (Accion)GridView1.SelectedValue;
            //Producto productoSeleccionado = (Producto)GridView1.SelectedValue;
            //Response.Redirect("~/verAccion.apsx?idAccion=" + productoSeleccionado.CodProducto);
        }
    }
}