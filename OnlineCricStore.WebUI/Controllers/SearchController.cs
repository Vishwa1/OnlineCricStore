using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CricStore.Domain.Abstract;
using CricStore.Domain.Entities;

namespace OnlineCricStore.WebUI.Controllers
{
    public class SearchController : Controller
    {
        //
        // GET: /Search/
        
        private IProductRepository objContext;
        
        public SearchController(IProductRepository productRepository)
        {
            this.objContext = productRepository;
        }
       
        
        public ActionResult SearchByCategory(string searchString)
        {
            var AllBrands = from m in objContext.Products
                            select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                AllBrands = AllBrands.Where(s => s.CategoryName.Contains(searchString));
            }

            return View(AllBrands); 
        }

        public ActionResult SearchByBrand(string searchString)
        {
            var AllBrands = from m in objContext.Products
                            select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                AllBrands = AllBrands.Where(s => s.BrandName.Contains(searchString));
            }

            return View(AllBrands);
        }
    }
}
