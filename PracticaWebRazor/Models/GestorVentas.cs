
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PracticaWebRazor.Models;

namespace PracticaWebRazor.Models
{
    public class GestorVentas
    {
        public List<Producto> listaProductos()
        {
            var arroz = new Producto { Nombre = "arroz" };
            var fideos = new Producto { Nombre = "fideos" };
            var harina = new Producto { Nombre = "harina" };
            var listaProductos = new List<Producto>();
            listaProductos.Add(arroz);
            listaProductos.Add(fideos);
            listaProductos.Add(harina);
            return listaProductos;
        }

        public List<Cliente> listaClientes()
        {
            var cliente1 = new Cliente { Apellido = "Ledesma", Nombre = "Facundo" };
            var cliente2 = new Cliente { Apellido = "Ortiz", Nombre = "Juan Pablo" };
            var cliente3 = new Cliente { Apellido = "Dip", Nombre = "Raul" };

            var listaClientes = new List<Cliente>();
            listaClientes.Add(cliente1);
            listaClientes.Add(cliente2);
            listaClientes.Add(cliente3);
            return listaClientes;
        }
    }
}