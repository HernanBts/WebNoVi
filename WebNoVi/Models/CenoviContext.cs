using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebNoVi.Models
{
    public class CenoviContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CenoviContext() : base("name=DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public System.Data.Entity.DbSet<WebNoVi.Models.New> News { get; set; }

        public System.Data.Entity.DbSet<WebNoVi.Models.Story> Stories { get; set; }

        public System.Data.Entity.DbSet<WebNoVi.Models.Comment> Comments { get; set; }

        public System.Data.Entity.DbSet<WebNoVi.Models.Tool> Tools { get; set; }
    }
}
