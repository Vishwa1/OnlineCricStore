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

        Product Details(int productId);
    }
}
