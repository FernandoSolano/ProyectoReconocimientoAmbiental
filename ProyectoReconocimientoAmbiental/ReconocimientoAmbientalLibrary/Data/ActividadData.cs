using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace ReconocimientoAmbientalLibrary.Data
{
    public class ActividadData
    {
        private String cadenaConexion;

        public ActividadData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }//constructor

        public void getAll(GridView grid, String funcionario)
        {
            SqlConnection sqlConnection1 = new SqlConnection(cadenaConexion);
            SqlCommand cmd;
            sqlConnection1.Open();
            cmd = new SqlCommand("mostrar_acciones", sqlConnection1);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@username", funcionario);
            DataSet ds = new DataSet();
            da.Fill(ds);
            grid.DataSource = ds;
            grid.DataBind();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        public void Insertar(int idSubcriterio, int cantidad, String titulo, String fecha, String tipoParticipantes, String descripcion, string nombreArchivo, string tipo, byte[] archivo)
        {
            SqlConnection connection = new SqlConnection(cadenaConexion);
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_nueva_actividad", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@s_idSubcriterio", idSubcriterio);
            cmd.Parameters.AddWithValue("@s_cantidad", cantidad);
            cmd.Parameters.AddWithValue("@s_titulo", titulo);
            cmd.Parameters.AddWithValue("@s_tipoParticipantes", tipoParticipantes);
            cmd.Parameters.AddWithValue("@s_descripcion", descripcion);
            cmd.Parameters.AddWithValue("@s_fechaEvidencia", fecha);
            cmd.Parameters.AddWithValue("@s_fechaActividad", fecha);
            cmd.Parameters.AddWithValue("@s_nombreArchivo", nombreArchivo);
            cmd.Parameters.AddWithValue("@s_file", archivo);
            cmd.Parameters.AddWithValue("@s_tipoArchivo", tipo);

            cmd.ExecuteNonQuery();
        }


    }
}
