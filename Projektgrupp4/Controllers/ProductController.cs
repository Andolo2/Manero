﻿using Microsoft.AspNetCore.Mvc;
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
                ProductImageBase64 = Convert.ToBase64String(x.ProductImage)




            }).ToList();



            return View(viewModels);
        }



 public IActionResult CreateProduct(BackofficeProductViewModel productViewModel)
{
    if (ModelState.IsValid)
    {
        var productEntity = new ProductEntity
        {
            ProductTitle = productViewModel.ProductTitle,
            ProductPrice = productViewModel.ProductPrice,
            ProductOfferPrice = productViewModel.ProductOfferPrice,
            ProductPriceOrOffer = productViewModel.ProductPriceOrOffer,
            ProductDescription = productViewModel.ProductDescription,

            ProductReviews = new List<ReviewEntity>(),
            ProductEntries = new List<ProductItemEntity>(),
            ProductCategories = new List<ProductCategoriesEntity>()
        };

        // Handle the image upload
        if (productViewModel.ProductImage != null && productViewModel.ProductImage.Length > 0)
        {
            using (var stream = new MemoryStream())
            {
                productViewModel.ProductImage.CopyTo(stream);
                productEntity.ProductImage = stream.ToArray();
            }
        }

        // Call the CreateProduct method in the ProductService
        bool success = _productService.CreateProduct(productEntity);

        if (success)
        {
            // Redirect to a success page 
            return RedirectToAction("ProductBackoffice");
        }
        else
        {
            // Redirect to an error message/page
            // You should define the appropriate error handling logic here.
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