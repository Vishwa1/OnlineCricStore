using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CricStore.Domain.Entities;

namespace CricStore.Domain.Concrete
{
    public class CricDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }

        public DbSet<Product> Products { get; set; }

        //public IQueryable<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
