using ReconocimientoAmbientalLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Data
{
    public class CriterioData
    {
        private String cadenaConexion;

        public CriterioData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }//constructor

        public void AgregarCriterio(String nombreCriterio, String descripcionCriterio, int idArea)
        {
            SqlConnection sqlConnection1 = new SqlConnection(cadenaConexion);
            sqlConnection1.Open();
            SqlTransaction transaccion = sqlConnection1.BeginTransaction();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("sp_agregar_criterio", sqlConnection1, transaccion);//agrego mi procedimiento almacenado para utilizarlo
                cmd.CommandType = System.Data.CommandType.StoredProcedure;//indico que voy a utilizar un procedimiento almacenado

                //***aqui va el parametro que quiero enviarle al procedimiento
                cmd.Parameters.AddWithValue("@nombreCriterio", nombreCriterio);
                cmd.Parameters.AddWithValue("@descripcionCriterio", descripcionCriterio);
                cmd.Parameters.AddWithValue("@idArea", idArea);


                cmd.ExecuteNonQuery();//ejecuto el procedimiento almacenado

                transaccion.Commit();//si se ejecuta bien la transaccion hace el cambio en la base de datos=commit

            }//try
            catch (Exception ex)
            {
                transaccion.Rollback();//si se ejecuto mal que no haga ningun cambio en la base de datos
            }//catch
            sqlConnection1.Close();
        }//AgregarCriterio


        public LinkedList<Criterio> ObtenerCriterios()
        {

            //paso 1
            SqlConnection connection = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("sp_obtener_criterios", connection);
            connection.Open();
            SqlDataReader drCriterios = cmd.ExecuteReader();
            LinkedList<Criterio> criterios = new LinkedList<Criterio>();
            while (drCriterios.Read())
            {

                Criterio criterio = new Criterio();
                criterio.NombreCriterio = drCriterios["nombreCriterio"].ToString();
                criterio.IdCriterio =Int32.Parse (drCriterios["idCriterio"].ToString());

                criterios.AddLast(criterio);
            }//while
            connection.Close();
            return criterios;

        }//ObtenerCriterios()

        public LinkedList<Criterio> obtenerCriteriosPorIdArea(int idArea)
        {
            SqlConnection connection = new SqlConnection(this.cadenaConexion);
            string sqlProcedureObtenerCriterios = "obtener_criterio_por_id_area";
            SqlCommand comandoObtenerCriterios = new SqlCommand(sqlProcedureObtenerCriterios, connection);
            comandoObtenerCriterios.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerCriterios.Parameters.Add(new SqlParameter("@idArea", idArea));

            try
            {
                connection.Open();
                SqlDataReader drCriterio = comandoObtenerCriterios.ExecuteReader();
                LinkedList<Criterio> criterios = new LinkedList<Criterio>();
                while (drCriterio.Read())
                {

                    Criterio criterio = new Criterio();

                    criterio.IdCriterio = Int32.Parse(drCriterio["idCriterio"].ToString());
                    criterio.NombreCriterio = drCriterio["nombreCriterio"].ToString();
                    criterio.DescripcionCriterio = drCriterio["descripcionCriterio"].ToString();

                    criterios.AddLast(criterio);
                }//while
                connection.Close();
                return criterios;
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

    }//CriterioData

}//namespace
