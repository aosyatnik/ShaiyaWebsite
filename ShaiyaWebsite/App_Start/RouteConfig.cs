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
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            var shaiyaFolder = HostingEnvironment.MapPath("~/App_Data/Shaiya");
            if (!Directory.Exists(shaiyaFolder))
            {
                Directory.CreateDirectory(shaiyaFolder);
            }
        }
    }
}