using BE_ASAP;
using BL_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyASAP_Web.Areas.Aerolinea.Controllers
{
    public class SancionController : Controller
    {
        // GET: Aerolinea/Sancion
        public ActionResult MenuPersonal()
        {
            return View();
        }

        public ActionResult Index()
        {
            return PartialView();
        }

        public ActionResult Listado()
        {
            ViewBag.ListadoSancion = BLSancion.Listado();
            ViewBag.ListadoTipSancion = BLTip_Sancion.Listado();
            ViewBag.ListadoEmpleado = BLEmpleado.Listado();

            return PartialView();
        }

        [HttpPost]
        public ActionResult Crear()
        {
            ViewBag.ListadoSancion = BLSancion.Listado();
            ViewBag.ListadoTipSancion = BLTip_Sancion.Listado();
            ViewBag.ListadoEmpleado = BLEmpleado.Listado();
            return PartialView();
        }

        [HttpPost]
        public JsonResult GrabarSancion(int Id_Tip_Sancion, int Id_Empleado, string Detalle)
        {
            Sancion sancion = new Sancion();
            //sancion.Id_Sancion = this.ObtenerCodigo();
            sancion.Id_Tip_Sancion = Id_Tip_Sancion;
            sancion.Id_Empleado = Id_Empleado;
            sancion.Detalle = Detalle;

            bool exito = BLSancion.Registrar(sancion);
            //bool exito = this.Grabar(agencia);

            return Json(new { success = exito, oldval = "" });
        }

        [HttpPost]
        public JsonResult EliminarSancion(int idSancion)
        {
            //bool exito = this.Eliminar(codModelo);
            bool exito = BLSancion.Eliminar(idSancion);

            return Json(new { success = exito, oldval = "" });
        }

        [HttpPost]
        public JsonResult ActualizarSancion(Sancion nuevoSancion)
        {
            bool exito = true;
            try
            {
                //this.Eliminar(nuevoSancion.Id_Sancion);
                //this.Grabar(nuevoSancion);
                BLSancion.Eliminar(nuevoSancion.Id_Sancion);
                BLSancion.Registrar(nuevoSancion);
            }
            catch
            {
                exito = false;
            }


            return Json(new { success = exito, oldval = "" });
        }

        [HttpPost]
        public ActionResult EditarSancion(int idSancion)
        {
            bool exito = true;
            try
            {
                List<Sancion> listadoSancion = (List<Sancion>)Session["ListadoSancion"];
                Sancion sancion;
                sancion = listadoSancion.Where(x => x.Id_Sancion.Equals(idSancion)).FirstOrDefault();
                ViewBag.Agencia = sancion;
                ViewBag.ListadoTipoSancion = Session["ListadoTipoSancion"];
                ViewBag.ListadoEmpleado = Session["ListadoEmpleado"];
            }
            catch
            {
                exito = false;
            }

            return PartialView("Crear");
        }

    }
}