using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cicdproductservice.Data;
using cicdproductservice.Model;
using cicdproductservice.Operation;

namespace cicdproductservice.Service
{
    public class PaymentOperation : IPaymentOperation
    {
        private readonly PaymentDBContext _context;
        public PaymentOperation(PaymentDBContext context)
        {
            _context = context;
        }
        public Payment CreatePayment(Payment payment)
        {
            Console.WriteLine("PaymentOperation.CreatePayment() called", payment);
            var result = _context.Payments.Add(payment);
            _context.SaveChanges();
            return payment;
        }

        public IEnumerable<Payment> GetPayments()
        {
            return _context.Payments.ToList();
        }
    }

}