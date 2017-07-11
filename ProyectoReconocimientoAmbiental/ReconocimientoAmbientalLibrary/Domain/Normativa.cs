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
        private byte[] normativaArchivo;
        private String tipoArchivo;
        private String nombreArchivo;
        private Evidencia evidencia;

        public Normativa()
        {

        }


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

        public byte[] NormativaArchivo
        {
            get
            {
                return normativaArchivo;
            }

            set
            {
                normativaArchivo = value;
            }
        }

        public string TipoArchivo
        {
            get
            {
                return tipoArchivo;
            }

            set
            {
                tipoArchivo = value;
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
    }//Normativa

}//namespace
