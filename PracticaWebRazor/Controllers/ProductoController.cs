using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaWebRazor.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Productos
        public ActionResult AdminProductos()
        {
            return View();
        }


        public ActionResult Alta()
        {
            return View();
        }

        public ActionResult Guardar()
        {
            return View();
        }
    }
}