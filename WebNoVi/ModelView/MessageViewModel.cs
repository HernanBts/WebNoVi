using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebNoVi.Models;

namespace WebNoVi.ModelView
{
    public class MessageViewModel
    {
        public List<Donation> Donations { get; set; }

        public List<Voluntary> Voluntaries { get; set; }

        public List<Query> Queries { get; set; }
    }
}