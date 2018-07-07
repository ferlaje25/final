using BE_ASAP;
using DA_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_ASAP
{
    public class BLDet_Progra_Tripulacion
    {
        public static bool obtenerCodigo(Det_Progra_Tripulacion Tripulacion)
        {
            return DADet_Progra_Tripulacion.obtenerCodigo(Tripulacion);
        }
    }
}
