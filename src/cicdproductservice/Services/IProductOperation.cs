using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cicdproductservice.Model;

namespace cicdproductservice.Operation
{
    public interface IProductOperation
    {
        public Product CreateProduct(Product product);

        public IEnumerable<Product> GetProducts();
    }
}