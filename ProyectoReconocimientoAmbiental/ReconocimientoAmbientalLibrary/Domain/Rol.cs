using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Domain
{
    public class Rol
    {
        private int idRol;
        private String descripcionRol;

        public Rol()
        {

        }//constructor

        public int IdRol
        {
            get
            {
                return idRol;
            }

            set
            {
                idRol = value;
            }
        }

        public string DescripcionRol
        {
            get
            {
                return descripcionRol;
            }

            set
            {
                descripcionRol = value;
            }
        }
    }//Rol
}//namespace
