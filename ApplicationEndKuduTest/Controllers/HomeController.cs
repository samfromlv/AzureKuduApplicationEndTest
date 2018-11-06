using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationEndKuduTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Content("connectionStringValue=" + ConfigurationManager.ConnectionStrings["ApplicationEndKuduTest.Properties.Settings.MyConnectionString"] + "\r\nsettingValue=" + ConfigurationManager.AppSettings["MySetting"]);
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