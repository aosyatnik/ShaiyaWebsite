using ShaiyaWebsite.Contexts;
using ShaiyaWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ShaiyaWebsite.Controllers
{
    public class UserController : Controller
    {
        ShaiyaWebsiteContext db;

        public UserController()
        {
            db = new ShaiyaWebsiteContext();
        }

        #region Registration

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (db.Users.Any(u => u.Login == user.Login))
            {
                return Content("User with the same name already exists.");
            }

            db.Users.Add(user);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        #endregion

        #region Login

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(User user)
        {
            if (!ModelState.IsValid)
            {
                return Content("something");
            }
            if (db.Users.Any(u => u.Login == user.Login && u.Password == user.Password))
            {
                FormsAuthentication.SetAuthCookie(user.Login, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Login data is incorrect!");
            }


            return Content("something");
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        #endregion
    }
}
