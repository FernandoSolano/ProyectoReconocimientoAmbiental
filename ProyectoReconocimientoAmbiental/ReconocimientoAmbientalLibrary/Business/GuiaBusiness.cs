using ReconocimientoAmbientalLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Business
{
    public class GuiaBusiness
    {
        private GuiaData guiaData;
        public GuiaBusiness(String cadenaConexion)
        {
            this.guiaData = new GuiaData(cadenaConexion);
        }//constructor

    }//GuiaBusiness

}//namespace
