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

        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }

        public virtual ICollection<Comment> Comment { get; set; }
    }
}