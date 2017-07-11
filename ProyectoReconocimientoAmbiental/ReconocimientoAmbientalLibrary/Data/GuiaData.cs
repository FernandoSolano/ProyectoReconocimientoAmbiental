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
    public class GuiaData
    {
        private String cadenaConexion;

        public GuiaData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }//constructor


        public void IngresarGuiaAmbiental(int annoPublicacion, DateTime fechaCreacion, String nombreGuia)
        {
            SqlConnection sqlConnection1 = new SqlConnection(cadenaConexion);
            sqlConnection1.Open();
            SqlTransaction transaccion = sqlConnection1.BeginTransaction();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("sp_ingresar_guia_ambiental", sqlConnection1, transaccion);//agrego mi procedimiento almacenado para utilizarlo
                cmd.CommandType = System.Data.CommandType.StoredProcedure;//indico que voy a utilizar un procedimiento almacenado

                //***aqui va el parametro que quiero enviarle al procedimiento
                cmd.Parameters.AddWithValue("@annoPublicacion", annoPublicacion);
                cmd.Parameters.AddWithValue("@nombreGuia", nombreGuia);
                cmd.Parameters.AddWithValue("@fechaCreacion", fechaCreacion);
              

                cmd.ExecuteNonQuery();//ejecuto el procedimiento almacenado

                transaccion.Commit();//si se ejecuta bien la transaccion hace el cambio en la base de datos=commit

            }//try
            catch (Exception ex)
            {
                transaccion.Rollback();//si se ejecuto mal que no haga ningun cambio en la base de datos
            }//catch
            sqlConnection1.Close();
        }

        public List<Guia> ObtenerGuiasAmbientales() {

            List<Guia> guias = new List<Guia>();

            SqlConnection connection = new SqlConnection(this.cadenaConexion);
            string sqlProcedureObtenerGuias = "obtener_guias";
            SqlCommand comandoObtenerGuias = new SqlCommand(sqlProcedureObtenerGuias, connection);
            comandoObtenerGuias.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerGuias.ExecuteReader();
                Guia guia;
                while (dataReader.Read())
                {
                    guia = new Guia();

                    guia.IdGuia = Int32.Parse(dataReader["idGuia"].ToString());
                    guia.AnnoPublicacion = Int32.Parse(dataReader["annoPublicacion"].ToString());
                    guia.Vigente = bool.Parse(dataReader["vigente"].ToString());
                    guia.NombreGuia = dataReader["nombreGuia"].ToString();
                    guia.FechaCreacion = DateTime.Parse(dataReader["fechaCreacion"].ToString());

                    guias.Add(guia);
                }
                connection.Close();
                return guias;
            }
            catch (SqlException exc)
            {
                throw exc;
            }
            finally
            {
                connection.Close();
            }

        }

        public LinkedList<Guia> ObtenerGuiaAmbiental(int idGuia)
        {
            
            SqlConnection connection = new SqlConnection(this.cadenaConexion);
            string sqlProcedureObtenerGuia = "obtener_guia_por_id";
            SqlCommand comandoObtenerGuia = new SqlCommand(sqlProcedureObtenerGuia, connection);
            comandoObtenerGuia.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerGuia.Parameters.Add(new SqlParameter("@idGuia", idGuia));
            LinkedList<Guia> guias = new LinkedList<Guia>();
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerGuia.ExecuteReader();
                Guia guia = new Guia();

                while (dataReader.Read()) {
                    guia.IdGuia = Int32.Parse(dataReader["idGuia"].ToString());
                    guia.AnnoPublicacion = Int32.Parse(dataReader["annoPublicacion"].ToString());
                    guia.Vigente = bool.Parse(dataReader["vigente"].ToString());
                    guia.NombreGuia = dataReader["nombreGuia"].ToString();
                    guia.FechaCreacion = DateTime.Parse(dataReader["fechaCreacion"].ToString());

                    guias.AddLast(guia);
                }
                connection.Close();
                return guias;
            }
            catch (SqlException exc)
            {
                throw exc;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable getReporte(int idGuia)
        {
            DataTable ResultsTable = new DataTable();

            SqlConnection conn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand("sp_generar_reporte_guia", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idGuia", idGuia);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ResultsTable);
            }

            catch (Exception ex)
            {
                Console.Write(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return ResultsTable;
        }

    }//GuiaData

}//namespace
