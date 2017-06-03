using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaWebRazor.Extensions
{
    public static class Extensions
    {
        public static Models.Cliente ConvertirAModelo (this ViewModels.ViewCliente cliente)
        {
            Models.Cliente clte = new Models.Cliente(); //convierto de ViewModels a Models
            //clte.IdCliente = (int) cliente.IdCliente.GetValueOrDefault();
            clte.Apellido = cliente.Apellido; clte.Nombre = cliente.Nombre; clte.Edad = cliente.Edad;
            return clte;
        }

        public static List<ViewModels.ViewCliente> ConvertirAViewModels (this List<Models.Cliente> listaClientes)
        {
            //var listaClientes = gestor.Listar();
            var listaViewClientes = new List<ViewModels.ViewCliente>();

            foreach (var modelsCliente in listaClientes)
            {
                var viewCliente = new ViewModels.ViewCliente
                {
                    IdCliente = modelsCliente.IdCliente, Apellido = modelsCliente.Apellido, Nombre = modelsCliente.Nombre
                };
                listaViewClientes.Add(viewCliente);
            }
            return listaViewClientes;
        }

        public static ViewModels.ViewCliente ConvertirAViewModel (this Models.Cliente cliente)
        {
            var clienteViewMod = new ViewModels.ViewCliente
            {
                IdCliente = cliente.IdCliente,
                Apellido = cliente.Apellido,
                Nombre = cliente.Nombre,
                Edad = (int)cliente.Edad
            };

            return clienteViewMod;
        }

        /*
         Para ser metodo extensor debe ser estatico y que tenga un this 
         a la clase a extender como parametro
         Googlear: automapper ??
        */

        public static Models.Producto ConvertirAModelo (this ViewModels.ViewProducto producto)
        {
            Models.Producto prod = new Models.Producto();
            prod.IdProducto = (int) producto.IdProducto.GetValueOrDefault(); // ????
            prod.Marca = producto.Marca; prod.Nombre = producto.Nombre; prod.Precio = producto.Precio;
            return prod;
        }

        public static List<ViewModels.ViewProducto> ConvertirAViewModels (this List<Models.Producto> listaProd)
        {
            var listaViewProd = new List<ViewModels.ViewProducto>();
            foreach (var prod in listaProd)
            {
                var viewProd = new ViewModels.ViewProducto
                {
                    IdProducto = prod.IdProducto, Nombre = prod.Nombre, Marca = prod.Marca
                };
                listaViewProd.Add(viewProd);
            }
            return listaViewProd;
        }

    }
}