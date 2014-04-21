using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineCricStore.WebUI.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        [Authorize (Roles = "admin")]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Adidas()
        {
            ViewBag.Message = "Your Adidas1 page.";

            return View();
        }

        public ActionResult MRF()
        {
            ViewBag.Message = "Your MRF1 page.";

            return View();
        }

        public ActionResult Nike()
        {
            ViewBag.Message = "Your Nike1 page.";

            return View();
        }

        public ActionResult KookaBurra()
        {
            ViewBag.Message = "Your KookaBurra page.";

            return View();
        }

        public ActionResult GMBalls()
        {
            ViewBag.Message = "Your GMBalls page.";

            return View();
        }

        public ActionResult SGBalls()
        {
            ViewBag.Message = "Your SGBalls page.";

            return View();
        }

        public ActionResult BatGrips()
        {
            ViewBag.Message = "Your BatGrips page.";

            return View();
        }

        public ActionResult BatCover()
        {
            ViewBag.Message = "Your BatCover page.";

            return View();
        }

        public ActionResult Pads()
        {
            ViewBag.Message = "Your Pads page.";

            return View();
        }

        public ActionResult Helmets()
        {
            ViewBag.Message = "Your Helmets page.";

            return View();
        }

        public ActionResult Stumps()
        {
            ViewBag.Message = "Your Stumps page.";

            return View();
        }

        public ActionResult Gloves()
        {
            ViewBag.Message = "Your Gloves page.";

            return View();
        }

        public ActionResult Shoes()
        {
            ViewBag.Message = "Your Shoes page.";

            return View();
        }

        public ActionResult Bails()
        {
            ViewBag.Message = "Your Bails page.";

            return View();
        }

        public ActionResult AdidasBrand()
        {
            ViewBag.Message = "Your AdidasBrand page.";

            return View();
        }

        public ActionResult NikeBrand()
        {
            ViewBag.Message = "Your NikeBrand page.";

            return View();
        }

        public ActionResult MRFBrand()
        {
            ViewBag.Message = "Your MRFBrand page.";

            return View();
        }

        public ActionResult CABrand()
        {
            ViewBag.Message = "Your CABrand page.";

            return View();
        }

        public ActionResult GMBrand()
        {
            ViewBag.Message = "Your GMBrand page.";

            return View();
        }

        public ActionResult SGBrand()
        {
            ViewBag.Message = "Your SGBrand page.";

            return View();
        }

        public ActionResult Career()
        {
            ViewBag.Message = "Your Career page.";

            return View();
        }

      }
}
