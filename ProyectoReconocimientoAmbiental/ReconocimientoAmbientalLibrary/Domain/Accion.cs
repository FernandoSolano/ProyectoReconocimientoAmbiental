using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Domain
{
    public class Accion:Evidencia
    {
        private int idAccion;
        private String detalleAccion;
        private byte[] informeTecnico;
        private String tipoArchivo;
        private String nombreArchivo;
        private Evidencia evidencia;

        public Accion()
        {

        }
        public int IdAccion
        {
            get
            {
                return idAccion;
            }

            set
            {
                idAccion = value;
            }
        }

        public string DetalleAccion
        {
            get
            {
                return detalleAccion;
            }

            set
            {
                detalleAccion = value;
            }
        }

        public byte[] InformeTecnico
        {
            get
            {
                return informeTecnico;
            }

            set
            {
                informeTecnico = value;
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
    }//Accion

}//namespace
