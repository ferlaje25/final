using BE_ASAP;
using DA_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_ASAP
{
    public class BLAgencia_Viaje
    {
        public static List<Agencia_Viaje> Listado()
        {
            return DAAgencia_Viaje.Listado();
        }

        //public static List<Agencia_Viaje> ListadoPorEstado()
        //{
        //    return DAAgencia_Viaje.ListadoPorEstado();
        //}
        public static bool Actualizar(Agencia_Viaje agencia)
        {
            return DAAgencia_Viaje.Actualizar(agencia);
        }

        public static bool Registrar(Agencia_Viaje agencia)
        {
            return DAAgencia_Viaje.Registrar(agencia);
        }

        public static bool Eliminar(int codigo)
        {
            return DAAgencia_Viaje.Eliminar(codigo);
        }

        public static Agencia_Viaje ObtenerAgenciaPorID(int codigo)
        {
            return DAAgencia_Viaje.ObtenerAgenciaPorID(codigo);
        }
    }
}
