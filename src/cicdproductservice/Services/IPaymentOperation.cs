using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cicdproductservice.Model;

namespace cicdproductservice.Operation
{
    public interface IPaymentOperation
    {
        public Payment CreatePayment(Payment payment);

        public IEnumerable<Payment> GetPayments();

        public Payment GetPaymentById(string id);
    }
}