using BE_ASAP;
using DA_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_ASAP
{
    public class BLUbigeo
    {
        public static List<Ubigeo> Listado()
        {
            return DAUbigeo.Listado();
        }
        public static List<Ubigeo> ListadoAeropuerto()
        {
            return DAUbigeo.ListadoAeropuerto();
        }

        //TOÑO
        public static List<string> Paises()
        {
            return DAUbigeo.ListaPaises();
        }
        public static List<Ubigeo> Departamentos()
        {
            return DAUbigeo.ListaDepartamentos();
        }
        public static List<Ubigeo> Distritos()
        {
            return DAUbigeo.ListaDistritos();
        }
    }
}