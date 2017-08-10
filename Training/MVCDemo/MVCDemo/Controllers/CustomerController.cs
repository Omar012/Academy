using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public string Index()
        {
            return GetAllCustomers();
        }
        [NonAction]
        public string GetAllCustomers()
        {
            return @"
                <ul>
                    <li>  Omar </li>
                    <li>  Pepe </li>
                    <li>  Luis </li>
                    <li>  Diego Alonso </li>
                </ul>";
        }


        public ActionResult MyView()
        {
            return View();
        }

        }
    }
