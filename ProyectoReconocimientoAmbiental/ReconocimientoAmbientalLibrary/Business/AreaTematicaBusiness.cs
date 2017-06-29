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

        public void AgregarAreaTematica(String nombreAreaTematica, String descripcionArea, String siglaArea, int idGuia)
        {
            this.areaTematicaData.AgregarAreaTematica(nombreAreaTematica,descripcionArea,siglaArea,idGuia);
        }//AgregarAreaTematica

    }//AreaTematicaBusiness
}//namespace
