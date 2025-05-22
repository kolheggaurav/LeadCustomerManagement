using LeadCustomerManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeadCustomerManagement.Controllers
{
    public class CustomersController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: Customer
        public ActionResult Index()
        {
            var customers = db.Customers.ToList();
            return View(customers);
        }

        public ActionResult Delete(int id)
        {
            var customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}