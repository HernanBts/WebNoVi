using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebNoVi.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Display(Name = "Titulo:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Title { get; set; }

        [Display(Name = "Hora:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime Hour { get; set; }

        [Display(Name = "Fecha:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Display(Name = "Descripcion:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Description { get; set; }

        [Display(Name = "Imagen:")]
        public byte[] Image { get; set; }
    }
}