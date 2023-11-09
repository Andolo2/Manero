using Microsoft.AspNetCore.Mvc;
using Projektgrupp4.Enum;
using Projektgrupp4.Services;
using Projektgrupp4.ViewModels;
using System.Reflection.Metadata.Ecma335;

namespace Projektgrupp4.Controllers
{
    public class SignUpController : Controller
    {
        private readonly IAuthenticationService _authService;

        public SignUpController(IAuthenticationService authService)
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
            var response = await _authService.SignUpAsync(model);

            if (response == null)
            {
                ModelState.AddModelError("", "Error occurred while signing up. Please try again.");
                return View(model);
            }

            if (ModelState.IsValid)
            {
                if (await _authService.UserAlreadyExistsAsync(x => x.Email == model.Email))
                {
                    ModelState.AddModelError("", "An Account with the same email already exists");
                }

                if (response.StatusCode == Enum.StatusCode.Created)
                {
                    return RedirectToAction("AccountCreated");
                }
                else
                {
                    ModelState.AddModelError("", "Something went wrong please try again");
                }
            }
            return View(model);
        }

        public IActionResult AccountCreated()
        {
            return View();
        }
    }
}
