using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LeadCustomerManagement.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Lead> Leads { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}