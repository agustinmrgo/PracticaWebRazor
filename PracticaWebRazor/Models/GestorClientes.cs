using System;
using System.Collections.Generic;
using System.Web;
using PracticaWebRazor.Models.AccesoDatos;


namespace PracticaWebRazor.Models
{
    public class GestorClientes
    {
        RepositorioClientes repo = new RepositorioClientes();

        public void Guardar(Cliente cliente)
        {
            repo.Guardar(cliente);
        }

        public void Eliminar (Cliente cliente)
        {
            repo.Eliminar(cliente.Apellido, cliente.Nombre);
        }

        public void Eliminar(int id)
        {
            repo.Eliminar(id);
        }

        public void Modificar (Cliente cliente, string apellidoN, string nombreN, int edadN)
        {
            repo.Modificar(cliente.Apellido, cliente.Nombre, apellidoN, nombreN, edadN);
        }

        public List<Cliente> Listar()
        {
            return repo.Listar();
        }

        public List<Cliente> Buscar(string cliente)
        {
            return repo.Buscar(cliente);
        }

        public Cliente BuscarPorId(int id)
        {
            return repo.BuscarPorId(id);
        }

        internal void Modif(Cliente cliente)
        {
            repo.Modif(cliente); 
        }
    }
}