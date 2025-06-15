using Microsoft.AspNetCore.Mvc;
using Restoran_Project.Data;

namespace Restoran_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var chefs = _context.Chefs.ToList();
            var customers = _context.Customers.ToList();

            var viewModel = new ViewModels.HomeIndexViewModel
            {
                Chefs = chefs,
                Customers = customers,
            };

            return View(viewModel);
        }
    }
}
