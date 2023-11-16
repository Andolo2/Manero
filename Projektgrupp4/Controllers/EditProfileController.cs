using Microsoft.AspNetCore.Mvc;
using Projektgrupp4.Services;

namespace Projektgrupp4.Controllers
{
    public class EditProfileController : Controller
    {
      /*  private readonly AuthenticationService _authService;

        public EditProfileController(AuthenticationService authService)
        {
            _authService = authService;
        }
      */

        public IActionResult Index()
        {
            return View();
        }


    }
}
