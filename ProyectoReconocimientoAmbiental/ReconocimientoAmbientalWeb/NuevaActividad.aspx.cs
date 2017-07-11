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
    public partial class NuevaActividad : System.Web.UI.Page
    {
        private ActividadBusiness actividadBusiness;
        private AccionBusiness accionBusiness;

        protected void Page_Load(object sender, EventArgs e)
        {
            accionBusiness = new AccionBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            actividadBusiness = new ActividadBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
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
                    actividadBusiness.Insertar(Int32.Parse(DropDownList1.DataValueField), Int32.Parse(txt_cantidad.Text), Txt_titulo.Text, txt_fecha.Text, txt_tipo.Text, txt_descripcion.Text, FileUpload1.FileName, FileUpload1.PostedFile.ContentType, image);
                }
            }
            Response.Redirect("~/verActividades.aspx");
        }
    }
}