using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Domain
{
    public class Imagen
    {
        private int idImagen;
        private String urlImagen;
        private String descripcionImagen;

        public Imagen()
        {

        }

        public int IdImagen
        {
            get
            {
                return idImagen;
            }

            set
            {
                idImagen = value;
            }
        }

        public string UrlImagen
        {
            get
            {
                return urlImagen;
            }

            set
            {
                urlImagen = value;
            }
        }

        public string DescripcionImagen
        {
            get
            {
                return descripcionImagen;
            }

            set
            {
                descripcionImagen = value;
            }
        }
    }//Imagen

}//namespace
