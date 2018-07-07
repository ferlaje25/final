using BE_ASAP;
using DA_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_ASAP
{
    public class BLDETALLE_DE_RUTA
    {
        public static List<DETALLE_DE_RUTA> Listado()
        {
            return DADETALLE_DE_RUTA.Listado();
        }
        public static DETALLE_DE_RUTA rutaSeleccionada(int id_Det_Ruta)
        {
            return DADETALLE_DE_RUTA.rutaSeleccionada(id_Det_Ruta);
        }
    }
}
