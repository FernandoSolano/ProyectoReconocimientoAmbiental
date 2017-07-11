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
    public class DocumentoData
    {
        private String cadenaConexion;

        public DocumentoData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }//constructor

        public void getAll(GridView grid)
        {
            SqlConnection sqlConnection1 = new SqlConnection(cadenaConexion);
            SqlCommand cmd;
            sqlConnection1.Open();
            cmd = new SqlCommand("mostrar_documentos", sqlConnection1);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            grid.DataSource = ds;
            grid.DataBind();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        public void Insertar(int subcriterio, String titulo, String fechaRealizacion, String tipoEscrito, String detalle,
                        String fechaEmision, String emisor, string nombreArchivo, string tipo, byte[] archivo)
        {
            SqlConnection connection = new SqlConnection(cadenaConexion);
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_nuevo_documento", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@s_idSubcriterio", subcriterio);
            cmd.Parameters.AddWithValue("@s_tituloEvidencia", titulo);
            cmd.Parameters.AddWithValue("@s_fechaEvidencia", fechaRealizacion);
            cmd.Parameters.AddWithValue("@s_tipoEscrito", tipoEscrito);
            cmd.Parameters.AddWithValue("@s_detalle", detalle);
            cmd.Parameters.AddWithValue("@s_fechaEmision", fechaEmision);
            cmd.Parameters.AddWithValue("@s_emisor", emisor);
            cmd.Parameters.AddWithValue("@s_nombreArchivo", nombreArchivo);
            cmd.Parameters.AddWithValue("@s_file", archivo);
            cmd.Parameters.AddWithValue("@s_tipoArchivo", tipo);

            cmd.ExecuteNonQuery();
        }

        public Documento getDocumento(int idDocumento)
        {
            SqlConnection sqlConnection1 = new SqlConnection(cadenaConexion);
            SqlCommand cmd;
            sqlConnection1.Open();
            cmd = new SqlCommand("sp_buscar_documento", sqlConnection1);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@s_idDocumento", idDocumento);
            SqlDataReader da = cmd.ExecuteReader();
            Documento documento = new Documento();
            while (da.Read())
            {
                documento.IdDocumento = Int32.Parse(da["idDocumento"].ToString());
                documento.TipoDocumento = da["tipoDocumento"].ToString();
                documento.DetalleDocumento = da["detalleDocumento"].ToString();
                documento.FuenteEmisor = da["fuenteEmisor"].ToString();
                documento.FechaEmision = (DateTime) da["fechaEmision"];
                documento.DocumentoFile = (byte[]) da["documentoFile"];
                documento.TypeFile = da["fileType"].ToString();
                documento.NombreArchivo = da["nombreArchivo"].ToString();
            }
            sqlConnection1.Close();
            return documento;
        }

    }
}
