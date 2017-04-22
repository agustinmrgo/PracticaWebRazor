using System.Collections.Generic;

using PracticaWebRazor.Models;

namespace PracticaWebRazor.ViewModels
{
    public class Venta
    {
        public List<Producto> Productos { get; set; }
        public List<Cliente> Clientes { get; set; }

    }
}
