using cars2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cars2.Controllers
{
    public class HomeController : Controller
    {

        Model1 db = new Model1();

               
        public ActionResult Index()
        {
            var collection = db.Automobiles;

            ViewBag.Automobiles = collection;

            return View();
        }
        
    }
}