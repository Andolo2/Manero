using Microsoft.AspNetCore.Mvc;

namespace Projektgrupp4.Controllers
{
    public class ProductController : Controller
    {
        // Page for products with 50% off price
        public IActionResult Offer50()
        {
            return View();
        }

        // Page for BestSellers products
        public IActionResult BestSellers()
        {
            return View();
        }

        // Page for Featured products
        public IActionResult FeaturedProducts()
        {
            return View();
        }

        // Page for WishList products
        public IActionResult WishList()
        {
            return View();
        }
    }
}