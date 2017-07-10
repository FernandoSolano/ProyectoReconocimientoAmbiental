using ReconocimientoAmbientalLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Data
{
    public class FuncionarioData
    {
        private String cadenaConexion;

        public FuncionarioData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }//constructor

        public int iniciarSesion(String usuario, String contrasena)
        {

            //paso 1
            SqlCommand cmd;
            SqlConnection connection = new SqlConnection(cadenaConexion);
            connection.Open();
            cmd = new SqlCommand("sp_iniciar_sesion", connection);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@contrasena", contrasena);
            cmd.ExecuteNonQuery();

            SqlDataReader drFuncionarios = cmd.ExecuteReader();

            while (drFuncionarios.Read())
            {

                int rol = Int32.Parse(drFuncionarios["idRol"].ToString());
                
                connection.Close();
                return rol;

            }//while
            connection.Close();
            return 0;

        }//iniciarSesion()

        public Funcionario registrarFuncionario(Funcionario funcionario)
        {
            SqlConnection connection = new SqlConnection(cadenaConexion);
            SqlCommand sqlCommand = new SqlCommand("sp_insertar_funcionario", connection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@nombreFuncionario", funcionario.NombreFuncionario));
            sqlCommand.Parameters.Add(new SqlParameter("@username", funcionario.UserName));
            sqlCommand.Parameters.Add(new SqlParameter("@password", funcionario.Password));
            sqlCommand.Parameters.Add(new SqlParameter("@telefonoFuncionario", funcionario.TelefonoFuncionario));
            sqlCommand.Parameters.Add(new SqlParameter("@emailFuncionario", funcionario.EmailFuncionario));
            sqlCommand.Parameters.Add(new SqlParameter("@idRol", funcionario.Rol.IdRol));
            SqlParameter idFuncionarioParameter = new SqlParameter("@idFuncionario", System.Data.SqlDbType.Int);
            idFuncionarioParameter.Direction = System.Data.ParameterDirection.Output;
            sqlCommand.Parameters.Add(idFuncionarioParameter);
            try
            {
                connection.Open();
                sqlCommand.ExecuteNonQuery();
                funcionario.IdFuncionario = Int32.Parse(sqlCommand.Parameters["@idFuncionario"].Value.ToString());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            if (connection != null)
            {
                connection.Close();
            }
            return funcionario;
        }

        public int obtenerIdArea(String userName)
        {
            SqlConnection connection = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("sp_obtener_area_funcionario", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@username",userName));
            connection.Open();
            SqlDataReader drIdArea = cmd.ExecuteReader();
           int numArea=0;
            while (drIdArea.Read())
            {
                numArea = Int32.Parse(drIdArea["idArea"].ToString());
            }
            connection.Close();

            return numArea;

        }
    }//FuncionarioData



}//namespace
