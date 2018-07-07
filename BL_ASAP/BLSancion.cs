using BE_ASAP;
using DA_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_ASAP
{
    public class BLSancion
    {
        public static int CantSancion(int id_Emp)
        {
            return DASancion.CantSanciones(id_Emp);

        }
        public static List<Sancion> Listado()
        {
            return DASancion.Listado();
        }

        public static bool Registrar(Sancion sancion)
        {
            return DASancion.Registrar(sancion);
        }

        public static bool Eliminar(int codigo)
        {
            return DASancion.Eliminar(codigo);
        }

    }
}