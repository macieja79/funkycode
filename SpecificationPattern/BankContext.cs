using FunkyCode;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkyCode
{
    public class BankContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Customer> Accounts { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
