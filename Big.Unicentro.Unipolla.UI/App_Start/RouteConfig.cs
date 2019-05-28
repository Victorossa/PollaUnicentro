using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Big.Unicentro.Unipolla.UI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
    name: "123",
    url: "123",
    defaults: new { controller = "Home", action = "unipollacopaamerica" });

            
            routes.MapRoute(
    name: "Default",
    url: "{controller}/{action}/{id}",
    defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
);
        }
    }
}
