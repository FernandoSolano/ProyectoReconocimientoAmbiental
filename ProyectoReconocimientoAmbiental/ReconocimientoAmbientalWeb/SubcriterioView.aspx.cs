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
    public partial class SubcriterioView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                CriterioBusiness criterioBusiness = new CriterioBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
                LinkedList<Criterio> criterio = criterioBusiness.ObtenerCriterios();

                //como llenar el DropDownList
                foreach (Criterio criterioLista in criterio)
                {
                    DDL_criterios.Items.Add(new ListItem(criterioLista.NombreCriterio.ToString()));
                    DDL_criterios.DataValueField = criterioLista.IdCriterio.ToString();
                }//foreach

            }//ispostback

        }//Page_Load

        protected void Button1_Click(object sender, EventArgs e)
        {
            SubcriterioBusiness subcriterioBusiness = new SubcriterioBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            subcriterioBusiness.AgregarSubcriterio(TX_nombreSubcriterio.Text,TX_descripcion.Text,Int32.Parse(DDL_criterios.DataValueField));
        }
    }
}