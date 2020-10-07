﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MIS4200Murray.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Vincent Murray";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact information for Vincent Murray";

            return View();
        }
    }
}