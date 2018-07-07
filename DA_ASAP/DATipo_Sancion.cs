using BE_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ASAP
{
    public class DATip_Sancion
    {
        public static List<Tip_Sancion> Listado()
        {
            List<Tip_Sancion> listado = new List<Tip_Sancion>();
            using (ASAPEntities data = new ASAPEntities())
            {
                listado = data.Tip_Sancion.ToList();
            }
            return listado;
        }

        public static bool Registrar(Tip_Sancion tipsancion)
        {
            bool exito = true;
            //string codigo = string.Empty;
            try
            {
                using (ASAPEntities data = new ASAPEntities())
                {
                    int nuevoCod = data.Tip_Sancion.Count() + 1;
                    //codigo = "0000000000000" + nuevoCod.ToString();
                    //codigo = "MO" + codigo.Substring(codigo.Length - 3);
                    tipsancion.Id_Tip_Sancion = nuevoCod;
                    data.Tip_Sancion.Add(tipsancion);
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
                Tip_Sancion obj = data.Tip_Sancion.Where(x => x.Id_Tip_Sancion.Equals(codigo)).FirstOrDefault();
                data.Tip_Sancion.Remove(obj);
                data.SaveChanges();
            }
            return exito;
        }
    }
}