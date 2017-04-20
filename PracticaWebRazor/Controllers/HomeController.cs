using System.Web.Mvc;
using PracticaWebRazor.Models;
using PracticaWebRazor.ViewModel;

namespace PracticaWebRazor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var gestorVentas = new GestorVentas();
            var venta = new Venta();
            venta.Clientes = gestorVentas.listaClientes();
            venta.Productos = gestorVentas.listaProductos();    
            return View("Ventas",venta);
        }

        //public ActionResult
    }
}