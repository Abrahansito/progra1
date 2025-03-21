using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PROYECTO_WEB.Models
{
    public class Customer
    {
        public string? Username { get; set; }
        [Required(ErrorMessage = "El DNI es obligatorio")]
        public string? DNI { get; set; } 
        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "La dirección es obligatorio")]
        public string? Address { get; set; }
    }
    
}