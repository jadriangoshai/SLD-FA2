using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrialRun.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {            
            return View();
        }
        //Favourites webpage added
        public ActionResult Favourites()
        {
            return View();
        }

        //Location added from Layout
        public ActionResult Location()
        {
            ViewBag.Message = "Location of where you can find us.";

            return View();
        }
        //News added
        public ActionResult News()
        {
            return Redirect("https://readersden.co.za/category/news-general/");           
        }
    }
}