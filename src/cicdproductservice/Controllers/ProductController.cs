using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cicdproductservice.Operation;

namespace cicdproductservice.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductOperation _productOperation;
        public ProductController(IProductOperation productOperation)
        {
            Console.WriteLine("ProductController constructor called");
            _productOperation = productOperation;
        }

        [HttpPost]
        public IActionResult CreateProduct(Model.Product product)
        {
            Console.WriteLine("ProductController.CreateProduct() called", product);
            var result = _productOperation.CreateProduct(product);
            return Ok(result);
        }

        [HttpGet("GetAllProducts")]
        public IActionResult GetProducts()
        {
            var result = _productOperation.GetProducts();
            return Ok(result);
        }
    }
}