using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CricStore.Domain.Entities;

namespace CricStore.Domain.Abstract
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }

        //Product List(int BrandId, int CategoryId);
        Product Details(int productId);
    }
}
