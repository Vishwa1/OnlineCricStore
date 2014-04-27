using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CricStore.Domain.Abstract;
using CricStore.Domain.Entities;

namespace CricStore.Domain.Concrete
{
    public class EFCategoryRepository : ICategoryRepository
    {
        private CricDbContext context = new CricDbContext();
        public IQueryable<Category> Categories
        {
            get { return context.Categories; }
        }
    }
}
