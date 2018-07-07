using BE_ASAP;
using DA_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_ASAP
{
    public class BLProgramacion_Vuelo
    {
        public static bool obtenerCodigo(Programacion_vuelo progra_Vuelo)
        {
            return DAProgramacion_Vuelo.obtenerCodigo(progra_Vuelo);
        }
        public static int obtenerCodigo()
        {
            return DAProgramacion_Vuelo.obtenerCodigo();
        }
        public static List<Programacion_vuelo> Listado()
        {
            return DAProgramacion_Vuelo.Listado();
        }

        public static bool Registrar(Programacion_vuelo Progvuelo)
        {
            return DAProgramacion_Vuelo.Registrar(Progvuelo);
        }

        public static bool Eliminar(int codigo)
        {
            return DAProgramacion_Vuelo.Eliminar(codigo);
        }
    }
}
