using BE_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ASAP
{
    public class DADet_Ruta_Aerea
    {
        public static List<Det_Ruta_Aerea> Listado()
        {
            List<Det_Ruta_Aerea> listado = new List<Det_Ruta_Aerea>();
            using (ASAPEntities data = new ASAPEntities())
            {
                listado = data.Det_Ruta_Aerea.ToList();
            }
            return listado;
        }
        public static List<Det_Ruta_Aerea> Listado(int origen, int destino)
        {
            List<Det_Ruta_Aerea> listado = new List<Det_Ruta_Aerea>();
            using (ASAPEntities data = new ASAPEntities())
            {

                // listado = data.Det_Ruta_Aerea.Where(x=> x.Ruta_1.Equals).ToList();
            }
            return listado;
        }
        public static Det_Ruta_Aerea RutaSeleccionada(int id_Det_Ruta)
        {
            Det_Ruta_Aerea rutagrande = new Det_Ruta_Aerea();
            using(ASAPEntities data = new ASAPEntities())
            {
                rutagrande = data.Det_Ruta_Aerea.Where(x => x.Id_Det_Ruta_Aerea == id_Det_Ruta).FirstOrDefault();
            }
            return rutagrande;
        }

        public static bool Registrar(Det_Ruta_Aerea detRuta)
        {
            bool exito = true;
            //string codigo = string.Empty;
            try
            {
                using (ASAPEntities data = new ASAPEntities())
                {
                    int nuevoCod = data.Det_Ruta_Aerea.Count() + 1;
                    //codigo = "0000000000000" + nuevoCod.ToString();
                    //codigo = "MO" + codigo.Substring(codigo.Length - 3);
                    detRuta.Id_Det_Ruta_Aerea = nuevoCod;
                    data.Det_Ruta_Aerea.Add(detRuta);
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
                Det_Ruta_Aerea obj = data.Det_Ruta_Aerea.Where(x => x.Id_Det_Ruta_Aerea.Equals(codigo)).FirstOrDefault();
                data.Det_Ruta_Aerea.Remove(obj);
                data.SaveChanges();
            }
            return exito;
        }
    }

}

