using BE_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ASAP
{
    public class DADet_Progra_Tripulacion
    {
        public static bool obtenerCodigo(Det_Progra_Tripulacion Tripulacion)
        {
            bool exito = true;
            int id;
            try
            {
                using (ASAPEntities data = new ASAPEntities())
                {
                    id = data.Det_Progra_Tripulacion.Count() + 1;
                    Tripulacion.Id_Det_Progra_Tripulacion = id;
                    data.Det_Progra_Tripulacion.Add(Tripulacion);
                    data.SaveChanges();

                }
            }
            catch
            {
                exito = false;
            }
            return exito;
        }

    }
}
