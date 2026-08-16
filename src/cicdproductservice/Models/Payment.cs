using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cicdproductservice.Model
{
    public class Payment
    {
        public Guid PaymentId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }

}