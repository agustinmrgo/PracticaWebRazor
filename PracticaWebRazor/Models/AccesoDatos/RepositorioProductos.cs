using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticaWebRazor.Models.AccesoDatos
{
    public class RepositorioProductos
    {
        EjemploABMDB ejemploABM = new EjemploABMDB();

        public void Guardar(Producto producto)
        {
            ejemploABM.Producto.Add(producto);
            ejemploABM.SaveChanges();
        }

        public List<Producto> Buscar(string prod)
        {
            var resultado = ejemploABM.Producto.Where(
                p => p.Nombre.Contains(prod) || p.Marca.Contains(prod)).ToList();
            return resultado;
        }

        public void Eliminar(string nombre, string marca)
        {
            var prod = ejemploABM.Producto.Where(
                p => p.Nombre==nombre && p.Marca==marca).First();
            ejemploABM.Producto.Remove(prod);
            ejemploABM.SaveChanges();
        }

        public void Modificar(Producto producto)
        {
            var prodAModif = ejemploABM.Producto.First(
                prod => prod.IdProducto == producto.IdProducto);
            prodAModif.Nombre = producto.Nombre;
            prodAModif.Marca = producto.Marca;
            prodAModif.Precio = producto.Precio;
            ejemploABM.SaveChanges();
        }

        public List<Producto> Listar()
        {
            return ejemploABM.Producto.ToList();
        }

    }
}