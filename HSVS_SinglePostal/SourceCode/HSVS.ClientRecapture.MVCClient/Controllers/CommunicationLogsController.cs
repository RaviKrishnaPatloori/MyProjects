using HSVS.SinglePostal.WebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HSVS.SinglePostal.WebApp.Controllers
{
    [RoutePrefix("CommunicationLogs")]
    public class CommunicationLogsController : Controller
    {      
        public CommunicationLogsController()
        {

        }
        // GET: CommunicationLogs      
        public ActionResult Index()
        {
            CommunicationLogsViewModel commLogsViewModel = new CommunicationLogsViewModel();
            return View(commLogsViewModel);

        }
        // GET: CommunicationLogs
        [Route("{hospitalID}")]
        public ActionResult Index(string hospitalID)
        {
            CommunicationLogsViewModel commLogsViewModel = new CommunicationLogsViewModel();
            return View(commLogsViewModel);
          
        }
    }
}