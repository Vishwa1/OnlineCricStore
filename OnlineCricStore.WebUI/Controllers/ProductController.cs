﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CricStore.Domain.Abstract;
using CricStore.Domain.Entities;
using System.IO;
using System.Net;

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

        //Displays detail view of Products
        public ActionResult Details(int Id)
        {
            Product product = objContext.Details(Id);
            return View(product);
        }
    }
}
