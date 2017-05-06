using System;
using System.Collections.Generic;
using System.Web;
using PracticaWebRazor.Models.AccesoDatos;


namespace PracticaWebRazor.Models
{
    public class GestorClientes
    {
        RepositorioClientes repo = new RepositorioClientes();

        public void Guardar(Models.Cliente cliente)
        {
            repo.Guardar(cliente);
        }

        public void Borrar (Models.Cliente cliente)
        {
            repo.Eliminar(cliente.Apellido, cliente.Nombre);
        }

        public void Modificar (Models.Cliente cliente, int edadN, string apellidoN, string nombreN)
        {
            repo.Modificar(cliente.Nombre, cliente.Apellido, edadN, apellidoN, nombreN);
        }

        public List<Cliente> Listar()
        {
            return repo.Listar();
        }
    }
}