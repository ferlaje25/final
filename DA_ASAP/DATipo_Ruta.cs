using BE_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ASAP
{
    public class DATipo_Ruta
    {
        public static List<Tipo_Ruta> Listado()
        {
            List<Tipo_Ruta> listado = new List<Tipo_Ruta>();
            using (ASAPEntities data = new ASAPEntities())
            {
                listado = data.Tipo_Ruta.ToList();
            }
            return listado;
        }

    }
}
