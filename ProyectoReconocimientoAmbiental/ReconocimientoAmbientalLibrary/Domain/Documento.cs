using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Domain
{
    public class Documento : Evidencia
    {
        private int idDocumento;
        private int tipoDocumento;
        private String detalleDocumento;
        private String fuenteEmisor;
        private DateTime fechaEmision;
        private String urlDocumento;

        public Documento()
        {

        }//constructor

        public int IdDocumento
        {
            get
            {
                return idDocumento;
            }

            set
            {
                idDocumento = value;
            }
        }

        public int TipoDocumento
        {
            get
            {
                return tipoDocumento;
            }

            set
            {
                tipoDocumento = value;
            }
        }

        public string DetalleDocumento
        {
            get
            {
                return detalleDocumento;
            }

            set
            {
                detalleDocumento = value;
            }
        }

        public string FuenteEmisor
        {
            get
            {
                return fuenteEmisor;
            }

            set
            {
                fuenteEmisor = value;
            }
        }

        public DateTime FechaEmision
        {
            get
            {
                return fechaEmision;
            }

            set
            {
                fechaEmision = value;
            }
        }

        public string UrlDocumento
        {
            get
            {
                return urlDocumento;
            }

            set
            {
                urlDocumento = value;
            }
        }
    }//Documento

}//namespace
