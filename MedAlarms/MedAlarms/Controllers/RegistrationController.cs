using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedAlarms.Controllers
{
    public class RegistrationController : Controller
    {
        //
        // GET: /SignIn/
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

    }
}
