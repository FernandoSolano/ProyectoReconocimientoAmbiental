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
    public partial class CriterioView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                AreaTematicaBusiness areaTematicaBusiness = new AreaTematicaBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
                LinkedList<AreaTematica> areas = areaTematicaBusiness.ObtenerAreasTematicas();          

                //como llenar el DropDownList
                foreach (AreaTematica areaTematica in areas)
                {
                    DDL_areaTematica.Items.Add(new ListItem(areaTematica.NombreAreaTematica.ToString()));
                    DDL_areaTematica.DataValueField = areaTematica.IdArea.ToString();
                }//foreach

            }//ispostback
        }//Page_Load

        protected void Button1_Click(object sender, EventArgs e)
        {
            CriterioBusiness criterioBusiness = new CriterioBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            criterioBusiness.AgregarCriterio(TX_nombreCriterio.Text,TX_descripcionCriterio.Text,Int32.Parse(DDL_areaTematica.DataValueField));
        }
    }
}