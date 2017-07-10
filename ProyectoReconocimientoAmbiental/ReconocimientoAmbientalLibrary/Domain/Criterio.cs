using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Domain
{
    public class Criterio
    {
        private int idCriterio;
        private String descripcionCriterio;
        private String nombreCriterio;
        private LinkedList<Subcriterio> subcriterios;
        private int cod;
        private string name;
        private string description;

        public Criterio()
        {

        }//constructor

        public Criterio(int cod, string name, string description)
        {
            this.cod = cod;
            this.name = name;
            this.description = description;
        }

        public int IdCriterio
        {
            get
            {
                return idCriterio;
            }

            set
            {
                idCriterio = value;
            }
        }

        public string DescripcionCriterio
        {
            get
            {
                return descripcionCriterio;
            }

            set
            {
                descripcionCriterio = value;
            }
        }

        public string NombreCriterio
        {
            get
            {
                return nombreCriterio;
            }

            set
            {
                nombreCriterio = value;
            }
        }

        public LinkedList<Subcriterio> Subcriterios
        {
            get
            {
                return subcriterios;
            }

            set
            {
                subcriterios = value;
            }
        }
    }//Criterio

}//namespace
