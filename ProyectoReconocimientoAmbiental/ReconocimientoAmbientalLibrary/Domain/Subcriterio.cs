using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Domain
{
    public class Subcriterio
    {
        private int idSubcriterio;
        private String descripcionSubcriterio;
        private String nombreSubcriterio;
        private LinkedList<Evidencia> evidencias;

        public Subcriterio()
        {

        }//constructor

        public int IdSubcriterio
        {
            get
            {
                return idSubcriterio;
            }

            set
            {
                idSubcriterio = value;
            }
        }

        public string DescripcionSubcriterio
        {
            get
            {
                return descripcionSubcriterio;
            }

            set
            {
                descripcionSubcriterio = value;
            }
        }

        public string NombreSubcriterio
        {
            get
            {
                return nombreSubcriterio;
            }

            set
            {
                nombreSubcriterio = value;
            }
        }

        public LinkedList<Evidencia> Evidencias
        {
            get
            {
                return evidencias;
            }

            set
            {
                evidencias = value;
            }
        }
    }//Subcriterio

}//namespace
