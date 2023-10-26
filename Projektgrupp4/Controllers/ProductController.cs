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


        public ProductController(DataContext dataContext, ProductService productService)
        {
            _dataContext = dataContext;
            _productService = productService;
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
               
            }).ToList();

            return View(viewModels);
        }


       
        
        public IActionResult CreateProduct(BackofficeProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var productEntity = new ProductEntity
                {
                    //ArticleNumber = productViewModel.ArticleNumber,
                    ProductTitle = productViewModel.ProductTitle,
                    ProductPrice = productViewModel.ProductPrice,
                    ProductImageUrl = productViewModel.ProductImageUrl,
                    ProductOfferPrice = productViewModel.ProductOfferPrice,
                    ProductPriceOrOffer = productViewModel.ProductPriceOrOffer,
                    ProductDescription = productViewModel.ProductDescription,
                    ProductReviews = new List<ReviewEntity>(),
                    ProductEntries = new List<ProductItemEntity>(),
                    ProductCategories = new List<ProductCategoriesEntity>()
                };

                // Call the CreateProduct method in the ProductService
                bool success = _productService.CreateProduct(productEntity);

                if (success)
                {
                    // Redirect to a success page 

                    return RedirectToAction("ProductBackoffice");
                }
                else
                {
                    // Handle the case where product creation fails
                   
                }
            }

            return View(productViewModel);
        }

        [HttpPost]
        public IActionResult DeleteProduct(int productId)
        {
            if (_productService.DeleteProduct(productId))
            {
                // Deletion was successful
                return RedirectToAction("ProductBackoffice");
            }
            else
            {
                // Optionally, handle the case where the product was not found
                // You can return a view or provide an error message
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

        // Page for FeaturedProducts products
        public IActionResult FeaturedProducts()
        {
            return View();
        }
    }
}
