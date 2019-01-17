using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServiceManagement.Data;
using ServiceManagement.Models;

namespace ServiceManagement.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var customers = _context.Customers;
            return View(customers);
        }

        public ActionResult Create()
        {
            var customer = new Customer();
            return View(customer);
        }
    }
}