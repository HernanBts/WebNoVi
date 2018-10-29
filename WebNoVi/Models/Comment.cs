using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebNoVi.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Display(Name = "Nombre:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string UserName { get; set; }

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

        [Display(Name = "Comentario:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Body { get; set; }

        [Display(Name = "Correo:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        public int StoryId { get; set; }

        public virtual Story Story { get; set; }
    }
}