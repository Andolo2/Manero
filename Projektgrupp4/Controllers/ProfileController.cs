﻿using Microsoft.AspNetCore.Mvc;

namespace Projektgrupp4.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
