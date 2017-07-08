using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Domain
{
    public class Evaluacion
    {
        private int codigoEvaluacion;
        private DateTime fechaInicio;
        private DateTime fechaFinal;
        private LinkedList<Evidencia> evidencias;
        private Recinto recinto;
        private Guia guia;
        private LinkedList<EncargadoEvaluacion> evaluadores;

        public Evaluacion()
        {

        }//constructor

        public int CodigoEvaluacion
        {
            get
            {
                return codigoEvaluacion;
            }

            set
            {
                codigoEvaluacion = value;
            }
        }

        public DateTime FechaInicio
        {
            get
            {
                return fechaInicio;
            }

            set
            {
                fechaInicio = value;
            }
        }

        public DateTime FechaFinal
        {
            get
            {
                return fechaFinal;
            }

            set
            {
                fechaFinal = value;
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

        public Recinto Recinto
        {
            get
            {
                return recinto;
            }

            set
            {
                recinto = value;
            }
        }

        public Guia Guia
        {
            get
            {
                return guia;
            }

            set
            {
                guia = value;
            }
        }

        public LinkedList<EncargadoEvaluacion> Evaluadores
        {
            get
            {
                return evaluadores;
            }

            set
            {
                evaluadores = value;
            }
        }
    }//Evaluacion

}//namespace
