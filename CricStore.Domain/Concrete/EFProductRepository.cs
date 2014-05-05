using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CricStore.Domain.Abstract;
using CricStore.Domain.Entities;

namespace CricStore.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private CricDbContext context = new CricDbContext();

        public IQueryable<Product> Products
        {
            get { return context.Products; }
        }

        //public Product List(int BrandId, int CategoryId)
        //{
        //    Product p = context.Products.Find(BrandId, CategoryId);
        //    return p;
        //}
        public Product Details(int productId)
        {
            Product p = context.Products.Find(productId);
            return p;
        }

    }
}
