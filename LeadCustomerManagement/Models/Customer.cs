using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeadCustomerManagement.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Company { get; set; }

    }

}