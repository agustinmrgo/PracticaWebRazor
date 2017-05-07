using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace PracticaWebRazor.ViewModels
{
    public class Cliente
    {
        [HiddenInput(DisplayValue = false)] // oculta el atributo en la vista
        public int? Id { get; set; } = 0; // valor cero por defecto (evita que sea required)
        // probar con distinto nombre si tira error de Schema
        // signo de preg permite que tome valores nulos y jquery no haga la validacion del campo
        [Required(ErrorMessage = "Ingrese apellido !")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Ingrese nombre !")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese edad !")]
        [DisplayName("Edad:")]
        //[Range(15,50,ErrorMessage = "La edad debe estar entre 15 y 50 años")]
        //[ValidarEdad]
        //[NotMapped] //evitar mapeo de un atributo con la bd
        //[ScaffoldColumn(false)] //no renderiza el atributo en la vista
        public int Edad { get; set; }

        /*[Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }*/
    }
} 