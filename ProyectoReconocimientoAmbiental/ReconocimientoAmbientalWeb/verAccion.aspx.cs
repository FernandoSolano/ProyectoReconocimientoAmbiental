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
    public partial class verAccion : System.Web.UI.Page
    {
        private AccionBusiness accionBusiness;
        private Accion accion;

        protected void Page_Load(object sender, EventArgs e)
        {
            accionBusiness = new AccionBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            int idAccion = Int32.Parse(Request.Params["idAccion"]);
            accion = accionBusiness.getAccion(idAccion);
            Label2.Text = accion.IdAccion.ToString();
            Label3.Text = accion.DetalleAccion;
            Label4.Text = accion.NombreArchivo;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = accion.TipoArchivo;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + accion.NombreArchivo);
            Response.BinaryWrite(accion.InformeTecnico);
            Response.Flush();
            Response.End();
        }
    }
}