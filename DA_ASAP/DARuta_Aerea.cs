using BE_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ASAP
{
    public class DARuta_Aerea
    {
        public static List<Ruta_Aerea> Listado()
        {
            List<Ruta_Aerea> listado = new List<Ruta_Aerea>();
            using (ASAPEntities data = new ASAPEntities())
            {
                listado = data.Ruta_Aerea.ToList();
            }
            return listado;
        }
        public static List<Ruta_Aerea> ListadoOrigen(int id)
        {
            List<Ruta_Aerea> listado = new List<Ruta_Aerea>();
            using (ASAPEntities data = new ASAPEntities())
            {
                listado = data.Ruta_Aerea.Where(x => x.Id_Ubigeo_Origen == id).ToList();
            }
            return listado;
        }
        public static List<Ruta_Aerea> ListadoFin(int id)
        {
            List<Ruta_Aerea> listado = new List<Ruta_Aerea>();
            using (ASAPEntities data = new ASAPEntities())
            {
                listado = data.Ruta_Aerea.Where(x => x.Id_Ubigeo_Origen == id).ToList();
            }
            return listado;
        }

    }
}