using ReconocimientoAmbientalLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Business
{
    public class AreaTematicaBusiness
    {
        private AreaTematicaData areaTematicaData;
        public AreaTematicaBusiness(String cadenaConexion)
        {
            this.areaTematicaData = new AreaTematicaData(cadenaConexion);
        }//constructor

    }//AreaTematicaBusiness
}//namespace
