//after choosing what type of alarm to annotate (and choosing asystole), you will be sent here

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedAlarms.Controllers
{
    public class AsystoleGraphsController : Controller
    {
        //
        // GET: /Asystole Annotating/

        public ActionResult Index()
        {
            return View();
        }

    }
}
