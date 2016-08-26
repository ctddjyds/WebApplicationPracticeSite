using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplicationPracticeSite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //URL规则，多个URL规则时，将default放在最后
            routes.MapRoute(
                name: "Hello",
                url: "{controller}/{action}/{name}/{id}",
                defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Account", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "WebApplicationPracticeSite.Controllers" }
            );
          
        }
    }
}
