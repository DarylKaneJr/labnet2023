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
    public class ShippersController : Controller
    {
        public ActionResult Index()
        {
            var logic = new ShippersLogic();
            var shippers = logic.GetAll();
            List<ShippersView> shippersview = shippers.Select(s => new ShippersView
            {
                ShippersID = s.ShipperID,
                CompanyName = s.CompanyName,
                Phone = s.Phone
            }).ToList();
            return View(shippersview);
        }

        public ActionResult Delete(int id)
        {
            var logic = new ShippersLogic();
            logic.Delete(id);
            return RedirectToAction("Index");
        }
        public ActionResult Insert()
        {
            return View();
        }
        public ActionResult Update(int id)
        {
            ShippersLogic sl = new ShippersLogic();
            ShippersView model = new ShippersView();
            var entity = sl.GetAll();
            foreach (var item in entity)
            {
                if (item.ShipperID == id)
                {
                    model.ShippersID = item.ShipperID;
                    model.CompanyName = item.CompanyName;
                    model.Phone = item.Phone;
                }
            }
            return View("Insert", model);
        }

        [HttpPost]
        public ActionResult Update(ShippersView shippersview)
        {
            ShippersLogic Osl = new ShippersLogic();
            Shippers obj;
            obj = new Shippers();
            obj.ShipperID = shippersview.ShippersID;
            obj.CompanyName = shippersview.CompanyName;
            obj.Phone = shippersview.Phone;
            Osl.Update(obj);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Insert(ShippersView shippersview)
        {
            try
            {
                var logic = new ShippersLogic();
                Shippers newshippers = new Shippers { CompanyName = shippersview.CompanyName, Phone = shippersview.Phone };
                logic.Add(newshippers);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }
    }
}
