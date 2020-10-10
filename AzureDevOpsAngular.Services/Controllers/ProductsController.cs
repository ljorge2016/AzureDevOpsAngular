using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureDevOpsAngular.Services.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AzureDevOpsAngular.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private List<Product> _products;

        public ProductsController()
        {
            GenerateProducts();
        }
        // GET: api/<ProductsController>
        [HttpGet]
        public List<Product> Get()
        {
            return _products;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _products.Where(p=>p.ProductId == id).FirstOrDefault();
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private void GenerateProducts()
        {
            _products = new List<Product>();
            _products.Add(new Product
            {
                ProductId = 1,
                Description = "Laptop HP 17",
                Price = 12000,
                Created = DateTime.Now,
                Update = DateTime.Now
            });
            _products.Add(new Product
            {
                ProductId = 2,
                Description = "Mouse inalambrico",
                Price = 25,
                Created = DateTime.Now,
                Update = DateTime.Now
            });
            _products.Add(new Product
            {
                ProductId = 3,
                Description = "Microfono semi profesional",
                Price = 550,
                Created = DateTime.Now,
                Update = DateTime.Now
            });
            _products.Add(new Product
            {
                ProductId = 4,
                Description = "Monitor Full HD 24",
                Price = 850,
                Created = DateTime.Now,
                Update = DateTime.Now
            });
            _products.Add(new Product
            {
                ProductId = 5,
                Description = "Teclado Gamer",
                Price = 360,
                Created = DateTime.Now,
                Update = DateTime.Now
            });
        }
    }
}

