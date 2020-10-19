using System;
using System.ComponentModel.DataAnnotations;

namespace FormMvc.Models
{
    [Table("t_bono")]
    public class Practica
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnAttribute("id")]
        [Display(Name="Id")]
        public int Id { get; set; }

        
        [Required(ErrorMessage = "Por favor ingrese Nombre")]
        [Display(Name="Nombre")]
        [ColumnAttribute("nombre")]
        public String Nombre { get; set; }


        [Required(ErrorMessage = "Por favor ingrese Apellido")]
        [Display(Name="Apellido")]
        [ColumnAttribute("apellido")]
        public String Apellido { get; set; }

    
        [Required(ErrorMessage = "Por favor ingrese su Distrito")]
        [Display(Name="Distrito")]
        [ColumnAttribute("distrito")]
        public String Distrito { get; set; }

        
        [Required(ErrorMessage = "Por favor ingrese su Edad")]
        [Display(Name="Edad")]
        [ColumnAttribute("edad")]
        public int  Edad { get; set; }


        [Required(ErrorMessage = "Por favor ingrese el Banco")]
        [Display(Name="Banco")]
        [ColumnAttribute("banco")]
        public String  Banco { get; set; }

        
        [Required(ErrorMessage = "Por favor ingrese su Genero")]
        [Display(Name="Genero")]
        [ColumnAttribute("genero")]
        public String  Genero { get; set; }

        [NotMapped]
        public String Response { get; set; }

    }
}