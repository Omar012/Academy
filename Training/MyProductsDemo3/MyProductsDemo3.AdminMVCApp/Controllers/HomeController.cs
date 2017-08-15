using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProductsDemo3.AdminMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public object Assert { get; private set; }

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