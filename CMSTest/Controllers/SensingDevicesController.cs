using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMSTest.Controllers
{
    public class SensingDevicesController : Controller
    {
        //
        // GET: /SensingDevices/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SensitiveEdges()
        {
            return View();
        }
        public ActionResult SafetyMats()
        {
            return View();
        }
        public ActionResult LightCurtains()
        {
            return View();
        }


	}
}