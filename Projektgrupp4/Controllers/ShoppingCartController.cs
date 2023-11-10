using Microsoft.AspNetCore.Mvc;
using Projektgrupp4.Models.Entities;
using Projektgrupp4.Services;

namespace Projektgrupp4.Controllers
{
    public class ShoppingCartController : Controller
    {

        private readonly ShoppingCartService _shoppingCartService;

        public ShoppingCartController(ShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }

        // Index renderar ut en tom varukorg
        public IActionResult Index()
        {
            var cart = (ICollection<ProductEntity>)_shoppingCartService.GetCartAsync();
            if (cart == null)
            {
                return View();
            }
            else 
            {
                return ShoppingCart();
            }
        }

        // ShoppingCart renderar ut en varukorg med produkter
        public IActionResult ShoppingCart() 
        {
            return View();
        }

        public async Task<IActionResult> AddToCart(int articleNumber) 
        {
            await _shoppingCartService.AddProductToShoppingCartInDatabaseAsync(articleNumber);
            return View();
        }
    }
}
