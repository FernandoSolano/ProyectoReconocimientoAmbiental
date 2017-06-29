using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Domain
{
    public class AreaTematica
    {
        private int idArea;
        private String descripcionArea;
        private String sigla;
        private String nombreAreaTematica;
        private LinkedList<Criterio> criterios;

        public AreaTematica()
        {

        }//constructor

        public int IdArea
        {
            get
            {
                return idArea;
            }

            set
            {
                idArea = value;
            }
        }

        public string DescripcionArea
        {
            get
            {
                return descripcionArea;
            }

            set
            {
                descripcionArea = value;
            }
        }

        public string Sigla
        {
            get
            {
                return sigla;
            }

            set
            {
                sigla = value;
            }
        }

        public string NombreAreaTematica
        {
            get
            {
                return nombreAreaTematica;
            }

            set
            {
                nombreAreaTematica = value;
            }
        }

        public LinkedList<Criterio> Criterios
        {
            get
            {
                return criterios;
            }

            set
            {
                criterios = value;
            }
        }
    }//AreaTematica
}//namespace
