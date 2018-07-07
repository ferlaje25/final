using BE_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ASAP
{
    public class DADETALLE_DE_RUTA
    {
        public static List<DETALLE_DE_RUTA> Listado()
        {
            List<DETALLE_DE_RUTA> listado = new List<DETALLE_DE_RUTA>();
            using (ASAPEntities data = new ASAPEntities())
            {
                listado = data.DETALLE_DE_RUTA.ToList();
            }
            return listado;
        }

        public static DETALLE_DE_RUTA rutaSeleccionada(int id_Det_Ruta)
        {
            DETALLE_DE_RUTA ruta_Grande = new DETALLE_DE_RUTA();
            using (ASAPEntities data = new ASAPEntities())
            {

                ruta_Grande =  data.DETALLE_DE_RUTA.Where(x => x.Id_Det_Ruta_Aerea == id_Det_Ruta).FirstOrDefault();
            }
            return ruta_Grande;
        }
    }
}
