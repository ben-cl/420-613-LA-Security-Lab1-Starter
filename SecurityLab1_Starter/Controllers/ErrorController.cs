using SecurityLab1_Starter.Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using System.IO.File;

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

            /*
            using (StreamWriter w = System.IO.File.AppendText("log.txt"))
            {
                DirAppend.Log("Test1", w);
                DirAppend.Log("Test2", w);
            }

            using (StreamReader r = System.IO.File.OpenText("log.txt"))
            {
                DirAppend.DumpLog(r);
            }

            */
            ViewBag.Error = aspxerrorpath;
            return View();
        }

    }
}