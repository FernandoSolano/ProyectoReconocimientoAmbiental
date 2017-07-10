using ReconocimientoAmbientalLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Data
{
    public class EncargadoEvaluacionData
    {
        private String connectionString;

        public EncargadoEvaluacionData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void ActualizarEncargadoDeArea(int idArea, int idFuncionario, String nombreEncargado)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "sp_actualizar_encargado_area";
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@idArea", idArea));
            sqlCommand.Parameters.Add(new SqlParameter("@nombreEncargado", nombreEncargado));
            sqlCommand.Parameters.Add(new SqlParameter("@idFuncionario", idFuncionario));
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                sqlCommand.Connection = connection;
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
}
