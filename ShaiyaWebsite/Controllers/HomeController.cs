using ShaiyaWebsite.Contexts;
using ShaiyaWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShaiyaWebsite.Controllers
{
    public class HomeController : Controller
    {
        ShaiyaWebsiteContext db;

        public HomeController()
        {
            db = new ShaiyaWebsiteContext();
        }
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
    }
}
