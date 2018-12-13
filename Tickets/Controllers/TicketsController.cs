using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tickets.Models;

namespace Tickets.Controllers
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
                TicketTypes = _context.TicketTypes.ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Ticket ticket)
        {

            return View();
        }
    }
}