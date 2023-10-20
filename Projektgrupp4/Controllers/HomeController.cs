using Microsoft.AspNetCore.Mvc;

namespace Projektgrupp4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
