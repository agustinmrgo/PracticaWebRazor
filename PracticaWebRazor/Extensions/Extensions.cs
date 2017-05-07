using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaWebRazor.Extensions
{
    public static class Extensions
    {
        public static Models.Cliente ConvertirAModelo(this ViewModels.Cliente cliente)
        {
            Models.Cliente clte = new Models.Cliente(); //convierto de ViewModels a Models
            clte.Apellido = cliente.Apellido;
            clte.Nombre = cliente.Nombre;
            clte.Edad = cliente.Edad;
            return clte;
        }

        public static List<ViewModels.Cliente> ConvertirAViewModels(this List<Models.Cliente> listaClientes)
        {
            //var listaClientes = gestor.Listar();
            var listaViewClientes = new List<ViewModels.Cliente>();

            foreach (var modelsCliente in listaClientes)
            {
                var viewCliente = new ViewModels.Cliente
                {
                    Id = modelsCliente.Id,
                    Apellido = modelsCliente.Apellido,
                    Nombre = modelsCliente.Nombre,
                };
                listaViewClientes.Add(viewCliente);
            }
            return listaViewClientes;
        }
    }
}