using ReconocimientoAmbientalLibrary.Data;
using ReconocimientoAmbientalLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Business
{
    public class EvaluacionBusiness
    {
        private EvaluacionData evaluacionData;

        public EvaluacionBusiness(String cadenaConexion)
        {
            this.evaluacionData = new EvaluacionData(cadenaConexion);
        }

        public LinkedList<Evaluacion> obtenerEvaluaciones() {
            return this.evaluacionData.obtenerEvaluaciones();
        }

        public DataTable getReporte(int idGuia)
        {
            return this.evaluacionData.getReporte(idGuia);
        }
    }
}
