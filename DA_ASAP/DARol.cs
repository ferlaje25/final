using BE_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ASAP
{
    public class DARol
    {
        public static Rol SuRol(int idRol)
        {
            Rol listado = new Rol();
            using (ASAPEntities data = new ASAPEntities())
            {
                listado = data.Rol.Where(x => x.Id_Rol == idRol).FirstOrDefault();
            }
            return listado;
        }

        public static int SuIdPorRol(string Roll)
        {
            Rol listado = new Rol();
            using (ASAPEntities data = new ASAPEntities())
            {
                listado = data.Rol.Where(x => x.Nom_Rol == Roll).FirstOrDefault();
            }
            int id = listado.Id_Rol;
            return id;
        }
    }
}
