using ReconocimientoAmbientalLibrary.Data;
using ReconocimientoAmbientalLibrary.Domain;
using System;
using System.Collections.Generic;

namespace ReconocimientoAmbientalLibrary.Business
{
    public class SubcriterioBusiness
    {
        private SubcriterioData subcriterioData;
        public SubcriterioBusiness(String cadenaConexion)
        {
            this.subcriterioData = new SubcriterioData(cadenaConexion);
        }//constructor

        public void AgregarSubcriterio(String nombreSubcriterio, String descripcionSubcriterio, int idCriterio)
        {
            this.subcriterioData.AgregarSubcriterio(nombreSubcriterio, descripcionSubcriterio, idCriterio);
        }//AgregarSubcriterio

        public LinkedList<Subcriterio> ObtenerSubcriterios()
        {
            return this.subcriterioData.ObtenerSubcriterios();
        }//ObtenerCriterios

        public LinkedList<Subcriterio> obtenerSubcriteriosPorIdCriterio(int idCriterio)
        {
            return this.subcriterioData.obtenerSubcriteriosPorIdCriterio(idCriterio);
        }

        public LinkedList<Subcriterio> obtenerSubcriteriosPorIdArea(int idArea)
        {
            return subcriterioData.obtenerSubcriteriosPorIdArea(idArea);
        }

    }//SubcriterioBusiness

}//namespace
