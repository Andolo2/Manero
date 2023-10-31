using Microsoft.AspNetCore.Mvc;
using Projektgrupp4.ViewModels;

namespace Projektgrupp4.Controllers
{
	public class ProductDetailController : Controller
	{

        private readonly ProductService _productService;

        [HttpGet]
        public IActionResult ProductDetail()
		{
            
            public async Task<IActionResult> Index(int articleNumber)
            {
                var product = await _productService.GetProductAsync(articleNumber);
                if (product != null)
                {
                    ProductDetailViewModel viewModel = product;
                    viewModel.ProductSizes = product.ProductEntries.Select(x => x.Size).Distinct().ToList();
                    viewModel.ProductColors = product.ProductEntries.Select(x => x.Color).Distinct().ToList();

                    return View(viewModel);
                }

                return NotFound();
            }

        }
    }
}
