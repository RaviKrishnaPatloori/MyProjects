using HSVS.SinglePostal.WebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HSVS.SinglePostal.WebApp.Controllers
{
    [RoutePrefix("PerformanceReports")]
    public class PerformanceReportsController : Controller
    {        
        public PerformanceReportsController()
        {

        }

        // GET: PerformanceReports      
        public ActionResult Index()
        {
            PerformanceReportsViewModel perfLogsViewModel = new PerformanceReportsViewModel();

            return View(perfLogsViewModel);
                       
        }

        // GET: PerformanceReports
        [Route("{hospitalID}")]
        public ActionResult Index(string hospitalID)
        {
            PerformanceReportsViewModel perfLogsViewModel = new PerformanceReportsViewModel();

            return View(perfLogsViewModel);

        }
    }
}