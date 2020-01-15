using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityLab1_Starter.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Notfound()
        {
            return View();
        }
        public ActionResult ServerError(String aspxerrorpath)
        {
            // ViewBag.CurrentURL = Request.Url.ToString(); 
            // Request.QueryString["aspxerrorpath"]; 
            ViewBag.Error = aspxerrorpath;
            return View();
        }
    }
}