using BE_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ASAP
{
    public class DAAerolinea
    {
        public static List<Aerolinea> Listado()
        {
            List<Aerolinea> listado = new List<Aerolinea>();
            using (ASAPEntities data = new ASAPEntities())
            {
                listado = data.Aerolinea.ToList();
            }
            return listado;
        }

        public static bool Registrar(Aerolinea aerolinea)
        {
            bool exito = true;
           try
            {
                using (ASAPEntities data = new ASAPEntities())
                {
                    int nuevoCod = data.Aerolinea.Count() + 1;
                    //codigo = "0000000000000" + nuevoCod.ToString();
                    //codigo = "MO" + codigo.Substring(codigo.Length - 3);
                    aerolinea.Id_Aerolinea = nuevoCod;
                    data.Aerolinea.Add(aerolinea);
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
                Aerolinea obj = data.Aerolinea.Where(x => x.Id_Aerolinea.Equals(codigo)).FirstOrDefault();
                data.Aerolinea.Remove(obj);
                data.SaveChanges();
            }
            return exito;
        }
    }
}