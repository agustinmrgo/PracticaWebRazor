using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaWebRazor.ViewModels
{
    public class ViewProducto
    {

        [HiddenInput(DisplayValue = false)]
        public int? IdProducto { get; set; }

        [Required]
        [DisplayName("Nombre:")]
        public string Nombre { get; set; }

        [Required]
        [DisplayName("Marca:")]
        public string Marca { get; set; }

        [Required]
        [DisplayName("Precio:")]
        [DataType(DataType.Currency)]
        public decimal Precio { get; set; }
    }
}