using System.Web.Mvc;

namespace PracticaWebRazor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        /*public ActionResult Index()
        {
            var gestorVentas = new GestorVentas();
            var venta = new Venta();
            venta.Clientes = gestorVentas.listaClientes();
            venta.Productos = gestorVentas.listaProductos();    
            return View("Ventas",venta);
        }
        */

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AdminProductos()
        {
            return View();
        }

        public ActionResult AdminClientes()
        {
            return View();
        }

        public ActionResult GuardarProducto()
        {
            return View("GuardarProductos");
        }

    }
}