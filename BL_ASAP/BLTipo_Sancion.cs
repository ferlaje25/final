using BE_ASAP;
using DA_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_ASAP
{
    public class BLTip_Sancion
    {
        public static List<Tip_Sancion> Listado()
        {
            return DATip_Sancion.Listado();
        }

        public static bool Registrar(Tip_Sancion tipSancion)
        {
            return DATip_Sancion.Registrar(tipSancion);
        }

        public static bool Eliminar(int codigo)
        {
            return DATip_Sancion.Eliminar(codigo);
        }
    }
}