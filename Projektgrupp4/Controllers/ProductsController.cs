using Microsoft.AspNetCore.Mvc;

namespace Projektgrupp4.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
