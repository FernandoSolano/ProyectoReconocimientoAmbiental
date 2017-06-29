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
        private String documentoNormativa;

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

        public string DocumentoNormativa
        {
            get
            {
                return documentoNormativa;
            }

            set
            {
                documentoNormativa = value;
            }
        }
    }//Normativa

}//namespace
