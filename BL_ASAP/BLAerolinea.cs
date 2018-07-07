using BE_ASAP;
using DA_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_ASAP
{
    public class BLAerolinea
    {
        public static List<Aerolinea> Listado()
        {
            return DAAerolinea.Listado();
        }

        public static bool Registrar(Aerolinea aerolinea)
        {
            return DAAerolinea.Registrar(aerolinea);
        }

        public static bool Eliminar(int codigo)
        {
            return DAAerolinea.Eliminar(codigo);
        }
    }
}
