using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmpEditor.Models;

namespace EmpEditor.Controllers
{
    public class RegistrationController : Controller
    {
        [HttpGet]
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Signup(User user)
        {
            if (ModelState.IsValid)
            {
                Week08Day03Entities ctx = new Week08Day03Entities();
                ctx.Users.Add(user);

                return View("Information", user);
            }

            return View(user);
        }

        [HttpGet]
        public ActionResult Information(User user)
        {
            return View(user);
        }
    }
}