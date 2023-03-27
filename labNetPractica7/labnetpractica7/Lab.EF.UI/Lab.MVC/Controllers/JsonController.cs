using Lab.EF.Entities;
using Lab.EF.Logic;
using Lab.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.MVC.Controllers
{
    public class JsonController : Controller
    {
        // GET: Json
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult ObtenerShippers()
        {
            ShippersLogic sl = new ShippersLogic();
            List<Shippers> shippersview = new List<Shippers>();
            shippersview = (from s in sl.GetAll()
                            select s).ToList();
            return Json(shippersview, JsonRequestBehavior.AllowGet);
        }
    }
}