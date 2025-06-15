using Microsoft.AspNetCore.Mvc;

namespace Restoran_Project.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Classic()
        {
            return View();
        }

        public IActionResult Board()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult Grid()
        {
            return View();
        }

        public IActionResult Simple()
        {
            return View();
        }
    }
}
