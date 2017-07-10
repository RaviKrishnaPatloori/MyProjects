using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HSVS.SinglePostal.WebApp.Controllers
{
    [RoutePrefix("HelpAndSupport")]
    public class HelpAndSupportController : Controller
    {
        // GET: HelpAndSupport
        public ActionResult Index()
        {
            return View();
        }
    }
}