using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace PROYECTO_WEB.Models
{
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