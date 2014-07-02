using FoodShtuphs.Infastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodShtuphs.Controllers
{
    //[Authorize]
    [Log]
    public class CuisineController : Controller
    {

        [HttpGet]
        //[Authorize]
        public ActionResult Search(string name = "*")
        {
            throw new Exception("oops!");
            //if(name == "*")
            //{
                //return Json(new { CuisineName = name }, JsonRequestBehavior.AllowGet);
                //return File(Server.MapPath("~/Content/Site.css"), "text/css");
                //return RedirectToRoute("Cuisine", new { name = "german" });
                //return RedirectToAction("Search", "Cuisine", new { name = "French" });
            //}
            
            //name = Server.HtmlEncode(name);
            //return Content(name);

        }
	}
}