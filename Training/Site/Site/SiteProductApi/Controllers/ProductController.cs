using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using SiteProductApi.Models;


namespace SiteProductApi.Controllers
{
    public class ProductController : ApiController
    {
        // GET: api/Product
        private ProductsCatalogEntities db = new ProductsCatalogEntities();
        public IEnumerable<Product> Get()
        {
            var products = db.Products.AsEnumerable();
            return products.ToList();
        }

    }
}
