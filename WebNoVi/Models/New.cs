using System;
using System.ComponentModel.DataAnnotations;

namespace WebNoVi.Models
{
    public class New
    {
        [Key]
        public int NewId { get; set; }

        public string Title { get; set; }

        public string Resume { get; set; }

        public string Body { get; set; }

        public DateTime Date { get; set; }

        public byte[] Image { get; set; }
    }
}