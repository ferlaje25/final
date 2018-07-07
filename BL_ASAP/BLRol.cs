using BE_ASAP;
using DA_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_ASAP
{
    public class BLRol
    {
        public static Rol SuRol(int id_Rol)
        {
            return DARol.SuRol(id_Rol);

        }
        public static int IdPorRoles(string Roll)
        {

            return DARol.SuIdPorRol(Roll);

        }

    }
}
