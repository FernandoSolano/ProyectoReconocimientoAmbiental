using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Domain
{
    public class Recinto
    {
        private int idRecinto;
        private String nombreRecinto;
        private String direccionRecinto;
        private String telefonoRecinto;
        private String correoEectronicoRecinto;

        public Recinto()
        {

        }//constructor

        public int IdRecinto
        {
            get
            {
                return idRecinto;
            }

            set
            {
                idRecinto = value;
            }
        }

        public string NombreRecinto
        {
            get
            {
                return nombreRecinto;
            }

            set
            {
                nombreRecinto = value;
            }
        }

        public string DireccionRecinto
        {
            get
            {
                return direccionRecinto;
            }

            set
            {
                direccionRecinto = value;
            }
        }

        public string TelefonoRecinto
        {
            get
            {
                return telefonoRecinto;
            }

            set
            {
                telefonoRecinto = value;
            }
        }

        public string CorreoEectronicoRecinto
        {
            get
            {
                return correoEectronicoRecinto;
            }

            set
            {
                correoEectronicoRecinto = value;
            }
        }
    }//Recinto
}//namespace
