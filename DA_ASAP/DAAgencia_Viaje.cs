using BE_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ASAP
{
    public class DAAgencia_Viaje
    {
        public static List<Agencia_Viaje> Listado()
        {
            List<Agencia_Viaje> listado = new List<Agencia_Viaje>();
            using (ASAPEntities data = new ASAPEntities())
            {
                listado = data.Agencia_Viaje.ToList();
            }
            return listado;
        }

        //public static List<Agencia_Viaje> ListadoPorEstado()
        //{
        //    List<Agencia_Viaje> listado = new List<Agencia_Viaje>();
        //    using (ASAPEntities data = new ASAPEntities())
        //    {
        //        listado = data.Agencia_Viaje.Where(x=>x.Estado=="Activo").ToList();
        //    }
        //    return listado;
        //}

        public static bool Registrar(Agencia_Viaje agencia)
        {
            bool exito = true;
            //string codigo = string.Empty;
            try
            {
                using (ASAPEntities data = new ASAPEntities())
                {
                    int nuevoCod = data.Agencia_Viaje.Count() + 1;
                    agencia.Id_Agencia_Viaje = nuevoCod;
                    data.Agencia_Viaje.Add(agencia);
                    data.SaveChanges();
                }
            }
            catch
            {
                exito = false;
            }
            return exito;
        }

        public static bool Actualizar(Agencia_Viaje agencia)
        {
            bool exito = true;
            try
            {
                using (ASAPEntities data = new ASAPEntities())
                {
                    var model = data.Agencia_Viaje.Where(x => x.Id_Agencia_Viaje == agencia.Id_Agencia_Viaje).FirstOrDefault();
                    model.Razon_Social = agencia.Razon_Social;
                    model.Num_Documento = agencia.Num_Documento;
                    model.Direccion = agencia.Direccion;
                    model.Representante_Legal = agencia.Representante_Legal;
                    model.Telefono = agencia.Telefono;
                    model.Estado = agencia.Estado;
                    model.Id_Tipo_Documento = agencia.Id_Tipo_Documento;
                    model.Id_Ubigeo = agencia.Id_Ubigeo;
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
                Agencia_Viaje obj = data.Agencia_Viaje.Where(x => x.Id_Agencia_Viaje.Equals(codigo)).FirstOrDefault();
                data.Agencia_Viaje.Remove(obj);
                data.SaveChanges();
            }
            return exito;
        }

        public static Agencia_Viaje ObtenerAgenciaPorID(int codigo)
        {
            Agencia_Viaje obj = new Agencia_Viaje();
            using (ASAPEntities data = new ASAPEntities())
            {
                obj = data.Agencia_Viaje.Where(x => x.Id_Agencia_Viaje.Equals(codigo)).FirstOrDefault();

            }
            return obj;
        }


    }
}
