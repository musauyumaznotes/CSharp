using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Context:DbContext
    {
        public DbSet<Product> Products{ get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
