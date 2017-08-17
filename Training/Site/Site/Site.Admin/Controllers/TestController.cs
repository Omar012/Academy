using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace Site.Admin.Controllers
{
    [EnableCors(origins: "http://localhost:59643", headers: "*", methods: "*")]
    public class TestController : ApiController
    {

        // GET: api/Product
        private ProductsCatalogEntities1 db = new ProductsCatalogEntities1();
        public IEnumerable<Object> Get()
        {
            //var products = db.Products.AsEnumerable();
            //return products.ToList();

            var myProducts = db.Products.AsEnumerable();
            var myImages = db.ProductImages.AsEnumerable();
            var catalog = (from p in db.Products.AsEnumerable()
                           join i in db.ProductImages.AsEnumerable()
                           on p.Id equals i.ProductId
                           select new { p.Id, p.Name, p.ProductDescription, i.ImageUrl }).ToList();
            return catalog;
        }
}
