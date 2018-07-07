using BE_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ASAP
{
    public class DAAutorizacion_Operar
    {
        public static List<Autorizacion_Operar> lista_Autor()
        {
            List<Autorizacion_Operar> listado = new List<Autorizacion_Operar>();
            using(ASAPEntities data = new ASAPEntities())
            {
                listado = data.Autorizacion_Operar.Where(x => x.Estado.Equals("Activo")).ToList();
            }
            return listado;
        }
    }
}
