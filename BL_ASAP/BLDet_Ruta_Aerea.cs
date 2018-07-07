using BE_ASAP;
using DA_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_ASAP
{
    public class BLDet_Ruta_Aerea
    {
        public static List<Det_Ruta_Aerea> Listado()
        {
            return DADet_Ruta_Aerea.Listado();
        }
        public static Det_Ruta_Aerea RutaSeleccionada(int id_Det_Ruta)
        {
            return DADet_Ruta_Aerea.RutaSeleccionada(id_Det_Ruta);
        }
        public static bool Registrar(Det_Ruta_Aerea detRuta)
        {
            return DADet_Ruta_Aerea.Registrar(detRuta);
        }

        public static bool Eliminar(int codigo)
        {
            return DADet_Ruta_Aerea.Eliminar(codigo);
        }
    }
}