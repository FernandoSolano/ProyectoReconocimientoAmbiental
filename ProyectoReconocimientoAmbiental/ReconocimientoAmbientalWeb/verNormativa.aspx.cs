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
    public partial class verNormativa : System.Web.UI.Page
    {
        private NormativaBusiness normativaBusiness;
        private Normativa normativa;

        protected void Page_Load(object sender, EventArgs e)
        {
            normativaBusiness = new NormativaBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            int idNormativa = Int32.Parse(Request.Params["idNormativa"]);
            normativa = normativaBusiness.getNormativa(idNormativa);
            Label4.Text = normativa.DetalleNormativa;
            Label5.Text = normativa.NombreArchivo;
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = normativa.TipoArchivo;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + normativa.NombreArchivo);
            Response.BinaryWrite(normativa.NormativaArchivo);
            Response.Flush();
            Response.End();
        }
    }
}