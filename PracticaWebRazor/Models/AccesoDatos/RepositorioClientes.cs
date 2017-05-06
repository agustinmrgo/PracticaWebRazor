using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaWebRazor.Models.AccesoDatos
{
    public class RepositorioClientes
    {
        EjemploABMDB ejemploABM = new EjemploABMDB();

        public void Guardar(Cliente cliente)
        {
            ejemploABM.Cliente.Add(cliente);
            ejemploABM.SaveChanges();
        }

        public List<Cliente> Listar()
        {
            return ejemploABM.Cliente.ToList();
        }

        public void Eliminar (int id)
        {
            //ejemploABM.Cliente.Remove(ejemploABM.Cliente.Where < Id = id >);  ???
        }

        public void Eliminar (string apellido, string nombre)
        {
            ejemploABM.Cliente.Where(clte => clte.Apellido == apellido && clte.Nombre == nombre).First();
            //First es equivalente a SELECT Top 1 en SQL, es un metodo 
            //extensor (metodo static en una clase static con parametro this de la 
            //clase a la que quiere extender, googlear!)
            ejemploABM.SaveChanges();
        }

        public void Modificar (string apellidoN, string nombreN, int edadN, string apellidoV, string nombreV)
        {
            ejemploABM.ModificarCliente(apellidoN, nombreN, edadN, apellidoV, nombreV);
            ejemploABM.SaveChanges();
        }
    }
}