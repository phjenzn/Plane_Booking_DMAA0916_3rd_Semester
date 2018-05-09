﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Booking.Web.Helpers;

namespace Booking.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                var client = ServiceHelper.GetServiceClient();
                ViewBag.proxy = client;
                ViewBag.proxyError = "";
            }
            catch (Exception ex)
            {
                ViewBag.proxyError = ex.ToString() ;
            }

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
      
    }
}