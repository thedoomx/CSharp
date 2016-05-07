using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmpEditor.Models;
using System.Web.Security;

namespace EmpEditor.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IUserRepository _repository = new UserRepository();

        public ActionResult Index()
        {
            if(Request.IsAuthenticated)
            {
                return RedirectToAction("Index", "Employee");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Signup(UserModel user)
        {
            if (ModelState.IsValid)
            {
                if(_repository.AddUser(user))
                {
                    if (user.Password != user.RepeatPassword)
                    {
                        ViewBag.Title = "Password doesn't match!";
                        return View(user);
                    }
                    return View("Information", user);
                }
            }

            ViewBag.Title = "Email is already in use!";
            return View(user);
        }

        [HttpGet]
        public ActionResult Information(User user)
        {
            return View(user);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserModel user)
        {
            
            if (ModelState.IsValid)
            {

                if(_repository.IsValid(user.Email, user.Password))
                {
                    FormsAuthentication.SetAuthCookie(user.Email, false);
                    return RedirectToAction("Index", "Employee");
                }
                else
                {
                    ModelState.AddModelError("", "Login data is incorrect.");
                }

            }

            return View(user);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Registration");
        }
    }
}