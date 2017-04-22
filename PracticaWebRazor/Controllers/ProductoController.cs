using PracticaWebRazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaWebRazor.Controllers
{
    public class ProductoController : Controller
    {
        GestorProductos gestor = new GestorProductos();
        // GET: Productos
        public ActionResult AdminProductos()
        {
            return View();
        }


        public ActionResult Alta()
        {
            return View();
        }

        public ActionResult Guardar(ViewModels.Producto producto)
        {
            if (ModelState.IsValid)
                gestor.Guardar(producto);
            else
                return View("Alta");
            return View("/Producto/AdminProductos");
        }
    }
}