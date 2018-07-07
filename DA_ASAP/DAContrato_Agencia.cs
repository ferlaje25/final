using BE_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ASAP
{
    public class DAContrato_Agencia
    {
        public static List<Contrato_Agencia> Listado()
        {
            List<Contrato_Agencia> listado = new List<Contrato_Agencia>();
            using (ASAPEntities data = new ASAPEntities())
            {
                listado = data.Contrato_Agencia.ToList();
            }
            return listado;
        }

        public static bool Registrar(Contrato_Agencia contrato)
        {
            bool exito = true;
            try
            {
                using (ASAPEntities data = new ASAPEntities())
                {
                    int nuevoCod = data.Contrato_Agencia.Count() + 1;
                    contrato.Id_Contrato_Agencia = nuevoCod;
                    data.Contrato_Agencia.Add(contrato);
                    data.SaveChanges();
                }
            }
            catch
            {
                exito = false;
            }
            return exito;
        }

        public static bool Actualizar(Contrato_Agencia contrato)
        {
            bool exito = true;
            try
            {
                using (ASAPEntities data = new ASAPEntities())
                {
                    var model = data.Contrato_Agencia.Where(x => x.Id_Contrato_Agencia == contrato.Id_Contrato_Agencia).FirstOrDefault();
                    model.Fecha_Ini_Contrato = contrato.Fecha_Ini_Contrato;
                    model.Fecha_Fin_Contrato = contrato.Fecha_Fin_Contrato;
                    model.Descripcion = contrato.Descripcion;
                    model.Estado = contrato.Estado;
                    model.Primer_Descuento = contrato.Primer_Descuento;
                    model.Tope1 = contrato.Tope1;
                    model.Segundo_Descuento = contrato.Segundo_Descuento;
                    model.Tope2 = contrato.Tope2;
                    model.Id_Agencia_Viaje = contrato.Id_Contrato_Agencia;
                    model.Id_Aerolinea = contrato.Id_Aerolinea;
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
                Contrato_Agencia obj = data.Contrato_Agencia.Where(x => x.Id_Contrato_Agencia.Equals(codigo)).FirstOrDefault();
                data.Contrato_Agencia.Remove(obj);
                data.SaveChanges();
            }
            return exito;
        }
    }
}
