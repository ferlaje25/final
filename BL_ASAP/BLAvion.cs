using BE_ASAP;
using DA_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_ASAP
{
    public class BLAvion
    {
        public static List<Avion> listado()
        {
            return DAAvion.listado_Aviones();
        }

        public static bool Registrar(Avion avion)
        {
            return DAAvion.Registrar(avion);
        }

        public static bool Eliminar(int codigo)
        {
            return DAAvion.Eliminar(codigo);
        }
    }
}
