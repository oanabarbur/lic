﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Licenta
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // routes.MapRoute("Contact", "Contact/{*pathinfo}", new { controller = "Home", action = "Contact" });
            //   routes.MapRoute("About", "About/{*pathinfo}", new { controller = "Home", action = "About" });

            routes.MapRoute(
                "EchipamenteByPret",
                "echipamente/{pret}",
                new { controller = "Echipamente", action = "ByPret" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
