﻿using ReconocimientoAmbientalLibrary.Data;
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

    }//CriterioBusiness

}//namespace
