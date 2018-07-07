using BE_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ASAP
{
    public class DAContratoEmpleado
    {
        public static Contrato_Empleado ElContrato(int idEmpleado)
        {
            Contrato_Empleado listado = new Contrato_Empleado();
            using (ASAPEntities data = new ASAPEntities())
            {
                listado = data.Contrato_Empleado.Where(x => x.Id_Empleado == idEmpleado).FirstOrDefault();

            }
            return listado;
        }
        public static List<Contrato_Empleado> ContratosPorRol(int idRol)
        {
            List<Contrato_Empleado> listado = new List<Contrato_Empleado>();
            using (ASAPEntities data = new ASAPEntities())
            {
                listado = data.Contrato_Empleado.Where(x => x.Id_Rol == idRol).ToList();

            }
            return listado;
        }


    }
}
