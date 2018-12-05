using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebNoVi.Models;

namespace WebNoVi.ModelView
{
    public class IndexSPAView
    {
        public List<Service> Services { get; set; }

        public List<Event> Events { get; set; }

        public List<Story> Stories { get; set; }

        public List<New> News { get; set; }

        public List<Tool> Tools { get; set; }
    }
}