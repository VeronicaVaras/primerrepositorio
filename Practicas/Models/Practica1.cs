using System;
using System.ComponentModel.DataAnnotations;

namespace Practicas.Models
{
    public class Practica1
    {
        [Required(ErrorMessage = "Por favor ingrese Nombre")]
        [Display(Name="Nombre")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Apellido")]
        [Display(Name="Apellido")]
        public String Apellido { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su Distrito")]
        [Display(Name="Distrito")]
        public String Distrito { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su Edad")]
        [Display(Name="Edad")]
        public int  Edad { get; set; }

        [Required(ErrorMessage = "Por favor ingrese el Banco")]
        [Display(Name="Banco")]
        public String  Banco { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su Genero")]
        [Display(Name="Genero")]
        public String  Genero { get; set; }

        public String Response { get; set; }

    }
}