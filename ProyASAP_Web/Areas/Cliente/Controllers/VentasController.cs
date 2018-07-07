using BE_ASAP;
using BL_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyASAP_Web.Areas.Cliente.Controllers
{

    public class VentasController : Controller
    {
        // GET: Venta/Ventas
        public ActionResult IndexVentasVuelos()
        {
            return View();
        }
        public ActionResult BusquedaVuelo()
        {
            return PartialView();
        }

        public ActionResult SeleccionVuelo()
        {
            return PartialView();
        }

        public ActionResult RegistroPasajero()
        {
            return PartialView();
        }

        public ActionResult PasarelaPago()
        {
            return PartialView();
        }
        [HttpPost]
        public JsonResult InfoBusVuelo(string vorigenvuelo, string vdestinovuelo, int vpasajerovuelo)
        {
            InfoDeVenta Informacion = new InfoDeVenta();

            Informacion.Origen = vorigenvuelo;
            Informacion.Destino = vdestinovuelo;
            Informacion.CantPasajeros = vpasajerovuelo;

            Session["InfoVentas"] = Informacion;

            bool exito = false;
            if (Session["InfoVentas"] != null)
            {
                exito = true;
            }
            return Json(new { success = exito, oldval = "" });
        }
       // [HttpPost]
        //public JsonResult Reservacion(string vnombre,string vapellido, DateTime vfechnac , string vgenero, string vtipDoc, int vnumdoc, string vdireccion , string vpais, string vdepart, string vciudad)
        //{
        //    InfoDeVenta Informacion2 = new InfoDeVenta();
        //    BE_ASAP.Cliente clie = new BE_ASAP.Cliente();
        //    //clie.nombre;
        //    //clie.Ape_Cliente;


        //    Informacion2 = (InfoDeVenta)Session["InfoVentas"];
        //    //Informacion2
        //    //return Json(new { success = exito, oldval = "" });
        //}
    }
}