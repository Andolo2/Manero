using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Projektgrupp4.Models.Entities;

namespace Projektgrupp4.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<UserEntity> _signInManager;

        public AccountController(SignInManager<UserEntity> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
