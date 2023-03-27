using Lab.EF.Logic;
using Lab.MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Lab.MVC.Controllers
{
    public class HomeController : Controller
    {
    
        public async Task<ActionResult> Index()
        {
            string url = "https://jsonplaceholder.typicode.com/todos/1";
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader st = new StreamReader(oResponse.GetResponseStream());
            string respuesta = st.ReadToEnd();
            Root Oobject = JsonConvert.DeserializeObject<Root>(respuesta);
            return View(Oobject);
        }

        public ActionResult About()
        {
            ViewBag.Message = "PRACTICA 7 MVC";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "CONTACTOS";

            return View();
        }
    }
}