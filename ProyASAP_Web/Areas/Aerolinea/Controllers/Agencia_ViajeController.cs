using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL_ASAP;
using BE_ASAP;

namespace ProyASAP_Web.Areas.Aerolinea.Controllers
{
    public class Agencia_ViajeController : Controller
    {
        // GET: Aerolinea/Agencia_Viaje

        public ActionResult MenuAgencia()
        {
            return View();
        }
        public ActionResult Index()
        {
            return PartialView();
        }
        public ActionResult Listado()
        {
            ViewBag.ListadoAgencia = BLAgencia_Viaje.Listado();
            ViewBag.ListadoDocumento = BLTipo_Documento.Listado();
            ViewBag.ListadoUbigeo = BLUbigeo.Listado();

            return PartialView();
        }

        [HttpPost]
        public ActionResult Crear()
        {
            ViewBag.ListadoAgencia = BLAgencia_Viaje.Listado();
            ViewBag.ListadoDocumento = BLTipo_Documento.Listado();
            ViewBag.ListadoUbigeo = BLUbigeo.Listado();
            return PartialView();
        }

        
        [HttpPost]
        public JsonResult GrabarAgencia(string Razon_Social, int Id_Tipo_Documento, string Num_Documento, int Id_Ubigeo, string Direccion, string Representante_Legal, int Telefono, string Estado )
        {
            Agencia_Viaje agencia = new Agencia_Viaje();
            agencia.Razon_Social = Razon_Social;
            agencia.Id_Tipo_Documento = Id_Tipo_Documento;
            agencia.Num_Documento = Num_Documento;
            agencia.Id_Ubigeo = Id_Ubigeo;
            agencia.Direccion = Direccion;
            agencia.Representante_Legal = Representante_Legal;
            agencia.Telefono = Telefono;
            agencia.Estado = Estado;

            bool exito = BLAgencia_Viaje.Registrar(agencia);

            return Json(new { success = exito, oldval = "" });
        }

        [HttpPost]
        public JsonResult ActualizarAgencia( int IdAgencia, string Razon_Social, int Id_Tipo_Documento, string Num_Documento, int Id_Ubigeo, string Direccion, string Representante_Legal, int Telefono, string Estado)
        {
            bool exito = true;
            try
            {
                Agencia_Viaje agencia = new Agencia_Viaje();
                agencia.Id_Agencia_Viaje = IdAgencia;
                agencia.Razon_Social = Razon_Social;
                agencia.Id_Tipo_Documento = Id_Tipo_Documento;
                agencia.Num_Documento = Num_Documento;
                agencia.Id_Ubigeo = Id_Ubigeo;
                agencia.Direccion = Direccion;
                agencia.Representante_Legal = Representante_Legal;
                agencia.Telefono = Telefono;
                agencia.Estado = Estado;
                BLAgencia_Viaje.Actualizar(agencia);
               // BLAgencia_Viaje.Eliminar(nuevoAgencia.Id_Agencia_Viaje);
                //BLAgencia_Viaje.Registrar(nuevoAgencia);
            }
            catch
            {
                exito = false;
            }
            return Json(new { success = exito, oldval = "" });
        }

        [HttpPost]
        public ActionResult EditarAgencia(int idAgencia)
        {


            //bool exito = true;
            //try
            //{
                List<Agencia_Viaje> listadoAgencia = (List<Agencia_Viaje>)BLAgencia_Viaje.Listado();
                Agencia_Viaje agencia;
                agencia = listadoAgencia.Where(x => x.Id_Agencia_Viaje.Equals(idAgencia)).FirstOrDefault();
                ViewBag.Agencia = agencia;
                //ViewBag.ListadoAgencia = BLAgencia_Viaje.Listado();
                ViewBag.ListadoDocumento = BLTipo_Documento.Listado();
                ViewBag.ListadoUbigeo = BLUbigeo.Listado();
            //}
            //catch
            //{
            //    exito = false;
            //}

            return PartialView("Crear");
        }

        [HttpPost]
        public JsonResult EliminarAgencia(int idAgencia)
        {
            bool exito = BLAgencia_Viaje.Eliminar(idAgencia);

            return Json(new { success = exito, oldval = "" });
        }


    }
}