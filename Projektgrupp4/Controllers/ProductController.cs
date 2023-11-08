using Microsoft.AspNetCore.Mvc;
using Projektgrupp4.Contexts;
using Projektgrupp4.Models.Entities;
using Projektgrupp4.Services;
using Projektgrupp4.ViewModels;

namespace Projektgrupp4.Controllers
{
    public class ProductController : Controller
    {

        private readonly DataContext _dataContext;
        private readonly ProductService _productService;
        private readonly SizeService _sizeService;
        private readonly ColorService _colorService;
        private readonly CategoryService _categoryService;

      

        public ProductController(DataContext dataContext, ProductService productService, SizeService sizeService, ColorService colorService, CategoryService categoryService)
        {
            _dataContext = dataContext;
            _productService = productService;
            _sizeService = sizeService;
            _colorService = colorService;
            _categoryService = categoryService;
        }

      

        public ActionResult ProductBackoffice()  // LIST ALL PRODUCTS AVAILIBLE IN DATABASE
        {
            var products = _dataContext.Products.ToList();
            var viewModels = products.Select(x => new BackofficeProductViewModel
            {
                ArticleNumber = x.ArticleNumber,
                ProductTitle = x.ProductTitle,
                ProductPrice = x.ProductPrice,
                ProductOfferPrice = x.ProductOfferPrice,
                ProductPriceOrOffer = x.ProductPriceOrOffer,
                ProductDescription = x.ProductDescription,
                ProductImageBase64 = Convert.ToBase64String(x.ProductImage),



            }).ToList();
            return View(viewModels);
        }


        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var selectedColors = new string[] { };
            var selectedSizes = new string[] { };
            var selectedCategories = new string[] { };

            ViewBag.Colors = await _colorService.GetColorsAsync(selectedColors);
            ViewBag.Sizes = await _sizeService.GetSizesAsync(selectedSizes);
            ViewBag.Categories = await _categoryService.GetCategoryAsync(selectedCategories);

            var viewModel = new BackofficeProductViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(BackofficeProductViewModel viewModel, string[] colors, string[] sizes, string[] categories)
        {
            if (ModelState.IsValid)
            {
                var productEntity = new ProductEntity
                {
                    ProductTitle = viewModel.ProductTitle,
                    ProductPrice = viewModel.ProductPrice,
                    ProductOfferPrice = viewModel.ProductOfferPrice,
                    ProductPriceOrOffer = viewModel.ProductPriceOrOffer,
                    ProductDescription = viewModel.ProductDescription,
                };

                if (viewModel.ProductImage != null && viewModel.ProductImage.Length > 0)
                {
                    using (var stream = new MemoryStream())
                    {
                        viewModel.ProductImage.CopyTo(stream);
                        productEntity.ProductImage = stream.ToArray();
                    }
                }

                var product = await _productService.CreateProductAsync(productEntity, categories, colors, sizes);


                if (product != null)
                {
                    await _productService.AddProductItemAsync(product, colors, sizes, categories);
                    return RedirectToAction("Add");
                }

                ModelState.AddModelError("", "Something Went Wrong.");
            }

            // Repopulate the dropdowns with selected values if there are validation errors
            ViewBag.Colors = await _colorService.GetColorsAsync(colors);
            ViewBag.Sizes = await _sizeService.GetSizesAsync(sizes);
            ViewBag.Categories = await _categoryService.GetCategoryAsync(categories);

            return View(viewModel);
        }



        //}


        //[Authorize(Roles = "system-admin")]
        //[HttpPost]
        public IActionResult DeleteProduct(int productId)
        {
            if (_productService.DeleteProduct(productId))
            {
                // Deletion was successful
                return RedirectToAction("ProductBackoffice");
            }
            else
            {

                return View();
            }
        }






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