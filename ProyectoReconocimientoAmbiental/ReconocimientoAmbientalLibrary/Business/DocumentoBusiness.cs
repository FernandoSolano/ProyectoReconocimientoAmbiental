using ReconocimientoAmbientalLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace ReconocimientoAmbientalLibrary.Business
{
    public class DocumentoBusiness
    {
        private DocumentoData documentoData;

        public DocumentoBusiness(String cadenaConexion)
        {
            this.documentoData = new DocumentoData(cadenaConexion);
        }//constructor

        public void getAll(GridView grid)
        {
            documentoData.getAll(grid);
        }

        public void Insertar(int subcriterio, String titulo, String fechaRealizacion, String tipoEscrito, String detalle,
                        String fechaEmision, String emisor, string nombreArchivo, string tipo, byte[] archivo)
        {
            documentoData.Insertar(subcriterio, titulo, fechaRealizacion, tipoEscrito, detalle, fechaEmision, emisor, nombreArchivo, tipo, archivo);
        }
    }
}

