using PracticaWebRazor.Common;
using PracticaWebRazor.Extensions;
using PracticaWebRazor.Models;
using System.Collections.Generic;
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

        public ActionResult Guardar(ViewModels.ViewProducto producto)
        {
            if (ModelState.IsValid)
                gestor.Guardar(producto.ConvertirAModelo());
            else
                return View("Alta");
            return View("/Producto/AdminProductos");
        }

        public ActionResult Buscar()
        {
            return View();
        }

        public ActionResult Busqueda(string prod)
        {
            Logger.Log("Paso por busqueda producto");
            var productos = gestor.Buscar(prod);
            return View(productos.ConvertirAViewModels());
        }

        public ActionResult Listar()
        {
            var productos = gestor.Listar();
            return View(productos.ConvertirAViewModels());
        }

    }
}