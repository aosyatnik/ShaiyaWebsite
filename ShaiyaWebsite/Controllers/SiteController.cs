using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShaiyaWebsite.Controllers
{
    public class SiteController : Controller
    {
        public ActionResult Config()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("~/Updater/CONFIG.ini"));
            string fileName = "CONFIG.ini";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

        public ActionResult UpdateVersion()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("~/Updater/Shaiya/UpdateVersion.ini"));
            string fileName = "UpdateVersion.ini";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

        public ActionResult Patch(string file)
        {
            var path = String.Format("~/Updater/Shaiya/patch/{0}.patch", file);
            byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath(path));
            string fileName = file + ".patch";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

    }
}
