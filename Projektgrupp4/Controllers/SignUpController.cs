using Microsoft.AspNetCore.Mvc;
using Projektgrupp4.Services;
using Projektgrupp4.ViewModels;

namespace Projektgrupp4.Controllers
{
    public class SignUpController : Controller
    {
        private readonly AuthenticationService _authService;

        public SignUpController(AuthenticationService authService)
        {
            _authService = authService;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Signup";

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(SignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (await _authService.UserAlreadyExistsAsync(x => x.Email == model.Email))
                    ModelState.AddModelError("", "An Account with the same email already exists");
                
                if (await _authService.SignUpAsync(model))
                {
                    return RedirectToAction("AccountCreated");

                }

                ModelState.AddModelError("", "Something went wrong please try again");    
            }
            return View(model);
        }

        public IActionResult AccountCreated()
        {
            return View();
        }
    }
}
