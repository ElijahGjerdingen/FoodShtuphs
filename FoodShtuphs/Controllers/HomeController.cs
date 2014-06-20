using FoodShtuphs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodShtuphs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.message = "welcome to ASP.NET MVC!";

            var model = new RestaurantReview
            {
                Name = "Annie's Parlour",
                Rating = 9
            };
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Test";
            ViewBag.Location = "minnesota, USA";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public int Rating { get; set; }
    }
}