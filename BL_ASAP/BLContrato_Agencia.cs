using BE_ASAP;
using DA_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_ASAP
{
    public class BLContrato_Agencia
    {
        public static List<Contrato_Agencia> Listado()
        {
            return DAContrato_Agencia.Listado();
        }

        public static bool Registrar(Contrato_Agencia contrato)
        {
            return DAContrato_Agencia.Registrar(contrato);
        }
        public static bool Actualizar(Contrato_Agencia agencia)
        {
            return DAContrato_Agencia.Actualizar(agencia);
        }

        public static bool Eliminar(int codigo)
        {
            return DAContrato_Agencia.Eliminar(codigo);
        }
    }
}
