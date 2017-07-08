using ReconocimientoAmbientalLibrary.Data;
using ReconocimientoAmbientalLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Business
{
    public class RecintoBusiness
    {
        private RecintoData recintoData;

        public RecintoBusiness(String connectionString)
        {
            recintoData = new RecintoData(connectionString);
        }

        public void actualizarRecinto(Recinto recinto)
        {
            recintoData.actualizarRecinto(recinto);
        }
    }
}
