﻿using Microsoft.AspNetCore.Mvc;

namespace Restoran_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
