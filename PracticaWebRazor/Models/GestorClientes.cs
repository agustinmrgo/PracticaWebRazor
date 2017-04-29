using System;
using System.Collections.Generic;
using System.Linq;
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

        }

        public List<Cliente> Listar()
        {
            return repo.Listar();
        }
    }
}