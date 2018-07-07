using BE_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ASAP
{
    public class DASancion
    {
        public static int CantSanciones(int idEmpleado)
        {
            int cant = 0;
            using (ASAPEntities data = new ASAPEntities())
            {
                cant = data.Sancion.Where(x => x.Id_Empleado == idEmpleado).Count();

            }
            return cant;
        }


        public static List<Sancion> Listado()
        {
            List<Sancion> listado = new List<Sancion>();
            using (ASAPEntities data = new ASAPEntities())
            {
                listado = data.Sancion.ToList();
            }
            return listado;
        }

        public static bool Registrar(Sancion sancion)
        {
            bool exito = true;
            //string codigo = string.Empty;
            try
            {
                using (ASAPEntities data = new ASAPEntities())
                {
                    int nuevoCod = data.Sancion.Count() + 1;
                    //codigo = "0000000000000" + nuevoCod.ToString();
                    //codigo = "MO" + codigo.Substring(codigo.Length - 3);
                    sancion.Id_Sancion = nuevoCod;
                    data.Sancion.Add(sancion);
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
                Sancion obj = data.Sancion.Where(x => x.Id_Sancion.Equals(codigo)).FirstOrDefault();
                data.Sancion.Remove(obj);
                data.SaveChanges();
            }
            return exito;
        }

    }
}
