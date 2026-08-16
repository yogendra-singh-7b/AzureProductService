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
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentOperation _paymentOperation;
        public PaymentController(IPaymentOperation paymentOperation)
        {
            Console.WriteLine("PaymentController constructor called");
            _paymentOperation = paymentOperation;
        }

        [HttpPost]
        public IActionResult CreatePayment(Model.Payment payment)
        {
            Console.WriteLine("PaymentController.CreatePayment() called", payment);
            var result = _paymentOperation.CreatePayment(payment);
            return Ok(result);
        }

        [HttpGet("GetAllPayments")]
        public IActionResult GetPayments()
        {
            var result = _paymentOperation.GetPayments();
            return Ok(result);
        }
    }
}