using PracticaWebRazor.Common;
using PracticaWebRazor.Extensions;
using PracticaWebRazor.Models;
using PracticaWebRazor.ViewModels;
using System.Web.Mvc;
using System.Linq;

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

        public ActionResult Baja()
        {
            return View();
        }

        public ActionResult Eliminar(ViewProducto prod)
        {
            if (ModelState.IsValid)
                gestor.Eliminar(prod.ConvertirAModelo());
            else
                return View("Baja");
            return View("AdminClientes");
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

        public JsonResult ObtenerNombreProductos()
        {
            var listaProductos = gestor.Listar();
            var result = listaProductos.Select(prod => new
            { Name = prod.IdProducto, value = prod.Nombre });
            //devuelve una coleccion de tipo anonimo (mezcla de Id+Nombre)
            //value sera el valor que se obtiene de seleccionar algo en el autocompletar
            //Name sera lo que se muestra mientras autocompleta
            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}