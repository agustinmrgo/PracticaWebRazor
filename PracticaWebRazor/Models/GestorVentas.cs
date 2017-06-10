using PracticaWebRazor.Models.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaWebRazor.Models
{
	public class GestorVentas
	{
        RepositorioVentas repo = new RepositorioVentas();

        public void Guardar(Ventas venta)
        {
            repo.Guardar(venta);
        }

        public List<Ventas> Listar()
        {
            return repo.Listar();
        }


        //public List<Ventas> Buscar(string venta)
        //{
        //    return repo.Buscar(venta);
        //}

    }
}