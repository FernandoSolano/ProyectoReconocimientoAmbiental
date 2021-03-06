﻿using ReconocimientoAmbientalLibrary.Business;
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
    public partial class nuevaAccion : System.Web.UI.Page
    {
        private AccionBusiness accionBusiness;

        protected void Page_Load(object sender, EventArgs e)
        {
            accionBusiness = new AccionBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            if (Page.IsPostBack == false)
            {
                
                LinkedList<Subcriterio> subcriteriosLista = accionBusiness.ObtenerSubcriterios();
            
                foreach (Subcriterio subcriterio in subcriteriosLista)
                {
                    DropDownList1.Items.Add(subcriterio.NombreSubcriterio.ToString());
                    DropDownList1.DataValueField = subcriterio.IdSubcriterio.ToString();

                }//foreach
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                using (BinaryReader reader = new BinaryReader(FileUpload1.PostedFile.InputStream))
                {
                    byte[] image = reader.ReadBytes(FileUpload1.PostedFile.ContentLength);
                    accionBusiness.Insertar(Int32.Parse(DropDownList1.DataValueField), Txt_titulo.Text, txt_fecha.Text, txt_descripcion.Text, FileUpload1.FileName, FileUpload1.PostedFile.ContentType, image);
                }                
            }
            Response.Redirect("~/verAcciones.aspx");
        }
    }
}