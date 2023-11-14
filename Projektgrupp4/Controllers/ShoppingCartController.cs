using Microsoft.AspNetCore.Mvc;

namespace Projektgrupp4.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
