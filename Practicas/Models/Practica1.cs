using System;
using System.ComponentModel.DataAnnotations;

namespace Practicas.Models
{
    [Table("t_bono")]
    public class Practica1
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [Display(Name="Id")]
        public int Id { get; set; }

        
        [Required(ErrorMessage = "Por favor ingrese Nombre")]
        [Display(Name="Nombre")]
        [Column("nombre")]
        public String Nombre { get; set; }


        [Required(ErrorMessage = "Por favor ingrese Apellido")]
        [Display(Name="Apellido")]
        [Column("apellido")]
        public String Apellido { get; set; }

    
        [Required(ErrorMessage = "Por favor ingrese su Distrito")]
        [Display(Name="Distrito")]
        [Column("distrito")]
        public String Distrito { get; set; }

        
        [Required(ErrorMessage = "Por favor ingrese su Edad")]
        [Display(Name="Edad")]
        [Column("edad")]
        public int  Edad { get; set; }


        [Required(ErrorMessage = "Por favor ingrese el Banco")]
        [Display(Name="Banco")]
        [Column("banco")]
        public String  Banco { get; set; }

        
        [Required(ErrorMessage = "Por favor ingrese su Genero")]
        [Display(Name="Genero")]
        [Column("genero")]
        public String  Genero { get; set; }

        [NotMapped]
        public String Response { get; set; }

    }
}