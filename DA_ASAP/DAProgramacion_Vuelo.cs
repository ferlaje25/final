using BE_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ASAP
{
    public class DAProgramacion_Vuelo
    {

        public static int obtenerCodigo()
        {
            int id;
            using (ASAPEntities data = new ASAPEntities())
            {
                 id = data.Programacion_vuelo.Count() + 1;
            }
            return id;
        }
        public static bool obtenerCodigo(Programacion_vuelo programa_Vuelo)
        {
            bool exito = true;
            int id;
            try {
                using (ASAPEntities data = new ASAPEntities())
                {
                    id = data.Programacion_vuelo.Count() + 1;
                   // programa_Vuelo.Id_Progra_Vuelo = id;
                    data.Programacion_vuelo.Add(programa_Vuelo);
                    data.SaveChanges();

                }
            }
            catch {
                exito = false;
            }
            return exito;
        }

        //--------------------------------

        public static List<Programacion_vuelo> Listado()
        {
            List<Programacion_vuelo> listado = new List<Programacion_vuelo>();
            using (ASAPEntities data = new ASAPEntities())
            {
                listado = data.Programacion_vuelo.ToList();
            }
            return listado;
        }

        public static bool Registrar(Programacion_vuelo Progvuelo)
        {
            bool exito = true;
            try
            {
                using (ASAPEntities data = new ASAPEntities())
                {
                    int nuevoCod = data.Programacion_vuelo.Count() + 1;
                    Progvuelo.Id_Progra_Vuelo = nuevoCod;
                    data.Programacion_vuelo.Add(Progvuelo);
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
                Programacion_vuelo obj = data.Programacion_vuelo.Where(x => x.Id_Progra_Vuelo.Equals(codigo)).FirstOrDefault();
                data.Programacion_vuelo.Remove(obj);
                data.SaveChanges();
            }
            return exito;
        }




    }
}
