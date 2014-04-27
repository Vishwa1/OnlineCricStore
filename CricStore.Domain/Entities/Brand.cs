using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricStore.Domain.Entities
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        
        //Association One product has many brands
        public virtual ICollection<Brand> Brands { get; set; }
    }
}
