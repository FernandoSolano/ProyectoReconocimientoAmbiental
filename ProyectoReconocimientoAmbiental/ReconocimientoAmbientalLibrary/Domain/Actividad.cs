using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Domain
{
    public class Actividad : Evidencia
    {
        private int idActividad;
        private int cantidadParticipantes;
        private String tipoParticipantes;
        private DateTime fechaActividad;
        private String descripcionActividad;
        private LinkedList<Imagen> imagenes;

        public Actividad()
        {

        }//constructor

        public int IdActividad
        {
            get
            {
                return idActividad;
            }

            set
            {
                idActividad = value;
            }
        }

        public int CantidadParticipantes
        {
            get
            {
                return cantidadParticipantes;
            }

            set
            {
                cantidadParticipantes = value;
            }
        }

        public string TipoParticipantes
        {
            get
            {
                return tipoParticipantes;
            }

            set
            {
                tipoParticipantes = value;
            }
        }

        public DateTime FechaActividad
        {
            get
            {
                return fechaActividad;
            }

            set
            {
                fechaActividad = value;
            }
        }

        public string DescripcionActividad
        {
            get
            {
                return descripcionActividad;
            }

            set
            {
                descripcionActividad = value;
            }
        }

        public LinkedList<Imagen> Imagenes
        {
            get
            {
                return imagenes;
            }

            set
            {
                imagenes = value;
            }
        }
    }//Actividad
}//namespace
