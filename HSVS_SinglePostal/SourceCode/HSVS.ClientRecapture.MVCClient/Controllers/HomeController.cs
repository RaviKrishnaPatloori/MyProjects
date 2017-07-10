using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using Vetstreet.VetPortal.Data;

namespace HSVS.SinglePostal.WebApp.Controllers
{
    public class HomeController : Controller
    {
        //private SubscriptionDao ssd;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ssd = new SubscriptionDao();
            //var test = ssd.GetElancoContactEmail(11159);
            //ViewBag.Message = test;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}