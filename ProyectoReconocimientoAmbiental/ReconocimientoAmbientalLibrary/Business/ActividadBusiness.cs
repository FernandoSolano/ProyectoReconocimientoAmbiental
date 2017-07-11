using ReconocimientoAmbientalLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace ReconocimientoAmbientalLibrary.Business
{
    public class ActividadBusiness
    {
        private ActividadData actividadData;

        public ActividadBusiness(String cadenaConexion)
        {
            this.actividadData = new ActividadData(cadenaConexion);
        }//constructor

        public void getAll(GridView grid, String usuarioFuncionario)
        {
            actividadData.getAll(grid, usuarioFuncionario);
        }

        public void Insertar(int idSubcriterio, int cantidad, String titulo, String fecha, String tipoParticipantes, String descripcion, string nombreArchivo, string tipo, byte[] archivo)
        {
            actividadData.Insertar(idSubcriterio, cantidad, titulo, fecha, tipoParticipantes, descripcion, nombreArchivo, tipo, archivo);
        }
    }
}
