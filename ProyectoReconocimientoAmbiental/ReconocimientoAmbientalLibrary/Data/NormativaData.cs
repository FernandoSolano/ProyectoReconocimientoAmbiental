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
    public class NormativaData
    {
        private String cadenaConexion;

        public NormativaData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }//constructor

        public void getAll(GridView grid)
        {
            SqlConnection sqlConnection1 = new SqlConnection(cadenaConexion);
            SqlCommand cmd;
            sqlConnection1.Open();
            cmd = new SqlCommand("mostrar_normativas", sqlConnection1);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            grid.DataSource = ds;
            grid.DataBind();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        public void Insertar(int idSubcriterio, String titulo, String fecha, String detalle, string nombreArchivo, string tipo, byte[] archivo)
        {
            SqlConnection connection = new SqlConnection(cadenaConexion);
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_nueva_normativa", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@s_tituloEvidencia", titulo);
            cmd.Parameters.AddWithValue("@s_fechaEvidencia", fecha);
            cmd.Parameters.AddWithValue("@s_idSubcriterio", idSubcriterio);
            cmd.Parameters.AddWithValue("@s_detalle", detalle);
            cmd.Parameters.AddWithValue("@s_nombreArchivo", nombreArchivo);
            cmd.Parameters.AddWithValue("@s_file", archivo);
            cmd.Parameters.AddWithValue("@s_tipoArchivo", tipo);

            cmd.ExecuteNonQuery();
        }

    }
}
