using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_ASAP;
using BE_ASAP;

namespace BL_ASAP
{
    public class BLContrato_Empleado
    {
        public static Contrato_Empleado ElContrato(int idEmple)
        {
            return DAContratoEmpleado.ElContrato(idEmple);

        }
        public static List<Contrato_Empleado> ContratosPorRol(int roll)
        {
            return DAContratoEmpleado.ContratosPorRol(roll);

        }



    }
}

