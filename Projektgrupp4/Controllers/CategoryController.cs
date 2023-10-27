using Microsoft.AspNetCore.Mvc;

namespace Projektgrupp4.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
