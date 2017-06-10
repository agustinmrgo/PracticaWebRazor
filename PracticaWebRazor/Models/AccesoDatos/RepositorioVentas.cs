using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaWebRazor.Models.AccesoDatos
{
    public class RepositorioVentas
    {
        EjemploABMDB ejemploABM = new EjemploABMDB();

        public void Guardar (Ventas venta)
        {
            ejemploABM.Ventas.Add(venta);
            ejemploABM.SaveChanges();
        }

        public List<Ventas> Listar()
        {
            return ejemploABM.Ventas.ToList();
        }

    }
}