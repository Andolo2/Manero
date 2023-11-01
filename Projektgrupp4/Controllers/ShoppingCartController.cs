using Microsoft.AspNetCore.Mvc;

namespace Projektgrupp4.Controllers
{
    public class ShoppingCartController : Controller
    {
        // Index renderar ut en tom varukorg
        public IActionResult Index()
        {
            return View();
        }

        // ShoppingCart renderar ut en varukorg med produkter
        public IActionResult ShoppingCart() 
        {
            return View();
        }
    }
}
