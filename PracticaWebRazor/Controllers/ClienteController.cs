using System.Web.Mvc;

namespace PracticaWebRazor.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult AdminClientes()
        {
            return View();
        }

        public ActionResult Alta()
        {
            //muestra la vista para cargar datos para dar de alta un cliente
            //despues dispara el metodo Guardar()
            return View();
        }
        public ActionResult Guardar()
        {
            //este metodo le pide al gestor que guarde el cliente
            return View();
        }
    }
}