﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Pokolib;
using Services;
using Specification;
using Membership;
using JsonDataRepository;

namespace AuthWebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        // GET api/products
        public IEnumerable<Product> Get()
        {
            IProductService svc =new ProductService();
            ProductService productService = new ProductService();
            productService.Seeding();
            List<Product> products = svc.GetAll();
            return products;

           
        }

        // GET api/products/5
        public Product Get(int id)
        {
            IProductService svc = new ProductService();
            Product product = svc.Get(id);
            return product;

        }

        // POST api/products
        public void Post([FromBody] Product product)
        {
            IProductService svc = new ProductService();
            svc.Insert(product);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] Product  value)
        {
            IProductService svc=new ProductService();
            svc.Get(id);
            svc.Update(value);
           


        }

        // DELETE api/products/5
        public void Delete(int id)
        {
            IProductService svc = new ProductService();
            svc.Delete(id);
        }
    }
}
