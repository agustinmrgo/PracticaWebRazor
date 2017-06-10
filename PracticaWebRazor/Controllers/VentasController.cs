using PracticaWebRazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaWebRazor.Controllers
{
    public class VentasController : Controller
    {
        GestorVentas gestor = new GestorVentas();

        // GET: Ventas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Alta()
        {
            return View();
        }

        public ActionResult Listar()
        {
            var ventas = gestor.Listar();
            return View(ventas);
        }

        public ActionResult Guardar(Ventas venta)
        {
            gestor.Guardar(venta);
            return RedirectToAction("Listar");
        }

    }
}