using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cicdproductservice.Data;
using cicdproductservice.Model;
using cicdproductservice.Operation;

namespace cicdproductservice.Service
{
    public class ProductOperation : IProductOperation
    {
        private readonly ProductDBContext _context;
        public ProductOperation(ProductDBContext context)
        {
            _context = context;
        }
        public Product CreateProduct(Product product)
        {
            Console.WriteLine("ProductOperation.CreateProduct() called", product);
            var result = _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }
    }

}