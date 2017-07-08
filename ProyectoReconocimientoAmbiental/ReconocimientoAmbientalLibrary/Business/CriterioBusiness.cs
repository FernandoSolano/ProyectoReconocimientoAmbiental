using ReconocimientoAmbientalLibrary.Data;
using ReconocimientoAmbientalLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Business
{
    public class CriterioBusiness
    {
        private CriterioData criterioData;
        public CriterioBusiness(String cadenaConexion)
        {
            this.criterioData = new CriterioData(cadenaConexion);
        }//constructor

        public void AgregarCriterio(String nombreCriterio, String descripcionCriterio, int idArea)
        {
            this.criterioData.AgregarCriterio(nombreCriterio,descripcionCriterio,idArea);
        }//AgregarCriterio

        public LinkedList<Criterio> ObtenerCriterios()
        {
            return this.criterioData.ObtenerCriterios();
        }//ObtenerCriterios

    }//CriterioBusiness

}//namespace
