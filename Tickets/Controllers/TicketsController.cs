using Microsoft.AspNet.Identity;
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
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new TicketFormViewModel
            {
                TicketTypes = _context.TicketTypes.ToList()
            };

            return View(viewModel);
        }
        
        [Authorize]
        [HttpPost]
        public ActionResult Create(Ticket ticket)
        {
            ViewBag.PostMessage = "";
            if (!ModelState.IsValid)
            {
                ViewBag.PostMessage = "Save Failed";
                return View("Create", ticket);
            }
            var context = new ApplicationDbContext();

            var requestor = _context.Users.Single(u => u.Id == User.Identity.GetUserId());

            var newTicket = new Ticket
            {
                RequestorId = User.Identity.GetUserId(),
                Summary = ticket.Summary,
                TicketType = ticket.TicketType,
                CreatedDate = DateTime.UtcNow,
                Requestor = requestor
            };
            _context.Tickets.Add(newTicket);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}