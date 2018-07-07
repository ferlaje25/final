using BE_ASAP;
using DA_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_ASAP
{
    public class BLAutorizacion_Operar
    {
        public static List<Autorizacion_Operar> lista_Autor_Operar()
        {
            return DAAutorizacion_Operar.lista_Autor();
        }
    }
}
