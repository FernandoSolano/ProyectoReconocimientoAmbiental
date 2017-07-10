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
    public partial class AsignarResponsable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                AreaTematicaBusiness areatematicaBusiness = new AreaTematicaBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
                LinkedList<AreaTematica> areas = new LinkedList<AreaTematica>();
                areas = areatematicaBusiness.ObtenerAreasTematicas();
                ddlAreas.DataSource = areas;
                ddlAreas.DataTextField = "NombreAreaTematica";
                ddlAreas.DataValueField = "IdArea";
                ddlAreas.DataBind();
                ddlAreas.Items.Insert(0, new ListItem("Seleccionar"));
                ddlAreas.SelectedIndex = 0;
                lblHeadAreaSeleccionada.Visible = false;
                lblHeadDescripcion.Visible = false;
                lblHeadFuncionario.Visible = false;
                lblHeadAreaSeleccionada.Visible = false;
                lblArea.Visible = false;
                lblDescripcion.Visible = false;
                ddlFuncionarios.Visible = false;
                btnAsignar.Visible = false;
            }else
            {
                ddlAreas.Items.Remove("Seleccionar");
            }
        }

        protected void btnAsignar_Click(object sender, EventArgs e)
        {
            EncargadoEvaluacionBusiness encargadoEvaluacionBusiness = new EncargadoEvaluacionBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            encargadoEvaluacionBusiness.ActualizarEncargadoDeArea(Int32.Parse(ddlAreas.SelectedItem.Value), Int32.Parse(ddlFuncionarios.SelectedItem.Value), ddlFuncionarios.SelectedItem.Text);
            ddlFuncionarios.SelectedItem.Text = ddlFuncionarios.SelectedItem.Text + " (Asignado)";
        }

        protected void ddlAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblHeadAreaSeleccionada.Visible = true;
            lblHeadDescripcion.Visible = true;
            lblHeadFuncionario.Visible = true;
            lblHeadAreaSeleccionada.Visible = true;
            lblArea.Visible = true;
            lblDescripcion.Visible = true;
            ddlFuncionarios.Visible = true;
            btnAsignar.Visible = true;
            AreaTematicaBusiness areaTematicaBusiness = new AreaTematicaBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            FuncionarioBusiness funcionarioBusiness = new FuncionarioBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);

            Funcionario funcionario = new Funcionario();
            funcionario = funcionarioBusiness.ObtenerFuncionarioPorAreaAsignada(Int32.Parse(ddlAreas.SelectedItem.Value));
            lblArea.Text = areaTematicaBusiness.ObtenerAreaTematicaPorId(Int32.Parse(ddlAreas.SelectedItem.Value)).NombreAreaTematica+"";
            lblDescripcion.Text = areaTematicaBusiness.ObtenerAreaTematicaPorId(Int32.Parse(ddlAreas.SelectedItem.Value)).DescripcionArea + "";
            
            LinkedList<Funcionario> funcionarios = new LinkedList<Funcionario>();
            funcionarios = funcionarioBusiness.ObtenerFuncionariosDisponibles();
            ddlFuncionarios.DataSource = funcionarios;
            ddlFuncionarios.DataTextField = "NombreFuncionario";
            ddlFuncionarios.DataValueField = "IdFuncionario";
            ddlFuncionarios.DataBind();
            ddlFuncionarios.Items.Insert(0, new ListItem(funcionario.NombreFuncionario+" (Asignado)", funcionario.IdFuncionario+""));
            ddlFuncionarios.SelectedIndex = 0;
        }
    }
}