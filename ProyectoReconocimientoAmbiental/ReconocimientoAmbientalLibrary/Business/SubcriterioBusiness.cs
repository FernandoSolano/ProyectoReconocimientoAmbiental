﻿using ReconocimientoAmbientalLibrary.Data;
using ReconocimientoAmbientalLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Business
{
    public class SubcriterioBusiness
    {
        private SubcriterioData subcriterioData;
        public SubcriterioBusiness(String cadenaConexion)
        {
            this.subcriterioData = new SubcriterioData(cadenaConexion);
        }//constructor

        public void AgregarSubcriterio(String nombreSubcriterio, String responsableSubcriterio, String planSubcriterio, int idCriterio)
        {
            this.subcriterioData.AgregarSubcriterio(nombreSubcriterio,responsableSubcriterio,planSubcriterio,idCriterio);
        }//AgregarSubcriterio

        public LinkedList<Subcriterio> ObtenerSubcriterios()
        {
            return this.subcriterioData.ObtenerSubcriterios();
        }//ObtenerCriterios

    }//SubcriterioBusiness

}//namespace