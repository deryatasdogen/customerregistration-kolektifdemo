using KolektifHouse.DAL.Base;
using KolektifHouse.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KolektifHouse.CustomerRegistration.Controllers
{
    public class HomeController : Controller
    {
        private KolektifContext db = new KolektifContext();
        public ActionResult Index()
        {
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