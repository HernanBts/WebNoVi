using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebNoVi.Models
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }

        [Display(Name = "Titulo:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Title { get; set; }

        [Display(Name = "Descripcion:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Resume { get; set; }

        [Display(Name = "Imagen:")]
        public byte[] Image { get; set; }
    }
}