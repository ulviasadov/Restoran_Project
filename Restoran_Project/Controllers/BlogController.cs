using Microsoft.AspNetCore.Mvc;

namespace Restoran_Project.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Carousel()
        {
            return View();
        }

        public IActionResult Grid()
        {
            return View();
        }

        public IActionResult Single()
        {
            return View();
        }

        public IActionResult Standard()
        {
            return View();
        }
    }
}
