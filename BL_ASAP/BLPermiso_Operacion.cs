using BE_ASAP;
using DA_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_ASAP
{
    public class BLPermiso_Operacion
    {
        public static List<Permiso_Operacion> listaListadoPermisoRutaSelec(int? id_Deta_Ruta)
        {
            return DAPermiso_Operacion.ListadoPermisoRutaSelec(id_Deta_Ruta);
        }
    }
}
