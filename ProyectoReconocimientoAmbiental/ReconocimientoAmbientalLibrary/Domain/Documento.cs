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
        private String tipoDocumento;
        private String detalleDocumento;
        private String fuenteEmisor;
        private DateTime fechaEmision;
        private byte[] documentoFile;
        private String typeFile;
        private String nombreArchivo;
        private Evidencia evidencia;

        public Documento()
        {

        }

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

        public string TipoDocumento
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

        public byte[] DocumentoFile
        {
            get
            {
                return documentoFile;
            }

            set
            {
                documentoFile = value;
            }
        }

        public string TypeFile
        {
            get
            {
                return typeFile;
            }

            set
            {
                typeFile = value;
            }
        }

        public string NombreArchivo
        {
            get
            {
                return nombreArchivo;
            }

            set
            {
                nombreArchivo = value;
            }
        }

        public Evidencia Evidencia
        {
            get
            {
                return evidencia;
            }

            set
            {
                evidencia = value;
            }
        }
    }//Documento

}//namespace
