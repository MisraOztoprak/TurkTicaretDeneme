using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using TurkTicaretCRM.TT.Entities.Concrete;

namespace TurkTicaretCRM.TT.DataAccess.Concrete.EntityFramework
{
    public class TTContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Debit> Debits { get; set; }
        public DbSet<CustomerDebit> CustomerDebits { get; set; }
        public DbSet<DebitActivity> DebitActivities { get; set; }
    }
}
