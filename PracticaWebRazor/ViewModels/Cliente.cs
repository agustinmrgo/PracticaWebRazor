using PracticaWebRazor.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticaWebRazor.ViewModels
{
    public class Cliente
    {
        [Required(ErrorMessage = "Ingrese apellido !")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Ingrese nombre !")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese edad !")]
        [DisplayName("Edad:")]
        //[Range(15,50,ErrorMessage = "La edad debe estar entre 15 y 50 años")]
        [ValidarEdad]
        public int Edad { get; set; }

        /*[Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }*/
    }
} 