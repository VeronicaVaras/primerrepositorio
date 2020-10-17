using System;
using System.ComponentModel.DataAnnotations;

namespace FormMvc.Models
{
    public class Estudiante
    {
        [Required(ErrorMessage = "Por favor ingrese Nombre")]
        [Display(Name="Nombre")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Apellido")]
        [Display(Name="Apellido")]
        public String Apellido { get; set; }

        [Display(Name="Curso")]
        public String Curso { get; set; }

    }
}
