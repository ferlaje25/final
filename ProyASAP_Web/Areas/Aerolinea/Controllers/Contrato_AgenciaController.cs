using BE_ASAP;
using BL_ASAP;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyASAP_Web.Areas.Aerolinea.Controllers
{
    public class Contrato_AgenciaController : Controller
    {
        // GET: Aerolinea/Contrato_Agencia
        public ActionResult Index()
        {
            return PartialView();
        }

        public ActionResult Listado()
        {
            ViewBag.ListadoContrato = BLContrato_Agencia.Listado();
            ViewBag.ListadoAgencia = BLAgencia_Viaje.Listado();
            ViewBag.ListadoAerolinea = BLAerolinea.Listado();

            return PartialView();
        }

        [HttpPost]
        public ActionResult Crear()
        {
            ViewBag.ListadoContrato = BLContrato_Agencia.Listado();
            ViewBag.ListadoAgencia = BLAgencia_Viaje.Listado();
            ViewBag.ListadoAerolinea = BLAerolinea.Listado();
            return PartialView();
        }

        [HttpPost]
        public JsonResult GrabarContrato(DateTime Fecha_Ini_Contrato, DateTime Fecha_Fin_Contrato, string Descripcion, decimal Primer_Descuento, int Tope1, decimal Segundo_Descuento, int Tope2, int Id_Agencia_Viaje, int Id_Aerolinea, string Estado)
        {
            Contrato_Agencia contrato = new Contrato_Agencia();
            contrato.Fecha_Ini_Contrato = Fecha_Ini_Contrato;
            contrato.Fecha_Fin_Contrato = Fecha_Fin_Contrato;
            contrato.Descripcion = Descripcion;
            contrato.Primer_Descuento = Primer_Descuento;
            contrato.Tope1 = Tope1;
            contrato.Segundo_Descuento = Segundo_Descuento;
            contrato.Tope2 = Tope2;
            contrato.Id_Agencia_Viaje = Id_Agencia_Viaje;
            contrato.Id_Aerolinea = Id_Aerolinea;
            contrato.Estado = Estado;

            bool exito = BLContrato_Agencia.Registrar(contrato);

            return Json(new { success = exito, oldval = "" });
        }

        [HttpPost]
        public JsonResult ActualizarContrato(int Id_Contrato_Agencia, DateTime Fecha_Ini_Contrato, DateTime Fecha_Fin_Contrato, string Descripcion, Decimal Primer_Descuento, int Tope1, Decimal Segundo_Descuento, int Tope2, int Id_Agencia_Viaje, int Id_Aerolinea, string Estado)
        {
            bool exito = true;
            try
            {
                Contrato_Agencia contrato = new Contrato_Agencia();
                contrato.Id_Contrato_Agencia = Id_Contrato_Agencia;
                contrato.Fecha_Ini_Contrato = Fecha_Ini_Contrato;
                contrato.Fecha_Fin_Contrato = Fecha_Fin_Contrato;
                contrato.Descripcion = Descripcion;
                contrato.Primer_Descuento = Primer_Descuento;
                contrato.Tope1 = Tope1;
                contrato.Segundo_Descuento = Segundo_Descuento;
                contrato.Tope2 = Tope2;
                contrato.Id_Agencia_Viaje = Id_Agencia_Viaje;
                contrato.Id_Aerolinea = Id_Aerolinea;
                contrato.Estado = Estado;
               BLContrato_Agencia.Actualizar(contrato);
            }
            catch
            {
                exito = false;
            }


            return Json(new { success = exito, oldval = "" });
        }

        [HttpPost]
        public ActionResult EditarContrato(int idContrato)
        {
            //bool exito = true;
            //try
            //{
            List<Contrato_Agencia> listadoContrato = (List<Contrato_Agencia>)BLContrato_Agencia.Listado();
            Contrato_Agencia contrato;
            contrato = listadoContrato.Where(x => x.Id_Contrato_Agencia.Equals(idContrato)).FirstOrDefault();
            ViewBag.contrato = contrato;
            ViewBag.ListadoAgencia = BLAgencia_Viaje.Listado();
            ViewBag.ListadoAerolinea = BLAerolinea.Listado();
            //}
            //catch
            //{
            //    exito = false;
            //}

            return PartialView("Crear");
        }

        [HttpPost]
        public JsonResult EliminarContrato(int idContrato)
        {
            bool exito = BLContrato_Agencia.Eliminar(idContrato);

            return Json(new { success = exito, oldval = "" });
        }

    }
}