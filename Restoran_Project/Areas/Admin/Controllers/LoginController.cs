using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Restoran_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            if (username == "admin" && password == "1234")
            {
                HttpContext.Session.SetString("AdminLogin", "true");
                return RedirectToAction("Index", "Home", new { area = "Admin" });
            }
            else
            {
                ViewBag.Error = "Invalid username or password!";
                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("AdminLogin");
            return RedirectToAction("Index");
        }
    }
}
