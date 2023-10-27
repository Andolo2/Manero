using Microsoft.AspNetCore.Mvc;
using Projektgrupp4.Services;
using Projektgrupp4.ViewModels;

namespace Projektgrupp4.Controllers
{
    public class SignInController : Controller
    {
        private readonly AuthenticationService _authService;

        public SignInController(AuthenticationService authService)
        {
            _authService = authService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(SignInViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (await _authService.SignInAsync(model))
                    return RedirectToAction("Index", "Home");


                ModelState.AddModelError("", "Incorrect Email or Password");
            }

            return View(model);
        }
    }
}
