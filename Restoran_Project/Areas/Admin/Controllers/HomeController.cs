using Microsoft.AspNetCore.Mvc;

namespace Restoran_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("AdminLogin") != "true")
            {
                return RedirectToAction("Index", "Login", new { area = "Admin" });
            }

            return View();
        }
    }
}
