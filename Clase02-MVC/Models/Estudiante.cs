using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clase02_MVC.Models
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Nombre { get; set; }
        [Range(0,110)]
        public int edad { get; set; }
        [EmailAddress]
        public string Correo { get; set; }  
        public Carrera carrera { get; set; }
        [ForeignKey("Carrera")]
        public int IdCarrera { get; set; }
    }
}
