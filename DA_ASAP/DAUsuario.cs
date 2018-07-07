using BE_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ASAP
{
    public class DAUsuario
    {
        public static List<Usuario> Listado( string user, string contr)
        {
            List<Usuario> listado = new List<Usuario>();
            using (ASAPEntities data = new ASAPEntities())
            {
                listado = data.Usuario.Where(x => x.User_Sist.Equals(user) &  x.Contrase.Equals(contr)).ToList() ;
            }
            return listado;
        }
    }
}
