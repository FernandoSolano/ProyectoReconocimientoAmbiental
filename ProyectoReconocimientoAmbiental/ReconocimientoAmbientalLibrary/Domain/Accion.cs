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
        private String urlInformeTecnico;

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

        public string UrlInformeTecnico
        {
            get
            {
                return urlInformeTecnico;
            }

            set
            {
                urlInformeTecnico = value;
            }
        }
    }//Accion

}//namespace
