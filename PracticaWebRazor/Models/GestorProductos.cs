using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PracticaWebRazor.ViewModels;
using PracticaWebRazor.Models.AccesoDatos;

namespace PracticaWebRazor.Models
{
    public class GestorProductos
    {

        RepositorioProductos repo = new RepositorioProductos();

        public void Guardar(Producto producto)
        {
            repo.Guardar(producto);
        }

        public List<Producto> Listar()
        {
            return repo.Listar();
        }

        public List<Producto> Buscar(string prod)
        {
            return repo.Buscar(prod);
        }
    }
}