using System;
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
        private String urlNormativa;

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

        public string UrlNormativa
        {
            get
            {
                return urlNormativa;
            }

            set
            {
                urlNormativa = value;
            }
        }
    }//Normativa

}//namespace
