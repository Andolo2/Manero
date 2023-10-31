using Microsoft.AspNetCore.Mvc;
using Projektgrupp4.Services;
using Projektgrupp4.ViewModels;

namespace Projektgrupp4.Controllers
{
	public class ProductDetailController : Controller
	{

        private readonly ProductService _productService;

        public ProductDetailController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> ProductDetail(int articleNumber)
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
