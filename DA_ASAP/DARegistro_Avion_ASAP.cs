using BE_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ASAP
{
    public class DARegistro_Avion_ASAP
    {
        public static List< Registro_Avion_ASAP> listado_Registro_ASAP()
        {
            List<Registro_Avion_ASAP> listado = new List<Registro_Avion_ASAP>();
            using (ASAPEntities data = new ASAPEntities())
            {
                listado = data.Registro_Avion_ASAP.Where(x => x.Estado_Propio.Equals("Activo")).ToList();
            }
            return listado;

        }
    }
}
