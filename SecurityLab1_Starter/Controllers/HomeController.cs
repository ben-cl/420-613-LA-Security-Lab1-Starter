﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SecurityLab1_Starter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //throw new System.ArgumentException("Parameter cannot be null", "original");


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";


            
            return View();
        }

        public ActionResult GenError()
        {
            throw new System.ArgumentException("Parameter cannot be null", "original");


        }


    }
}