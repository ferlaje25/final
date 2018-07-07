using BE_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ASAP
{
    public class DATipo_Documento
    {
        public static List<Tipo_Documento> Listado()
        {
            List<Tipo_Documento> listado = new List<Tipo_Documento>();
            using (ASAPEntities data = new ASAPEntities())
            {
                listado = data.Tipo_Documento.ToList();
            }
            return listado;
        }
    }
}
