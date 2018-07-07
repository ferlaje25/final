using BE_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ASAP
{
   public  class DAPermiso_Operacion
    {
        public static List<Permiso_Operacion> ListadoPermisoRutaSelec(int? id_Det_Ruta)
        {
            List<Permiso_Operacion> listado = new List<Permiso_Operacion>();
            using(ASAPEntities data= new ASAPEntities())
            {
                listado = data.Permiso_Operacion.Where(x => x.Id_Det_Ruta_Aerea == id_Det_Ruta && x.Estado.Equals("Activo")).ToList();
            }

            return listado;
        }
    }
}
