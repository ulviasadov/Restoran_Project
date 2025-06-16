using Microsoft.AspNetCore.Mvc;

namespace Restoran_Project.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult FourCols()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Single()
        {
            return View();
        }
    }
}
