using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShaiyaWebsite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.RouteExistingFiles = true;

            routes.MapRoute(
               name: "Config",
               url: "{config}.ini",
               defaults: new { controller = "Site", action = "Config" }
            );

            routes.MapRoute(
                name: "UpdateVersionRoute",
                url: "Shaiya/UpdateVersion.ini",
                defaults: new { controller = "Site", action = "UpdateVersion" }
            );

            routes.MapRoute(
                name: "PatchRoute",
                url: "Shaiya/patch/{file}.patch",
                defaults: new { controller = "Site", action = "Patch" }
            );

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}