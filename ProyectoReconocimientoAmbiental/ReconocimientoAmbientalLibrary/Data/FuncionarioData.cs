using ReconocimientoAmbientalLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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

        public Funcionario RegistrarFuncionario(Funcionario funcionario)
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
        
        public LinkedList<Funcionario> ObtenerFuncionariosDisponibles()
        {
            SqlConnection connection = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("sp_obtener_funcionarios_no_asignados", connection);
            connection.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            LinkedList<Funcionario> funcionarios = new LinkedList<Funcionario>();
            while (dataReader.Read())
            {
                Funcionario funcionario = new Funcionario();
                funcionario.IdFuncionario = Int32.Parse(dataReader["idFuncionario"].ToString());
                funcionario.NombreFuncionario = dataReader["nombreFuncionario"].ToString();
                funcionarios.AddLast(funcionario);
            }
            connection.Close();
            return funcionarios;
        }

        public Funcionario ObtenerFuncionarioPorAreaAsignada(int codArea)
        {
            SqlConnection connection = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("sp_obtener_Funcionario_por_idArea", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@idArea", codArea));
            connection.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            Funcionario funcionario = new Funcionario();
            while (dataReader.Read())
            {
                funcionario.IdFuncionario = Int32.Parse(dataReader["idFuncionario"].ToString());
                funcionario.NombreFuncionario = dataReader["nombreFuncionario"].ToString();
            }
            connection.Close();
            return funcionario;
        }

    }//FuncionarioData

}//namespace
