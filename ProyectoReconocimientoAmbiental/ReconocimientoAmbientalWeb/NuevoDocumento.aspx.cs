using ReconocimientoAmbientalLibrary.Business;
using ReconocimientoAmbientalLibrary.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReconocimientoAmbientalWeb
{
    public partial class NuevoDocumento : System.Web.UI.Page
    {
        private DocumentoBusiness documentoBusiness;
        private AccionBusiness accionBusiness;

        protected void Page_Load(object sender, EventArgs e)
        {
            documentoBusiness = new DocumentoBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            accionBusiness = new AccionBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);

            if (Page.IsPostBack == false)
            {
                LinkedList<Subcriterio> subcriteriosLista = accionBusiness.ObtenerSubcriterios();
                foreach (Subcriterio subcriterio in subcriteriosLista)
                {
                    DropDownList1.Items.Add(subcriterio.NombreSubcriterio.ToString());
                    DropDownList1.DataValueField = subcriterio.IdSubcriterio.ToString();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                using (BinaryReader reader = new BinaryReader(FileUpload1.PostedFile.InputStream))
                {
                    byte[] image = reader.ReadBytes(FileUpload1.PostedFile.ContentLength);
                    documentoBusiness.Insertar(Int32.Parse(DropDownList1.DataValueField), Txt_titulo.Text, txt_fechaRealizacion.Text, txt_tipo.Text,
                        txt_detalle.Text, txt_fechaEmision.Text, txt_emisor.Text, FileUpload1.FileName, FileUpload1.PostedFile.ContentType, image);
                }
            }
            Response.Redirect("~/verDocumentos.aspx");
        }
    }
}