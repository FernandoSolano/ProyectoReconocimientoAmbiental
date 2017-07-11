using ReconocimientoAmbientalLibrary.Business;
using ReconocimientoAmbientalLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace ReconocimientoAmbientalWeb
{
    public partial class verDocumento : System.Web.UI.Page
    {
        private DocumentoBusiness documentoBusiness;
        private Documento documento;

        protected void Page_Load(object sender, EventArgs e)
        {
            documentoBusiness = new DocumentoBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            int idDocumento = Int32.Parse(Request.Params["idDocumento"]);
            documento = documentoBusiness.getDocumento(idDocumento);
            Label7.Text = documento.TipoDocumento;
            Label8.Text = documento.DetalleDocumento;
            Label9.Text = documento.FuenteEmisor;
            Label10.Text = documento.FechaEmision.ToString();
            Label11.Text = documento.NombreArchivo;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = documento.TypeFile;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + documento.NombreArchivo);
            Response.BinaryWrite(documento.DocumentoFile);
            Response.Flush();
            Response.End();
        }
    }
}