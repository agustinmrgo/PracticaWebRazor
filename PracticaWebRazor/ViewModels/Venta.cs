using System.Collections.Generic;

using PracticaWebRazor.Models;

namespace PracticaWebRazor.ViewModels
{
    public class Venta
    {
        public List<ViewProducto> Productos { get; set; }
        public List<ViewCliente> Clientes { get; set; }

    }
}
