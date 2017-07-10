using ReconocimientoAmbientalLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Data
{
    public class AreaTematicaData
    {
        private String cadenaConexion;

        public AreaTematicaData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }//constructor

        public void AgregarAreaTematica(String nombreAreaTematica, String descripcionArea, String siglaArea)
        {
            SqlConnection sqlConnection1 = new SqlConnection(cadenaConexion);
            sqlConnection1.Open();
            SqlTransaction transaccion = sqlConnection1.BeginTransaction();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("sp_agregar_area_tematica", sqlConnection1, transaccion);//agrego mi procedimiento almacenado para utilizarlo
                cmd.CommandType = System.Data.CommandType.StoredProcedure;//indico que voy a utilizar un procedimiento almacenado

                //***aqui va el parametro que quiero enviarle al procedimiento
                cmd.Parameters.AddWithValue("@nombreAreaTematica", nombreAreaTematica);
                cmd.Parameters.AddWithValue("@descripcionArea", descripcionArea);
                cmd.Parameters.AddWithValue("@siglaArea", siglaArea);

                cmd.ExecuteNonQuery();//ejecuto el procedimiento almacenado

                transaccion.Commit();//si se ejecuta bien la transaccion hace el cambio en la base de datos=commit

            }//try
            catch (Exception ex)
            {
                transaccion.Rollback();//si se ejecuto mal que no haga ningun cambio en la base de datos
            }//catch
            sqlConnection1.Close();
        }//AgregarAreaTematica


        public LinkedList<AreaTematica> ObtenerAreasTematicas()
        {

            //paso 1
            SqlConnection connection = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("sp_obtener_area_tematica", connection);
            connection.Open();
            SqlDataReader drAreas = cmd.ExecuteReader();
            LinkedList<AreaTematica> areasTematicas = new LinkedList<AreaTematica>();
            while (drAreas.Read())
            {
                AreaTematica areaTematica = new AreaTematica();
                areaTematica.NombreAreaTematica = drAreas["nombreAreaTematica"].ToString();
                areaTematica.IdArea = Int32.Parse(drAreas["idArea"].ToString());
                areaTematica.DescripcionArea = drAreas["descripcionArea"].ToString();
                areaTematica.Sigla = drAreas["siglaArea"].ToString();
                areasTematicas.AddLast(areaTematica);
            }//while
            connection.Close();
            return areasTematicas;

        }//ObtenerAreasTematicas()

        public LinkedList<AreaTematica> obtenerAreasPorIdGuia(int idGuia)
        {
            SqlConnection connection = new SqlConnection(this.cadenaConexion);
            string sqlProcedureObtenerAreas = "obtener_area_temtica_por_id_guia";
            SqlCommand comandoObtenerAreas = new SqlCommand(sqlProcedureObtenerAreas, connection);
            comandoObtenerAreas.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerAreas.Parameters.Add(new SqlParameter("@idGuia", idGuia));

            try
            {
                connection.Open();
                SqlDataReader drAreas = comandoObtenerAreas.ExecuteReader();
                LinkedList<AreaTematica> areasTematicas = new LinkedList<AreaTematica>();
                while (drAreas.Read())
                {

                    AreaTematica areaTematica = new AreaTematica();
                    areaTematica.IdArea = Int32.Parse(drAreas["idArea"].ToString());
                    areaTematica.NombreAreaTematica = drAreas["nombreAreaTematica"].ToString();
                    areaTematica.DescripcionArea = drAreas["descripcionArea"].ToString();
                    areaTematica.Sigla = drAreas["siglaArea"].ToString();
                   

                    areasTematicas.AddLast(areaTematica);
                }//while
                connection.Close();
                return areasTematicas;
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

        public AreaTematica ObtenerAreaTematicaPorId(int codArea)
        {
            String query = "SELECT * FROM AreaTematica WHERE idArea="+codArea;
            SqlConnection connection = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            AreaTematica areaTematica = new AreaTematica();
            while (dataReader.Read())
            {
                areaTematica.IdArea = Int32.Parse(dataReader["idArea"].ToString());
                areaTematica.NombreAreaTematica = dataReader["nombreAreaTematica"].ToString();
                areaTematica.DescripcionArea = dataReader["descripcionArea"].ToString();
            }
            connection.Close();
            return areaTematica;
        }

    }//AreaTematicaData

}//namespace
