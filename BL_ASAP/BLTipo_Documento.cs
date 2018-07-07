using BE_ASAP;
using DA_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_ASAP
{
    public class BLTipo_Documento
    {
        public static List<Tipo_Documento> Listado()
        {
            return DATipo_Documento.Listado();
        }
    }
}
