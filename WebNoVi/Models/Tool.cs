using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebNoVi.Models
{
    public class Tool
    {
        [Key]
        public int ToolId { get; set; }

        [Display(Name = "Titulo:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(80, ErrorMessage = "El campo {0} debe tener entre {2} y {1} letras.", MinimumLength = 6)]
        public string Title { get; set; }

        [Display(Name = "Descripcion:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Description { get; set; }

        [Display(Name = "Direccion:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Link { get; set; }
    }
}