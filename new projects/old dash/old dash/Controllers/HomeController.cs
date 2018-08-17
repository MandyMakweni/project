using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace old_dash.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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


        public ActionResult emotions()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult keywords()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult sentiment()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}