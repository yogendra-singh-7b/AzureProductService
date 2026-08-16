using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace cicdproductservice.Data
{
    public class PaymentDBContext : DbContext
    {

        public PaymentDBContext(DbContextOptions<PaymentDBContext> options) : base(options)
        {
        }

        public DbSet<cicdproductservice.Model.Payment> Payments { get; set; }
    }
}