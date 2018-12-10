using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebNoVi.Models
{
    public class Story
    {
        [Key]
        public int StoryId { get; set; }

        [Display(Name = "Titulo:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(80, ErrorMessage = "El campo {0} debe tener entre {2} y {1} letras.", MinimumLength = 6)]
        public string Title { get; set; }

        [Display(Name = "Fecha:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Display(Name = "Hora:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime Hour { get; set; }

        [Display(Name = "Resumen:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Description { get; set; }

        [Display(Name = "Cuerpo:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Body { get; set; }

        [Display(Name = "Imagen:")]
        public byte[] Image { get; set; }

        public virtual ICollection<Comment> Comment { get; set; }
    }
}