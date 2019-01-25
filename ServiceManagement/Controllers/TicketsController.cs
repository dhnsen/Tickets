using Microsoft.AspNet.Identity;
using ServiceManagement.Models;
using ServiceManagement.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace ServiceManagement.Controllers
{
    [Authorize]
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

        [HttpPost]
        public ActionResult Create(TicketFormViewModel viewModel)
        {
            
            var customer = _context.Customers.Single(c => c.Id == viewModel.Customer);
            var ticket = new Ticket
            {
                CreatedById = User.Identity.GetUserId(),
                CreatedDate = System.DateTime.Now,
                Summary = viewModel.Summary,
                Description = viewModel.Description,
                Customer = customer

            };
            _context.Tickets.Add(ticket);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}