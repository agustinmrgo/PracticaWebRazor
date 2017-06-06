using PracticaWebRazor.ViewModels;
using PracticaWebRazor.Models;
using System.Web.Mvc;
using PracticaWebRazor.Extensions;
using PracticaWebRazor.Common;

namespace PracticaWebRazor.Controllers
{
    public class ClienteController : Controller
    {
        GestorClientes gestor = new GestorClientes();

        // GET: Cliente
        public ActionResult AdminClientes()
        {
            return View();
        }

        public ActionResult Alta()
        {
            //muestra la vista para cargar datos para dar de alta un cliente
            //pide al servidor el formulario vacio
            return View();
        }

        public ActionResult Baja()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Guardar(ViewCliente cliente)
        {
            /* Este metodo le pide al gestor que guarde el cliente
            inserta en la tabla de la base de datos
            Hacer: convertir el objeto view model que recibo como parametro a 
            tipo Model para el metodo Guardar del gestor */
            if (ModelState.IsValid)
                gestor.Guardar(cliente.ConvertirAModelo()); 
            // No deberia recibir un ViewModel tiene que ser un Model! Se convierte!
            else
                return View("Alta");
            return View("AdminClientes");
        }

        public ActionResult Borrar (ViewCliente cliente)
        {
            if (ModelState.IsValid)
                gestor.Eliminar(cliente.ConvertirAModelo());
            else
                return View("Baja");
            return View("AdminClientes");
        }

        public ActionResult EliminarPorApeYNom (ViewCliente cliente)
        {
            gestor.Eliminar(cliente.ConvertirAModelo());
            return RedirectToAction("Listar");
        }

        public ActionResult EliminarPorId(int id)
        {
            gestor.Eliminar(id);
            return RedirectToAction("Listar");
        }

        public ActionResult Modificar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Mod (ViewCliente cliente)
        {
            var apellidoN = Request.Form["ApellidoN"];
            var nombreN = Request.Form["NombreN"];
            int edadN; int.TryParse(Request.Form["EdadN"], out edadN);
            if (ModelState.IsValid)
                gestor.Modificar(cliente.ConvertirAModelo(), apellidoN, nombreN, edadN);
            return View("AdminClientes");
        }

        public ActionResult Buscar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Busqueda(string cliente)
        {
            Logger.Log("Paso por Action Busqueda cliente");
            var clientes = gestor.Buscar(cliente);
            return View(clientes.ConvertirAViewModels());
        }

        [HttpPost]
        public JsonResult BusquedaJSON(string cliente)
        {
            Logger.Log("Paso por Action BusquedaJSON cliente");
            var clientes = gestor.Buscar(cliente);
            return Json(clientes.ConvertirAViewModels(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Listar()
        {
            var clientes = gestor.Listar(); 
            return View(clientes.ConvertirAViewModels());
            // la vista recibe un ViewModels ! 
            // puede recibir un Models si no hace falta laburar con varios tipos de datos
        }

        public ActionResult Detalle(int id)
        {
            var cliente = gestor.BuscarPorId(id);
            return View(cliente.ConvertirAViewModel());
        }

        public ActionResult Modif(Cliente cliente)
        {
            gestor.Modif(cliente);
            return RedirectToAction("Listar");
        }

    }
}