using BE_ASAP;
using DA_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_ASAP
{
    public class BLRegistro_Avion_ASAP
    {
        public static List<Registro_Avion_ASAP> listado_Registro_ASAP()
        {
            return DARegistro_Avion_ASAP.listado_Registro_ASAP();
        }
    }
}
