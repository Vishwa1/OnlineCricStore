using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CricStore.Domain.Abstract;
using CricStore.Domain.Entities;
using OnlineCricStore.WebUI.Models;

namespace OnlineCricStore.WebUI.Controllers
{
    public class BasketController : Controller
    {
        // GET: /Basket/

        private IProductRepository repository;

        public BasketController(IProductRepository repo)
        {
            this.repository = repo;
        }

        public RedirectToRouteResult AddToBasket(int productId, string returnUrl)
        {
            Product product = repository.Products.FirstOrDefault(x => x.ProductId == productId);
            if (product != null)
            {
                GetBasket().AddItem(product, 1);
            }
            return RedirectToAction("Index", new {returnUrl });
        }

        public RedirectToRouteResult RemoveFromBasket(int productId, string returnUrl)
        {
            Product product = repository.Products.FirstOrDefault(x => x.ProductId == productId);
            if (product != null)
            {
                GetBasket().RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        private Basket GetBasket()
        {
            Basket basket = (Basket)Session["Basket"];
            if (basket == null)
            {
                basket = new Basket();
                Session["Basket"] = basket;
            }
            return basket;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new BasketIndexView
            { 
                Basket = GetBasket(),
                ReturnUrl = returnUrl
            });
            
        }

        //Get Shopping Basket Summary 
        public PartialViewResult ShoppingSummary(Basket basket)
        { 
            return PartialView(basket);
        }

        public ViewResult Checkout()
        {
            return View(new ShippingDetails());
        }

        public ViewResult CompletedOrder()
        {
            return View();
        }


    }
}
