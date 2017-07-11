using ReconocimientoAmbientalLibrary.Data;
using ReconocimientoAmbientalLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Business
{
    public class FuncionarioBusiness
    {
        private FuncionarioData funcionarioData;

        public FuncionarioBusiness(String cadenaConexion)
        {
            this.funcionarioData = new FuncionarioData(cadenaConexion);
        }//constructor

        public int iniciarSesion(String usuario, String contrasena)
        {
            return this.funcionarioData.iniciarSesion(usuario,contrasena);
        }//iniciarSesion

        public Funcionario registrarFuncionario(Funcionario funcionario)
        {
            return funcionarioData.RegistrarFuncionario(funcionario);
        }

        public LinkedList<Funcionario> ObtenerFuncionariosDisponibles()
        {
            return funcionarioData.ObtenerFuncionariosDisponibles();
        }

        public Funcionario ObtenerFuncionarioPorAreaAsignada(int codArea)
        {
            return funcionarioData.ObtenerFuncionarioPorAreaAsignada(codArea);
        }


        public int obtenerIdArea(String userName)
        {
            return funcionarioData.obtenerIdArea(userName);
        }

    }//FuncionarioBusiness

}//namespace
