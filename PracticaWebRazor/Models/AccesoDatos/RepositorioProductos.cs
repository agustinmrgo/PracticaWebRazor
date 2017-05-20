using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PracticaWebRazor.ViewModels;

namespace PracticaWebRazor.Models.AccesoDatos
{
    public class RepositorioProductos
    {
        EjemploABMDB ejemploABM = new EjemploABMDB();

        public List<Producto> Buscar(string prod)
        {
            var resultado = ejemploABM.Producto.Where(
                p => p.Nombre.Contains(prod) || p.Marca.Contains(prod)).ToList();
            return resultado;
        }

        public void Guardar(Producto producto)
        {
            ejemploABM.Producto.Add(producto);
            ejemploABM.SaveChanges();
        }

        public List<Producto> Listar()
        {
            return ejemploABM.Producto.ToList();
        }

    }
}