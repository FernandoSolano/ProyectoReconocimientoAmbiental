using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Domain
{
    public class EncargadoEvaluacion
    {
        private int idEncargado;
        private String nombreEncargado;
        private Evaluacion evaluacion;
        private AreaTematica areaTematica;
        private Funcionario funcionario;

        public EncargadoEvaluacion()
        {

        }//constructor

        public int IdEncargado
        {
            get
            {
                return idEncargado;
            }

            set
            {
                idEncargado = value;
            }
        }

        public string NombreEncargado
        {
            get
            {
                return nombreEncargado;
            }

            set
            {
                nombreEncargado = value;
            }
        }

        public Evaluacion Evaluacion
        {
            get
            {
                return evaluacion;
            }

            set
            {
                evaluacion = value;
            }
        }

        public AreaTematica AreaTematica
        {
            get
            {
                return areaTematica;
            }

            set
            {
                areaTematica = value;
            }
        }

        public Funcionario Funcionario
        {
            get
            {
                return funcionario;
            }

            set
            {
                funcionario = value;
            }
        }
    }//EncargadoEvaluacion

}//namespace
