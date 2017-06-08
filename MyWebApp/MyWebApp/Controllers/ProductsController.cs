using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyWebApp.Models;

namespace MyWebApp.Controllers
{
    public class ProductsController : ApiController
    {
        private List<Product> products;

        public ProductsController()
        {
            products= new List<Product>()
            {
                new Product()
                {
                    Id=1,
                    Name="Samsung",
                    Category="Mobile",
                    Price=25000
                },
                new Product()
                {
                    Id=2,
                    Name="IPhone",
                    Category="Mobile",
                    Price=25000
                }
            };
        }
        public IEnumerable<Product> Get()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = from p in products where p.Id == id select p;
            return Ok(product.FirstOrDefault());
        }

        public IHttpActionResult Post(Product product)
        {
            return Ok(product);
        }

       
    }
}
