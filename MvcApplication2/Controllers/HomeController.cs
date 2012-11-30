using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Medical Alarm Database";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Walkthur()
        {
            return View();
        }
        public ActionResult Annotate()
        {
            return View();
        }
    }
}
