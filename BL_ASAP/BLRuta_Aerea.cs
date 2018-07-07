using BE_ASAP;
using DA_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_ASAP
{
    public class BLRuta_Aerea
    {
        public static List<Ruta_Aerea> Listado()
        {
            return DARuta_Aerea.Listado();
        }
        public static List<Ruta_Aerea> ListadoOrigen(int id)
        {
            return DARuta_Aerea.ListadoOrigen(id);
        }
        public static List<Ruta_Aerea> ListadoFin(int id)
        {
            return DARuta_Aerea.ListadoFin(id);
        }
       
    }
}