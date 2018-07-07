using BE_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ASAP
{
    public class DAEmpleado
    {
        public static List<Empleado> Listado()
        {
            List<Empleado> listado = new List<Empleado>();
            using (ASAPEntities data = new ASAPEntities())
            {
                listado = data.Empleado.Where(x => x.Estado == "Activo").ToList();
            }
            return listado;
        }

        //public static List<Empleado> LBuscaCargo() ////FALTAAAA
        //{
        //    List<Empleado> listado = new List<Empleado>();
        //    using (ASAP6Entities data = new ASAP6Entities())
        //    {
        //        listado = data.Empleado.Where(x => x.estado == "Activo").ToList();
        //    }
        //    return listado;
        //}

        public static List<Empleado> EmpleadosDesdeContratos(List<Contrato_Empleado> contratos)
        {
            List<Empleado> listado = new List<Empleado>();
            List<Empleado> listadoactivo = new List<Empleado>();
            using (ASAPEntities data = new ASAPEntities())
            {
                foreach (var item in contratos)
                {
                    listado.Add(data.Empleado.Where(x => x.Id_Empleado == item.Id_Empleado).FirstOrDefault());
                }
                listadoactivo = listado.Where(x => x.Estado == "Activo").ToList();

            }
            return listadoactivo;
        }



    }
}
