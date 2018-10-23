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

        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public string Body { get; set; }
        public string Mail { get; set; }
        public int StoryId { get; set; }

        public virtual Story Story { get; set; }
    }
}