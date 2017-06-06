using PracticaWebRazor.Common;
using PracticaWebRazor.Extensions;
using PracticaWebRazor.Models;
using PracticaWebRazor.ViewModels;
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

        [HttpPost]
        public ActionResult Guardar(ViewProducto producto)
        {
            if (ModelState.IsValid)
                gestor.Guardar(producto.ConvertirAModelo());
            else
                return View("Alta");
            return View("AdminProductos");
        }

        public ActionResult Buscar()
        {
            return View();
        }

        [HttpPost]
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