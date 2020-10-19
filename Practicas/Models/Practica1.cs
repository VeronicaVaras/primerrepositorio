using System;
using System.ComponentModel.DataAnnotations;

namespace Practicas.Models
{
    public class Practica1
    {
        [column ("id")]
        [Display(Name="Id")]
        public int Id { get; set; }

        [column ("nombre")]
        [Required(ErrorMessage = "Por favor ingrese Nombre")]
        [Display(Name="Nombre")]
        public String Nombre { get; set; }

        [column ("apellido")]
        [Required(ErrorMessage = "Por favor ingrese Apellido")]
        [Display(Name="Apellido")]
        public String Apellido { get; set; }

        [column ("distrito")]
        [Required(ErrorMessage = "Por favor ingrese su Distrito")]
        [Display(Name="Distrito")]
        public String Distrito { get; set; }

        [column ("edad")]
        [Required(ErrorMessage = "Por favor ingrese su Edad")]
        [Display(Name="Edad")]
        public int  Edad { get; set; }

        [column ("banco")]
        [Required(ErrorMessage = "Por favor ingrese el Banco")]
        [Display(Name="Banco")]
        public String  Banco { get; set; }

        [column ("genero")]
        [Required(ErrorMessage = "Por favor ingrese su Genero")]
        [Display(Name="Genero")]
        public String  Genero { get; set; }

        public String Response { get; set; }

    }
}