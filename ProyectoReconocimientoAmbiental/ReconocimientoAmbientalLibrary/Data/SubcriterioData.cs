using ReconocimientoAmbientalLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Data
{
    public class SubcriterioData
    {
        private String cadenaConexion;

        public SubcriterioData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }//constructor

        public void AgregarSubcriterio(String nombreSubcriterio, String descripcionSubcriterio, int idCriterio)
        {
            SqlConnection sqlConnection1 = new SqlConnection(cadenaConexion);
            sqlConnection1.Open();
            SqlTransaction transaccion = sqlConnection1.BeginTransaction();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("sp_agregar_subcriterio", sqlConnection1, transaccion);//agrego mi procedimiento almacenado para utilizarlo
                cmd.CommandType = System.Data.CommandType.StoredProcedure;//indico que voy a utilizar un procedimiento almacenado

                //***aqui va el parametro que quiero enviarle al procedimiento
                cmd.Parameters.AddWithValue("@nombreSubcriterio", nombreSubcriterio);
                cmd.Parameters.AddWithValue("@descripcionSubcriterio", descripcionSubcriterio);
                cmd.Parameters.AddWithValue("@idCriterio", idCriterio);


                cmd.ExecuteNonQuery();//ejecuto el procedimiento almacenado

                transaccion.Commit();//si se ejecuta bien la transaccion hace el cambio en la base de datos=commit

            }//try
            catch (Exception ex)
            {
                transaccion.Rollback();//si se ejecuto mal que no haga ningun cambio en la base de datos
            }//catch
            sqlConnection1.Close();
        }//AgregarSubcriterio


        public LinkedList<Subcriterio> ObtenerSubcriterios()
        {

            //paso 1
            SqlConnection connection = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("sp_obtener_subcriterios", connection);
            connection.Open();
            SqlDataReader drSubcriterios = cmd.ExecuteReader();
            LinkedList<Subcriterio> subcriterios = new LinkedList<Subcriterio>();
            while (drSubcriterios.Read())
            {

                Subcriterio subcriterio = new Subcriterio();
                subcriterio.NombreSubcriterio = drSubcriterios["nombreSubcriterio"].ToString();

                subcriterios.AddLast(subcriterio);
            }//while
            connection.Close();
            return subcriterios;

        }//ObtenerSubcriterios()

        public LinkedList<Subcriterio> obtenerSubcriteriosPorIdCriterio(int idCriterio)
        {
            SqlConnection connection = new SqlConnection(this.cadenaConexion);
            string sqlProcedureObtenerSubcriterios = "obtener_Subcriterio_por_id_criterio";
            SqlCommand comandoObtenerSucriterios = new SqlCommand(sqlProcedureObtenerSubcriterios, connection);
            comandoObtenerSucriterios.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerSucriterios.Parameters.Add(new SqlParameter("@idCriterio", idCriterio));

            try
            {
                connection.Open();
                SqlDataReader drSucriterio = comandoObtenerSucriterios.ExecuteReader();
                LinkedList<Subcriterio> subcriterios = new LinkedList<Subcriterio>();
                while (drSucriterio.Read())
                {

                    Subcriterio subcriterio = new Subcriterio();

                    subcriterio.IdSubcriterio = Int32.Parse(drSucriterio["idSubcriterio"].ToString());
                    subcriterio.NombreSubcriterio = drSucriterio["nombreSubcriterio"].ToString();
                    subcriterio.DescripcionSubcriterio = drSucriterio["descripcionSubcriterio"].ToString();

                    subcriterios.AddLast(subcriterio);
                }//while
                connection.Close();
                return subcriterios;
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

        public LinkedList<Subcriterio> obtenerSubcriterioPorId(int id)
        {
            SqlConnection connection = new SqlConnection(this.cadenaConexion);
            string sqlProcedureObtenerCriterios = "get_subcriterio_por_id";
            SqlCommand comandoObtenerCriterios = new SqlCommand(sqlProcedureObtenerCriterios, connection);
            comandoObtenerCriterios.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerCriterios.Parameters.Add(new SqlParameter("@idSubcriterio", id));

            try
            {
                connection.Open();
                SqlDataReader drCriterio = comandoObtenerCriterios.ExecuteReader();
                LinkedList<Subcriterio> subcriterios = new LinkedList<Subcriterio>();
                while (drCriterio.Read())
                {

                    Subcriterio subcriterio = new Subcriterio();

                    subcriterio.IdSubcriterio = Int32.Parse(drCriterio["idSubcriterio"].ToString());
                    subcriterio.NombreSubcriterio = drCriterio["nombreSubcriterio"].ToString();
                    subcriterio.DescripcionSubcriterio = drCriterio["descripcionSubcriterio"].ToString();

                    subcriterios.AddLast(subcriterio);
                }//while
                connection.Close();
                return subcriterios;
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

    }//SubcriterioData

}//namespace
