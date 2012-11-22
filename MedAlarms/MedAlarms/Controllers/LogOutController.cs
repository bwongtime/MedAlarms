//Here is the controller that allows you to logout

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MedAlarms.Controllers
{
    public class LogOutController : Controller
    {
        //
        // GET: /LogOut/

        public ActionResult Index()
        {
            FormsAuthentication.SignOut();
            return View();
        }

    }
}
