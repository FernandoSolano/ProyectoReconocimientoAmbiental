using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Domain
{
    public class Guia
    {
        private int idGuia;
        private int annoPublicacion;
        private Boolean vigente;
        private DateTime fechaCreacion;
        private String nombreGuia;
        LinkedList<AreaTematica> AreasTematicas;

        public Guia()
        {

        }//constructor

        public int IdGuia
        {
            get
            {
                return idGuia;
            }

            set
            {
                idGuia = value;
            }
        }

        public int AnnoPublicacion
        {
            get
            {
                return annoPublicacion;
            }

            set
            {
                annoPublicacion = value;
            }
        }

        public bool Vigente
        {
            get
            {
                return vigente;
            }

            set
            {
                vigente = value;
            }
        }

        public DateTime FechaCreacion
        {
            get
            {
                return fechaCreacion;
            }

            set
            {
                fechaCreacion = value;
            }
        }

        public string NombreGuia
        {
            get
            {
                return nombreGuia;
            }

            set
            {
                nombreGuia = value;
            }
        }

        public LinkedList<AreaTematica> AreasTematicas1
        {
            get
            {
                return AreasTematicas;
            }

            set
            {
                AreasTematicas = value;
            }
        }

        
    }//Guia

}//namespace
