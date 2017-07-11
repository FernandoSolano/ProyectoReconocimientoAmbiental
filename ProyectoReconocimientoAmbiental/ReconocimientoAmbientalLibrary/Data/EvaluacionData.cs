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
    public class EvaluacionData
    {
        private String cadenaConexion;

        public EvaluacionData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        public LinkedList<Evaluacion> obtenerEvaluaciones() {
            
            LinkedList<Evaluacion> evaluaciones = new LinkedList<Evaluacion>();

            SqlConnection connection = new SqlConnection(this.cadenaConexion);
            string sqlProcedureObtener = "obtener_evaluaciones";
            SqlCommand comandoObtener = new SqlCommand(sqlProcedureObtener, connection);
            comandoObtener.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtener.ExecuteReader();
                Evaluacion evaluacion;
                while (dataReader.Read())
                {
                    evaluacion = new Evaluacion();

                    evaluacion.CodigoEvaluacion = Int32.Parse(dataReader["codEvaluacion"].ToString());
                    evaluacion.FechaInicio = DateTime.Parse(dataReader["fechaInicio"].ToString());
                    evaluacion.FechaFinal = DateTime.Parse(dataReader["fechaFinal"].ToString());
                    
                    evaluaciones.AddLast(evaluacion);
                }
                connection.Close();
                return evaluaciones;
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

        public DataTable getReporte(int codEvaluacion)
        {
            DataTable ResultsTable = new DataTable();

            SqlConnection conn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand("sp_generar_reporte_evaluacion", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codEvaluacion", codEvaluacion);
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
    }
}
