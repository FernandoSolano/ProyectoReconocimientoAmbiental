using ReconocimientoAmbientalLibrary.Data;
using ReconocimientoAmbientalLibrary.Domain;
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

        public void AgregarAreaTematica(String nombreAreaTematica, String descripcionArea, String siglaArea)
        {
            this.areaTematicaData.AgregarAreaTematica(nombreAreaTematica,descripcionArea,siglaArea);
        }//AgregarAreaTematica

        public LinkedList<AreaTematica> ObtenerAreasTematicas()
        {
            return this.areaTematicaData.ObtenerAreasTematicas();
        }//ObtenerAreasTematicas

        public AreaTematica ObtenerAreaTematicaPorId(int codArea)
        {
            return areaTematicaData.ObtenerAreaTematicaPorId(codArea);
        }
    }//AreaTematicaBusiness
}//namespace
