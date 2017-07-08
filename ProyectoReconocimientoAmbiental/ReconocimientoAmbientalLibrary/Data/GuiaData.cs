using System;
using System.Collections.Generic;
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


}//GuiaData

}//namespace
