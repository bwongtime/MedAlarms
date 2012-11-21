﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MedAlarms.Controllers
{
    public class LogInController : Controller
    {
        //
        // GET: /LogIn/

        //this is the action that would occur before one tries to log in
        public ActionResult Index()
        {
            return View();
        }

        //this is the action that would occur after one tried to log in
        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Email == "Brandon" && model.Password == "fall2012") //Simulate data store where Username/Password exists in database
                {
                    FormsAuthentication.SetAuthCookie(model.Email, true); //sets cookie so that user can log on after closing browser
                    return RedirectToAction("index", "home");//redirects user to index page of home controller if log in is correct
                }
                {
                    ModelState.AddModelError("", "Invalid username or password"); //adding an error message if login fails
                }
            }
            return View(); //if authentication fails, brought back to the login page
        }
    }
}