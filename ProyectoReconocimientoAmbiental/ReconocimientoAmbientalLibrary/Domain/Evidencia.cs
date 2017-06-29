using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Domain
{
    public class Evidencia
    {
        private int idEvidencia;
        private String tituloEvidencia;
        private DateTime fechaEvidencia;
        private Subcriterio subcriterio;

        public Evidencia()
        {

        }//constructor

        public int IdEvidencia
        {
            get
            {
                return idEvidencia;
            }

            set
            {
                idEvidencia = value;
            }
        }

        public string TituloEvidencia
        {
            get
            {
                return tituloEvidencia;
            }

            set
            {
                tituloEvidencia = value;
            }
        }

        public DateTime FechaEvidencia
        {
            get
            {
                return fechaEvidencia;
            }

            set
            {
                fechaEvidencia = value;
            }
        }

        public Subcriterio Subcriterio
        {
            get
            {
                return subcriterio;
            }

            set
            {
                subcriterio = value;
            }
        }
    }//Evidencia

}//namespace
