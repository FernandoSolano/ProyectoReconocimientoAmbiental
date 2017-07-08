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

        public void obtenerRecinto()
        {
            String queryString = "SELECT ";
            SqlConnection connection = new SqlConnection(this.connectionString);
            DataSet dataSetRecinto = new DataSet();
            SqlDataAdapter dataAdapterRecinto = new SqlDataAdapter();
            dataAdapterRecinto.SelectCommand = new SqlCommand(queryString, connection);
            dataAdapterRecinto.Fill(dataSetRecinto, "Recinto");

            DataRowCollection rows = dataSetRecinto.Tables["Producto"].Rows;
            LinkedList<Producto> productos = new LinkedList<Producto>();
            foreach (DataRow row in rows)
            {
                FamiliaDeProducto familia = new FamiliaDeProducto(Int32.Parse(row["cod_familia"].ToString()), row["nombre_familia"].ToString());
                UnidadMedida unidad = new UnidadMedida(Int32.Parse(row["cod_unidad_medida"].ToString()), row["nombre_unidad"].ToString());
                productos.AddLast(
                    new Producto(
                        Int32.Parse(row["cod_producto"].ToString()),
                        Int32.Parse(row["cantidad_existencia"].ToString()),
                        row["nombre_producto"].ToString(),
                        float.Parse(row["precio"].ToString()),
                        bool.Parse(row["impuesto"].ToString()),
                        familia,
                        unidad
                    )
                );

            }
            return productos;
        }
    }
}
