using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticaWebRazor.ViewModels
{
    public class Producto
    {
        [Required]
        [DisplayName("Nombre:")]
        public string NomP { get; set; }

        [Required]
        [DisplayName("Marca:")]
        public string MarcaP { get; set; }

        [Required]
        [DisplayName("Precio:")]
        [DataType(DataType.Currency)]
        public decimal PrecioP { get; set; }
    }
}