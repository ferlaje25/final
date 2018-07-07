using BE_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ASAP
{
    public class DAAvion
    {
        public static List<Avion> listado_Aviones()
        {
            List<Avion> listado = new List<Avion>();
            using (ASAPEntities data = new ASAPEntities())
            {
                listado = data.Avion.Where(x => x.Id_Aerolinea == 1).ToList();

                }
            return listado;
        }
        public static bool Registrar(Avion avion)
        {
            bool exito = true;
            //string codigo = string.Empty;
            try
            {
                using (ASAPEntities data = new ASAPEntities())
                {
                    int nuevoCod = data.Avion.Count() + 1;
                    //codigo = "0000000000000" + nuevoCod.ToString();
                    //codigo = "MO" + codigo.Substring(codigo.Length - 3);
                    avion.Id_Avion = nuevoCod;
                    data.Avion.Add(avion);
                    data.SaveChanges();
                }
            }
            catch
            {
                exito = false;
            }
            return exito;
        }

        public static bool Eliminar(int codigo)
        {
            bool exito = true;
            using (ASAPEntities data = new ASAPEntities())
            {
                Avion obj = data.Avion.Where(x => x.Id_Avion.Equals(codigo)).FirstOrDefault();
                data.Avion.Remove(obj);
                data.SaveChanges();
            }
            return exito;
        }



    }
}
