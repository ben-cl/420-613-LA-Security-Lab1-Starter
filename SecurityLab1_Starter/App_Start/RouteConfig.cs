using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SecurityLab1_Starter
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Home",
                url: "Home/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new {action = "Index|Contact|About|GenError"}

            );

            routes.MapRoute(
                name: "Inventory",
                //url: "Inventory/{action}/{id}",
                url: "Inventory/Index",
                defaults: new { controller = "Inventory", action = "Index", id = UrlParameter.Optional }
            );

            // to test
            routes.MapRoute(
                name: "Login",
                //url: "Inventory/{action}/{id}",
                url: "Account/Login",
                defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
            );

            
            routes.MapRoute(
                name: "Logout",
                //url: "Inventory/{action}/{id}",
                url: "Account/Logout",
                defaults: new { controller = "Account", action = "Logout", id = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "ServerError",
                //url: "Inventory/{action}/{id}",
                url: "Error/ServerError",
                defaults: new { controller = "Error", action = "ServerError" }
            );
                        //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);


            routes.MapRoute(name: "Error404",
                url: "{*catchall}",
                defaults: new { controller = "Error", action = "Notfound" });
            
            //routes.MapRoute(name: "Error404-Inventory",
            //    url: "Inventory/{*catchall}",
            //    defaults: new { controller = "Error", action = "Notfound" });


            //routes.MapRoute(name: "Error404Controller",
            //    url: "{controller}/{*catchall}",
            //    defaults: new { controller = "Error", action = "Notfound" });
        }
    }
}
