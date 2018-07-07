using BE_ASAP;
using DA_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_ASAP
{
    public class BLEmpleado
    {
        public static List<Empleado> EmpleadosPorRol(string rol)
        {
            int idRol = DARol.SuIdPorRol(rol);

            List<Contrato_Empleado> contratos = DAContratoEmpleado.ContratosPorRol(idRol);
            List<Empleado> listado = DAEmpleado.EmpleadosDesdeContratos(contratos);
            return listado;

            //Rol Rol = BLRol.SuRol((int)Contrato.Id_rol);
            //int cant = BLSancion.CantSancion(item.Id_Empleado);
            //return DAEmpleado.Listado();

        }
        public static List<Empleado> Listado()
        {
            return DAEmpleado.Listado();
        }


    }
}

