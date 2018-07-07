using BE_ASAP;
using BL_ASAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyASAP_Web.Areas.Aerolinea.Controllers
{
    public class AerolineaMenuController : Controller
    {
        // GET: Aerolinea/AerolineaMenu
        public ActionResult MenuAerolinea()
        {
            return View();
        }
        //---------PROGRAMACION VUELOS-------
        public ActionResult ProgradeVuelos()
        {
           ViewBag.ListadoAeropuertos = BLUbigeo.ListadoAeropuerto();
            return PartialView();
        }
        //-----Vuelo en la Ruta
        [HttpPost]
        public ActionResult listado(int origen, int fin, int escala)
        {
            this.listadorut(origen, fin, escala);
            return PartialView();
        }
        [HttpPost]
        public ActionResult RutaSeleccionada(int id_Det_Ruta, int escala)
        {
            ViewBag.NumEscala = escala;
            ViewBag.RutaSeleccionada = BLDETALLE_DE_RUTA.rutaSeleccionada(id_Det_Ruta);
            return PartialView();
        }
        public void listadorut(int origen, int fin, int escala)
        {
            ViewBag.NumEscala = escala;
            ViewBag.Listado_Detalle_Ruta = BLDETALLE_DE_RUTA.Listado();
            List<DETALLE_DE_RUTA> Listado_Detalle_Ruta = (List<DETALLE_DE_RUTA>)ViewBag.Listado_Detalle_Ruta;
            List<DETALLE_DE_RUTA> listaobjeto = new List<DETALLE_DE_RUTA>();
            foreach (DETALLE_DE_RUTA item in Listado_Detalle_Ruta)
            {
                if (item.Estado.Equals("Activo") && item.ID_R1ORIGEN.Equals(origen))
                {
                    switch (escala)
                    {
                        case 0:
                            if (item.Ruta_2.Equals(null) && item.ID_R1DESTINO.Equals(fin))
                            {
                                listaobjeto.Add(item);
                            }
                            break;
                        case 1:
                            if (item.Ruta_3.Equals(null) && item.ID_R2DESTINO.Equals(fin))
                            {
                                listaobjeto.Add(item);
                            }
                            break;
                        case 2:
                            if (item.Ruta_4.Equals(null) && item.ID_R3DESTINO.Equals(fin))
                            {
                                listaobjeto.Add(item);
                            }
                            break;
                        case 3:
                            if (item.Ruta_2 != null && item.ID_R4DESTINO.Equals(fin))
                            {
                                listaobjeto.Add(item);
                            }
                            break;
                    }
                }
            }

            ViewBag.ListadoDet_Rutas_Selec = listaobjeto;
        }
        //-----Aviones
        [HttpPost]
        public ActionResult AvionSeleccionado(/* int det_ruta*/)
        {
            Programacion_vuelo progra = (Programacion_vuelo)Session["ProgramacionVuelo"];
            ViewBag.PermisoOpera_Ruta = BLPermiso_Operacion.listaListadoPermisoRutaSelec(progra.Id_Det_Ruta_Aerea);
            ViewBag.Registro_Avion_Asap = BLRegistro_Avion_ASAP.listado_Registro_ASAP();
            ViewBag.Autorizacion_Operar = BLAutorizacion_Operar.lista_Autor_Operar();
            ViewBag.Avion = BLAvion.listado();
            return PartialView();
        }
        public JsonResult prograVueloSinAvion(string vFecha_Programacion, string vFecha_Vuelo, string vHora_Vuelo, double vTiempo_Vuelo, string vEstado_Vuelo, string vFecha_Llegada_vuelo, string vHora_Llegada, double vPrecio_Base, int vId_Empleado, int vId_Det_Ruta_Aerea)
        {
            Programacion_vuelo programacion = new Programacion_vuelo();
            programacion.Fecha_Programacion = DateTime.Parse(vFecha_Programacion);
            programacion.Fecha_Vuelo = System.DateTime.Parse(vFecha_Vuelo);
            programacion.Hora_Vuelo = System.TimeSpan.Parse(vHora_Vuelo);
            programacion.Tiempo_Vuelo = Convert.ToDecimal(vTiempo_Vuelo);
            programacion.Estado_Vuelo = vEstado_Vuelo;
            programacion.Fecha_Llegada_vuelo = System.DateTime.Parse(vFecha_Llegada_vuelo);
            programacion.Hora_Llegada = System.TimeSpan.Parse(vHora_Llegada);
            programacion.Precio_Base = Convert.ToDecimal(vPrecio_Base);
            programacion.Id_Empleado = vId_Empleado;
            programacion.Id_Det_Ruta_Aerea = vId_Det_Ruta_Aerea;
            //BLProgramacion_Vuelo.obtenerCodigo(programacion);
            Session["ProgramacionVuelo"] = programacion;
            return Json(new { succes = true });
            // Session["ProgramacionVuelo"] = modelo;
        }

        public JsonResult prograVueloConAvion(int id_avion)
        {
            Programacion_vuelo progra = (Programacion_vuelo)Session["ProgramacionVuelo"];
            progra.Id_Avion = id_avion;
            Session["ProgramacionVuelo"] = progra;
            return Json(new { succes = true });
        }
        //-----Tripulacion
        public ActionResult PrograTripulacion()
        {
            return PartialView();
        }
        public ActionResult PrograCapitan()
        {
            return PartialView();
        }
        public ActionResult PrograAuxCabina()
        {
            return PartialView();
        }
        public ActionResult PrograJefeTrip()
        {
            return PartialView();
        }
        public ActionResult PrograAuxiliarTrip()
        {
            return PartialView();
        }
        [HttpPost]
        public JsonResult FiltrarTabla(int idselec, int rol)
        {

            Tripulacion tripuu = new Tripulacion();
            tripuu.IdEmpleTrip = idselec;
            tripuu.IdRolTrip = rol;
            List<Tripulacion> listado = (List<Tripulacion>)Session["TripulacionSelec"];
            if (listado.Where(x => x.IdRolTrip == rol).Count() == 1 && (rol == 1 || rol == 3))
            {
                Tripulacion elegido = (Tripulacion)listado.Where(x => x.IdRolTrip == rol).FirstOrDefault();
                listado.Remove(elegido);
                listado.Add(tripuu);
            }
            else
            {
                listado.Add(tripuu);
            }
            Session["TripulacionSelec"] = listado;
            bool exito = false;
            if (Session["TripulacionSelec"] != null)
            {
                exito = true;
            }

            return Json(new { success = exito, oldval = "" });
        }

        [HttpPost]
        public JsonResult DeshacerFiltro(int idselec, int rol)
        {

            List<Tripulacion> listado = (List<Tripulacion>)Session["TripulacionSelec"];
            Tripulacion elegidodes = (Tripulacion)listado.Where(x => x.IdEmpleTrip == idselec).FirstOrDefault();
            listado.Remove(elegidodes);

            Session["TripulacionSelec"] = listado;
            bool exito = false;
            if (Session["TripulacionSelec"] != null)
            {
                exito = true;
            }

            return Json(new { success = exito, oldval = "" });
        }


        [HttpPost]
        public JsonResult RegistrarProgramacionVuelo()
        {
            Programacion_vuelo programacion = (Programacion_vuelo)Session["ProgramacionVuelo"];
            programacion.Id_Progra_Vuelo = BLProgramacion_Vuelo.obtenerCodigo();
            BLProgramacion_Vuelo.obtenerCodigo(programacion);
            List<Tripulacion> listaTripu = (List<Tripulacion>)Session["TripulacionSelec"];
            Det_Progra_Tripulacion personal = new Det_Progra_Tripulacion();
            List<Det_Progra_Tripulacion> listadoFinalTripulacion = new List<Det_Progra_Tripulacion>();
            foreach (Tripulacion item in listaTripu)
            {
                personal.Cantidad_trip = 1;
                personal.Estado = "Activo";
                personal.Fecha_Registro = DateTime.Now;
                personal.Fecha_Actualizacion = DateTime.Now;
                personal.Estado_Actividad = "Activo";
                personal.Id_Prog_Vuelo = programacion.Id_Progra_Vuelo;
                personal.Id_Empleado = item.IdEmpleTrip;
                personal.Id_Rol_Trip = item.IdRolTrip;
                BLDet_Progra_Tripulacion.obtenerCodigo(personal);
            }
            return Json(new { succes = true });

        }
        //--------FIN------------------------
        //-----------MONITOREO VUELOS--------
        public ActionResult MonitoreoVuelos()
        {
            return PartialView();
        }
        //----------FIN----------------------
        //------------ACTUALIZACION VUELOS---
        public ActionResult ActualizacionVuelo()
        {
            return PartialView();
        }
        //------------FIN---------------------
        //------------CONTRATO AGENCIAS-------
        public ActionResult ContratoAgencia()
        {
            return PartialView();
        }
        //----------FIN------------------------


    }
}