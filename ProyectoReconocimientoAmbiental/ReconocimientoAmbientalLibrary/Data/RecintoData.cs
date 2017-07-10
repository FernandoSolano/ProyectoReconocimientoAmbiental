using ReconocimientoAmbientalLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Data
{
    public class RecintoData
    {
        private String connectionString;

        public RecintoData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void actualizarRecinto(Recinto recinto)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand("sp_actualizar_recinto", connection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@idRecinto", recinto.IdRecinto));
            sqlCommand.Parameters.Add(new SqlParameter("@nombreRecinto", recinto.NombreRecinto));
            sqlCommand.Parameters.Add(new SqlParameter("@correoElectronicoRecinto", recinto.CorreoEectronicoRecinto));
            sqlCommand.Parameters.Add(new SqlParameter("@telefonoRecinto", recinto.TelefonoRecinto));
            sqlCommand.Parameters.Add(new SqlParameter("@direccionRecinto", recinto.DireccionRecinto));
            try
            {
                connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            if (connection != null)
            {
                connection.Close();
            }
        }

        public Recinto obtenerRecinto()
        {
            String queryString = "SELECT TOP(1) * FROM Recinto";
            SqlConnection connection = new SqlConnection(this.connectionString);
            DataSet dataSetRecinto = new DataSet();
            SqlDataAdapter dataAdapterRecinto = new SqlDataAdapter();
            dataAdapterRecinto.SelectCommand = new SqlCommand(queryString, connection);
            dataAdapterRecinto.Fill(dataSetRecinto, "Recinto");

            DataRowCollection rows = dataSetRecinto.Tables["Recinto"].Rows;

            Recinto recinto = new Recinto();
            foreach (DataRow row in rows)
            {
                recinto.IdRecinto = Int32.Parse(row["idRecinto"].ToString());
                recinto.NombreRecinto = row["nombreRecinto"].ToString();
                recinto.TelefonoRecinto = row["telefonoRecinto"].ToString();
                recinto.CorreoEectronicoRecinto = row["correoElectronicoRecinto"].ToString();
                recinto.DireccionRecinto = row["direccionRecinto"].ToString();
            }
            return recinto;
        }

        public Recinto obtenerRecintoPorCodigo(int codigo)
        {
            String queryString = "SELECT TOP(1) * FROM Recinto WHERE idRecinto="+codigo;
            SqlConnection connection = new SqlConnection(this.connectionString);
            DataSet dataSetRecinto = new DataSet();
            SqlDataAdapter dataAdapterRecinto = new SqlDataAdapter();
            dataAdapterRecinto.SelectCommand = new SqlCommand(queryString, connection);
            dataAdapterRecinto.Fill(dataSetRecinto, "Recinto");

            DataRowCollection rows = dataSetRecinto.Tables["Recinto"].Rows;

            Recinto recinto = new Recinto();
            foreach (DataRow row in rows)
            {
                recinto.IdRecinto = Int32.Parse(row["idRecinto"].ToString());
                recinto.NombreRecinto = row["nombreRecinto"].ToString();
                recinto.TelefonoRecinto = row["telefonoRecinto"].ToString();
                recinto.CorreoEectronicoRecinto = row["correoElectronicoRecinto"].ToString();
                recinto.DireccionRecinto = row["direccionRecinto"].ToString();
            }
            return recinto;
        }
    }
}
