using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaWebRazor.Extensions
{
    public static class Extensions
    {
        public static Models.Cliente ConvertirAModelo(this ViewModels.ViewCliente cliente)
        {
            Models.Cliente clte = new Models.Cliente(); //convierto de ViewModels a Models
            clte.Apellido = cliente.Apellido;
            clte.Nombre = cliente.Nombre;
            clte.Edad = cliente.Edad;
            return clte;
        }

        public static List<ViewModels.ViewCliente> ConvertirAViewModels(this List<Models.Cliente> listaClientes)
        {
            //var listaClientes = gestor.Listar();
            var listaViewClientes = new List<ViewModels.ViewCliente>();

            foreach (var modelsCliente in listaClientes)
            {
                var viewCliente = new ViewModels.ViewCliente
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