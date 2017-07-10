using ReconocimientoAmbientalLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Business
{
    public class EncargadoEvaluacionBusiness
    {
        private EncargadoEvaluacionData encargadoEvaluacionData;

        public EncargadoEvaluacionBusiness(String connectionString)
        {
            encargadoEvaluacionData = new EncargadoEvaluacionData(connectionString);
        }

        public void ActualizarEncargadoDeArea(int idArea, int idFuncionario, String nombreEncargado)
        {
            encargadoEvaluacionData.ActualizarEncargadoDeArea(idArea, idFuncionario, nombreEncargado);
        }
    }
}
