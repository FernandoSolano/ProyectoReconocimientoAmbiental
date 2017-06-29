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


    }//FuncionarioData

}//namespace
