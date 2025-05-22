using LeadCustomerManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeadCustomerManagement.Controllers
{
    public class HomeController : Controller
    {
        // view home page
        public ActionResult Index()
        {
            return View();
        }
    }
}