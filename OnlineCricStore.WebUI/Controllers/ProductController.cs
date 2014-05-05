using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CricStore.Domain.Abstract;
using CricStore.Domain.Entities;

namespace OnlineCricStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        // GET: /Products/

        private IProductRepository objContext;

        public ProductController(IProductRepository productRepository)
        {
            this.objContext = productRepository;
        }

        //Displays List of products
        public ViewResult List()
        {
            return View(objContext.Products);
        }

        //public ViewResult List(int BId, int CId)
        //{
        //    //return View(objContext.Products);
        //    Product product = objContext.List(BId, CId);
        //    return View(product);
        //}

        //Displays detail view of Products
        public ActionResult Details(int Id)
        {
            Product product = objContext.Details(Id);
            return View(product);
        }
    }
}
