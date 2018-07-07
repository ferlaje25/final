using BE_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_ASAP
{
    public class BLUsuario
    {
        public static List<Usuario> Listado(string user, string contr)
        {
            return DA_ASAP.DAUsuario.Listado(user, contr);
        }
    }
}
