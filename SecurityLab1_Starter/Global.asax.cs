﻿using SecurityLab1_Starter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SecurityLab1_Starter
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            


FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            
            //RouteConfig.RegisterRoutes(RouteTable.Routes);

            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // not sure about this line if good and good place 
            DependencyResolver.SetResolver(new Infrastructure.NinjectDependencyResolver());
        }

        protected void Application_Error()
        {
            var ex = Server.GetLastError();
            //log the error!
            //_Logger.Error(ex);

            Logger log = new Logger();
            log.LogToEventViewer(System.Diagnostics.EventLogEntryType.Error, ex.Message); 


            // Redirect? 
        }



    }
}
