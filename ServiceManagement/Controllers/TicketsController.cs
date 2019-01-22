using ServiceManagement.Models;
using ServiceManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiceManagement.Controllers
{
    public class TicketsController : Controller
    {
        private ApplicationDbContext _context;

        public TicketsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Tickets
        public ActionResult Create()
        {
            var viewModel = new TicketFormViewModel
            {
                Customers = _context.Customers.ToList()
            };
            return View(viewModel);
        }
    }
}