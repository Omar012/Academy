using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using MyProductsDemo3.AdminMVCApp;
using MyProductsDemo3.AdminMVCApp.Controllers;

namespace MyProductsDemo3.AdminMVCApp.Tests.Controllers
{
    [TestClass]
    public class ProductControllerTest
    {
        [TestMethod]
        public void Index()
        {
            ProductsController Controller = new ProductsController();

            ViewResult result = Controller.Index() as ViewResult;

            result.ViewData.ToList();


            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Details()
        {
            ProductsController controller = new ProductsController();
            ViewResult result = controller.Details(2) as ViewResult;
            Assert.IsNotNull(result);
        }
        
 
           

   }
}

