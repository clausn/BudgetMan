using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using test.Models;

namespace test.Controllers
{
    public class DefaultController : ApiController
    {
        Transactions[] products = new Transactions[]
        {
            
        };

        public IEnumerable<Transactions> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
