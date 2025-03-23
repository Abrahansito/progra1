using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace PROYECTO_WEB.Models
{
    [Table("t_contacto")]
    public class Contacto
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }
        [NotNull]
        public string? Email { get; set; } 
        [NotNull]  
        public string? Mensaje { get; set; }     
        
    }
}