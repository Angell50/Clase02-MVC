using System.ComponentModel.DataAnnotations;

namespace Clase02_MVC.Models
{
    public class Carrera
    {
        [Key]
        public required int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
    }
}
