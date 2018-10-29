using System;
using System.ComponentModel.DataAnnotations;

namespace WebNoVi.Models
{
    public class New
    {
        [Key]
        public int NewId { get; set; }

        [Display(Name = "Titulo:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Title { get; set; }

        [Display(Name = "Resumen:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Resume { get; set; }

        [Display(Name = "Hora:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime Hour { get; set; }

        [Display(Name = "Noticia:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Body { get; set; }

        [Display(Name = "Fecha:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Display(Name = "Imagen:")]
        public byte[] Image { get; set; }
    }
}