using PracticaWebRazor.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaWebRazor.Models.AccesoDatos
{
    public class RepositorioClientes
    {
        EjemploABMDB ejemploABM = new EjemploABMDB();

        public RepositorioClientes()
        {
            ejemploABM.Database.Log = Logger.Log; // ??
            //cada vez que instancie un repositorio la clase Log de Database sera
            //la clase Log que yo defini ??
        }

        public void Guardar(Models.Cliente cliente)
        {
            ejemploABM.Cliente.Add(cliente);
            ejemploABM.SaveChanges();
        }

        public List<Cliente> Listar()
        {
            return ejemploABM.Cliente.ToList();
        }

        internal void Eliminar(int id)
        {
            var cliente = ejemploABM.Cliente.First(clte => clte.Id == id);
            ejemploABM.Cliente.Remove(cliente);
            ejemploABM.SaveChanges();
        }

        /*
        public void Eliminar(int id)
        {
            ejemploABM.Cliente.Remove(ejemploABM.Cliente.Where < Id = id >);
        }
        */

        public void Eliminar (string apellido, string nombre)
        {
            var cliente = ejemploABM.Cliente.Where(
                clte => clte.Apellido == apellido && clte.Nombre == nombre).First();
            //First es equivalente a SELECT Top 1 en SQL, es un metodo 
            //extensor (metodo static en una clase static con parametro this de la 
            //clase a la que quiere extender, googlear!)
            ejemploABM.Cliente.Remove(cliente);
            ejemploABM.SaveChanges();
        }

        public List<Cliente> Buscar(string cliente)
        {
            var resultado = ejemploABM.Cliente.Where(
                clte => clte.Apellido.Contains(cliente) || clte.Nombre.Contains(cliente)).ToList();
            //resultado.Where(clte => clte.Edad > 10);
            // voy agregando condiciones o consultas al mismo objeto IQueryable
            //resultado.ToList(); // la consulta se ejecuta recien en ToList() 
            return resultado;

        }

        public void Modificar (string apellidoV, string nombreV, string apellidoN, string nombreN, int edadN)
        {
            ejemploABM.ModificarCliente(apellidoV, nombreV, apellidoN, nombreN, edadN);
            ejemploABM.SaveChanges();
        }
    }
}