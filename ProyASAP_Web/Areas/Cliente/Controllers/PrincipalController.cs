using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyASAP_Web.Areas.Cliente.Controllers
{
    public class PrincipalController : Controller
    {
        // GET: Cliente/Principal
        public ActionResult IndexPrincipal()
        {
            return View();
        }
        public ActionResult Login()
        {
            return PartialView();
        }

    }
}