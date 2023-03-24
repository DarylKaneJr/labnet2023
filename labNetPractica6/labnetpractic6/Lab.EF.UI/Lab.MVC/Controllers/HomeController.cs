using Lab.EF.Logic;
using Lab.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.MVC.Controllers
{
    public class HomeController : Controller
    {
    
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "PRACTICA 6 MVC";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "CONTACTOS";

            return View();
        }
    }
}