using PracticaWebRazor.ViewModels;
using PracticaWebRazor.Models;
using System.Web.Mvc;
using System.Collections.Generic;
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

        public ActionResult Guardar(ViewModels.Cliente cliente)
        {
            // este metodo le pide al gestor que guarde el cliente
            // inserta en la tabla de la base de datos
            /* Hacer: convertir el objeto view model que recibo como parametro a 
            tipo Model para el metodo Guardar del gestor */
            if (ModelState.IsValid)
                gestor.Guardar(cliente.ConvertirAModelo()); 
            // no deberia recibir un ViewModel tiene que ser un Model! Se convierte!
            else
                return View("Alta");
            return View("AdminClientes");
        }

        public ActionResult Borrar (ViewModels.Cliente cliente)
        {
            if (ModelState.IsValid)
                gestor.Eliminar(cliente.ConvertirAModelo());
            else
                return View("Baja");
            return View("AdminClientes");
        }

        public ActionResult EliminarPorApeYNom (ViewModels.Cliente cliente)
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

        public ActionResult Modificar (ViewModels.Cliente cliente)
        {
            if (ModelState.IsValid)
                return View("Mod");
            return View("AdminClientes");
        }

        public ActionResult Buscar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Busqueda(string cliente)
        {
            Logger.Log("Paso por Action Busqueda");
            var clientes = gestor.Buscar(cliente);
            return View(clientes.ConvertirAViewModels());
        }
        public ActionResult Listar()
        {
            var clientes = gestor.Listar(); 
            return View(clientes.ConvertirAViewModels());
            // la vista recibe un ViewModels ! 
            // puede recibir un Models si no hace falta laburar con varios tipos de datos
        }
    }
}