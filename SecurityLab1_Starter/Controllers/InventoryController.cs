using SecurityLab1_Starter.Class;
using SecurityLab1_Starter.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityLab1_Starter.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Inventory
        public ActionResult Index()
        {
            throw new System.ArgumentException("Parameter cannot be null", "original");
            return View();
        }


        
        protected override void OnException(ExceptionContext filterContext)
        {

            //Doing Event in Global.asax
            /*
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Application";
                eventLog.WriteEntry("Log message example", EventLogEntryType.Error, 101, 1);
            }
            */


            //Log the error!!
            filterContext.ExceptionHandled = true;

            string filepath = @"C:\Users\Benja\log.txt";
            using (StreamWriter w = System.IO.File.AppendText(filepath))
            {

                Logger.Log(filterContext.Exception.ToString(), w);
            }
            //Redirect or return a view, but not both.
            filterContext.Result = RedirectToAction("Index", "ErrorHandler");

            // OR
            /*
            filterContext.Result = new ViewResult
            {
                ViewName = "~/Views/ErrorHandler/Index.cshtml"
            };
            */
        }
        
    }
}