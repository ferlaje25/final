using BE_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ASAP
{
    public class DAUbigeo
    {
        public static List<Ubigeo> Listado()
        {
            List<Ubigeo> listado = new List<Ubigeo>();
            using (ASAPEntities data = new ASAPEntities())
            {
                listado = data.Ubigeo.OrderBy(x=>x.Pais).ThenBy(y=>y.Distrito).ToList();
            }
            return listado;
        }
        public static List<Ubigeo> ListadoAeropuerto()
        {
            List<Ubigeo> listado = new List<Ubigeo>();
            Ubigeo y = new Ubigeo();
            using (ASAPEntities data = new ASAPEntities())
            {
                y = data.Ubigeo.Where(x => x.Id_Ubigeo.Equals(20)).FirstOrDefault();
                listado = data.Ubigeo.Where(x => x.Aeropuerto != y.Aeropuerto).ToList();
            }
            return listado;
        }

        //TOÑO

        public static List<string> ListaPaises()
        {
            List<string> Lista = new List<string>();

            using (ASAPEntities data = new ASAPEntities())
            {
                //Lista = data.Ubigeo.Distinct().OrderBy(x => x.Pais).ToList();
                //Lista = data.Ubigeo.Select(x => x.Pais).Distinct().ToList();
                var L = ((from p in data.Ubigeo select p.Pais).Distinct()).ToList();
                Lista = L;
            }

            return Lista;
        }

        public static List<Ubigeo> ListaDepartamentos()
        {
            List<Ubigeo> Lista = new List<Ubigeo>();

            using (ASAPEntities data = new ASAPEntities())
            {
                Lista = data.Ubigeo.OrderBy(x => x.Departamento).ToList();
            }

            return Lista;
        }

        public static List<Ubigeo> ListaDistritos()
        {
            List<Ubigeo> Lista = new List<Ubigeo>();

            using (ASAPEntities data = new ASAPEntities())
            {
                Lista = data.Ubigeo.OrderBy(x => x.Distrito).ToList();
            }

            return Lista;
        }
    }
}
