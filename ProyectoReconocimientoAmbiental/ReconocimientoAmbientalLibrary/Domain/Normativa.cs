﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Domain
{
    public class Normativa : Evidencia
    {
        private int idNormativa;
        private String detalleNormativa;
        private String normativa;

        public Normativa()
        {

        }//constructor

        public int IdNormativa
        {
            get
            {
                return idNormativa;
            }

            set
            {
                idNormativa = value;
            }
        }

        public string DetalleNormativa
        {
            get
            {
                return detalleNormativa;
            }

            set
            {
                detalleNormativa = value;
            }
        }

        public string Normativa
        {
            get
            {
                return normativa;
            }

            set
            {
                normativa = value;
            }
        }
    }//Normativa

}//namespace
