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
    public partial class RegistroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = Request.QueryString["mensaje"];
            lblMensaje.Visible = true;
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.NombreFuncionario = tbNombre.Text;
            funcionario.UserName = tbNombre.Text;
            funcionario.Password = tbContrasenia.Text;
            funcionario.TelefonoFuncionario = tbTelefono.Text;
            funcionario.EmailFuncionario = tbEmail.Text;
            funcionario.Rol.IdRol = Int32.Parse(ddlRol.SelectedItem.Value);

            FuncionarioBusiness funcionarioBusiness = new FuncionarioBusiness(WebConfigurationManager.ConnectionStrings["PRA_DFGKP"].ConnectionString);
            funcionarioBusiness.registrarFuncionario(funcionario);
            String mensajeSalida = "Usuario ingresado con éxito";
            Response.Redirect("/RegistroUsuario.aspx?mensaje=" + mensajeSalida);
        }
    }
}