using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebNoVi.Models
{
    public class Query
    {
        [Key]
        public int QueryId { get; set; }

        [Display(Name = "Fecha:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Display(Name = "Nombre:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(80, ErrorMessage = "El campo {0} debe tener entre {2} y {1} letras.", MinimumLength = 6)]
        public string Name { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Email { get; set; }

        [Display(Name = "Tema:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Subject { get; set; }

        [Display(Name = "Mensaje:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Message { get; set; }
    }
}