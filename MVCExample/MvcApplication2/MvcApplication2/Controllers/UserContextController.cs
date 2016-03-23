using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;
using MvcApplication2.BL;

namespace MvcApplication2.Controllers
{
    public class UserContextController : Controller
    {
        private readonly IUserRepository _userRepository = new UserRepository();

        //
        // GET: /Default1/

        public ActionResult Index()
        {
            return View(this._userRepository.GetUserProfiles());
        }

        //
        // GET: /Default1/Details/5

        public ActionResult Details(int id = 0)
        {
            var userProfile = this._userRepository.GetUserProfileById(id);

            if (userProfile == null)
            {
                return HttpNotFound();
            }

            return View(userProfile);
        }

        //
        // GET: /Default1/Create

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Default1/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserProfile userprofile)
        {
            if (ModelState.IsValid)
            {
                this._userRepository.AddUserProfile(userprofile);

                return RedirectToAction("Index");
            }

            return View(userprofile);
        }

        //
        // GET: /Default1/Edit/5

        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            UserProfile userprofile = this._userRepository.GetUserProfileById(id);
            ViewBag.Mitko = "Test";

            if (userprofile == null)
            {
                return HttpNotFound();
            }

            return View(userprofile);
        }

        //
        // POST: /Default1/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserProfile userprofile)
        {
            ViewBag.Mitko = "Test";
            if (ModelState.IsValid)
            {
                this._userRepository.UpdateUserProfile(userprofile);

                return RedirectToAction("Index");
            }

            return View(userprofile);
        }

        //
        // GET: /Default1/Delete/5

        [HttpGet]
        public ActionResult Delete(int id = 0)
        {
            UserProfile userprofile = this._userRepository.GetUserProfileById(id);

            if (userprofile == null)
            {
                return HttpNotFound();
            }
            return View(userprofile);
        }

        //
        // POST: /Default1/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            this._userRepository.DeleteUserProfile(id);

            return RedirectToAction("Index");
        }
    }
}