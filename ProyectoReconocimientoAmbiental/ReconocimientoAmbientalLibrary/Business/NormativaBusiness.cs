using ReconocimientoAmbientalLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace ReconocimientoAmbientalLibrary.Business
{
    public class NormativaBusiness
    {
        private NormativaData normativaData;

        public NormativaBusiness(String cadenaConexion)
        {
            this.normativaData = new NormativaData(cadenaConexion);
        }//constructor

        public void getAll(GridView grid)
        {
            normativaData.getAll(grid);
        }

        public void Insertar(int idSubcriterio, String titulo, String fecha, String detalle, string nombreArchivo, string tipo, byte[] archivo)
        {
            normativaData.Insertar(idSubcriterio, titulo, fecha, detalle, nombreArchivo, tipo, archivo);
        }
    }
}
