using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CricStore.Domain.Abstract;
using CricStore.Domain.Entities;

namespace CricStore.Domain.Concrete
{
    public class EFBrandRepository : IBrandRepository
    {
        private CricDbContext context = new CricDbContext();
        public IQueryable<Brand> Brands
        {
            get { return context.Brands; }
        }
    }
}
