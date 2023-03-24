using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.MVC.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Index(string mensaje, int identificador)
        {
            ViewBag.Mensaje = mensaje;
            ViewBag.Identificador = identificador;
            return View();
        }
    }
}