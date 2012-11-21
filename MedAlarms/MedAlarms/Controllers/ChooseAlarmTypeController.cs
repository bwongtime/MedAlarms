//This controller is what people are directed to when they want to annotate. 
//In the view of this controller people get to choose what type of alarm they want to annotate
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedAlarms.Controllers
{
    public class ChooseAlarmTypeController : Controller
    {
        //
        // GET: /ChooseAnotationType/

        public ActionResult Index()
        {
            return View();
        }

    }
}
