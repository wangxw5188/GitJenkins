using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TFSLib;

namespace TFSMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Demo demo = new Demo();
            demo.Sub();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}