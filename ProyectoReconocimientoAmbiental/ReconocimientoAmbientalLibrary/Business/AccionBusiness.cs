using ReconocimientoAmbientalLibrary.Data;
using ReconocimientoAmbientalLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace ReconocimientoAmbientalLibrary.Business
{
    public class AccionBusiness
    {

        private AccionData accionData;

        public AccionBusiness(String cadenaConexion)
        {
            this.accionData = new AccionData(cadenaConexion);
        }//constructor

        public void getAll(GridView grid,String username)
        {
            accionData.getAll(grid, username);
        }

        public LinkedList<Subcriterio> ObtenerSubcriterios()
        {
            return accionData.ObtenerSubcriterios();
        }

        public void Insertar(int idSubcriterio, String titulo, String fecha, String descripcion, string nombreArchivo, string tipo, byte[] archivo)
        {
            accionData.Insertar(idSubcriterio, titulo, fecha, descripcion, nombreArchivo, tipo, archivo);
        }
    }
}
