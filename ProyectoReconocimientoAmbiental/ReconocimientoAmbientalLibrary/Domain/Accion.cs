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
        private String informeTecnico;

        public Accion()
        {

        }//constructor

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

        public string InformeTecnico
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
    }//Accion

}//namespace
