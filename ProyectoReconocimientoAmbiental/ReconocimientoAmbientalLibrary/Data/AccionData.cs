using ReconocimientoAmbientalLibrary.Domain;
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
    public class AccionData
    {

        private String cadenaConexion;

        public AccionData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }//constructor

        public void getAll(GridView grid, String username)
        {
            SqlConnection sqlConnection1 = new SqlConnection(cadenaConexion);
            SqlCommand cmd;
            sqlConnection1.Open();
            cmd = new SqlCommand("mostrar_acciones", sqlConnection1);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            grid.DataSource = ds;
            grid.DataBind();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        public LinkedList<Subcriterio> ObtenerSubcriterios()
        {
            SqlConnection connection = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("sp_obtener_subcriterios", connection);
            connection.Open();
            SqlDataReader drSubcriterios = cmd.ExecuteReader();
            LinkedList<Subcriterio> subcriterios = new LinkedList<Subcriterio>();
            while (drSubcriterios.Read())
            {
                Subcriterio subcriterio = new Subcriterio();
                subcriterio.NombreSubcriterio = drSubcriterios["nombreSubcriterio"].ToString();
                subcriterio.IdSubcriterio = Int32.Parse(drSubcriterios["idSubcriterio"].ToString());
                subcriterios.AddLast(subcriterio);
            }//while
            connection.Close();
            return subcriterios;
        }

        public void Insertar(int idSubcriterio, String titulo, String fecha, String descripcion, string nombreArchivo, string tipo, byte[] archivo)
        {
            SqlConnection connection = new SqlConnection(cadenaConexion);
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_nueva_accion_administrativa", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@s_tituloEvidencia", titulo);
            cmd.Parameters.AddWithValue("@s_fechaEvidencia", fecha);
            cmd.Parameters.AddWithValue("@s_idSubcriterio", idSubcriterio);
            cmd.Parameters.AddWithValue("@s_descripcion", descripcion);
            cmd.Parameters.AddWithValue("@s_nombreArchivo", nombreArchivo);
            cmd.Parameters.AddWithValue("@s_file", archivo);
            cmd.Parameters.AddWithValue("@s_tipoArchivo", tipo);

            cmd.ExecuteNonQuery();
        }

        public Accion getAccion(int idAccion)
        {
            SqlConnection sqlConnection1 = new SqlConnection(cadenaConexion);
            SqlCommand cmd;
            sqlConnection1.Open();
            cmd = new SqlCommand("sp_buscar_accion", sqlConnection1);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@s_idAccion", idAccion);
            SqlDataReader da = cmd.ExecuteReader();
            Accion accion = new Accion();
            while (da.Read())
            {
                accion.IdAccion = Int32.Parse(da["idAccion"].ToString());
                accion.DetalleAccion = da["detalleAccion"].ToString();
                accion.InformeTecnico = (byte[])da["informeTecnico_file"];
                accion.TipoArchivo = da["file_type"].ToString();
                accion.NombreArchivo = da["nombreArchivo"].ToString();
            }
            sqlConnection1.Close();
            return accion;
        }
    }
}