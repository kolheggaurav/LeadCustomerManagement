using LeadCustomerManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeadCustomerManagement.Controllers
{
    public class LeadsController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: Leads
        public ActionResult Index()
        {
            var leads = db.Leads.ToList();
            return View(leads);
        }

        // GET: Leads/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Lead lead)
        {
            if (ModelState.IsValid)
            {
                db.Leads.Add(lead);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lead);
        }

        // GET: Leads/Edit 
        public ActionResult Edit(int id)
        {
            var lead = db.Leads.Find(id);
            return View(lead);
        }

        [HttpPost]
        public ActionResult Edit(Lead lead)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lead).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lead);
        }

        public ActionResult Delete(int id)
        {
            var lead = db.Leads.Find(id);
            db.Leads.Remove(lead);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // Convert to Customer
        public ActionResult ConvertToCustomer(int id)
        {
            var lead = db.Leads.Find(id);
            if (lead != null)
            {
                var customer = new Customer
                {
                    Name = lead.Name,
                    Email = lead.Email,
                    Contact = lead.Contact,
                    Company = lead.Company
                };

                db.Customers.Add(customer);
                db.Leads.Remove(lead);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }

}