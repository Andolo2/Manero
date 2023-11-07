using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Projektgrupp4.Contexts;
using Projektgrupp4.Controllers;
using Projektgrupp4.Models.Entities;
using Projektgrupp4.Services;
using Projektgrupp4.ViewModels;

namespace Projektgrupp4.Test.Tobias_Larm_Tests;

public class ProductDetailController_Tests
{

    [Fact]
    public async Task ProductDetailController_Should_return_a_View_With_ProductDetailViewModel()
    {
        // Arrange
        var contextOptions = new DbContextOptionsBuilder<DataContext>().UseInMemoryDatabase("TestDb").Options;

        using (var context = new DataContext(contextOptions))
        {
            context.Products.Add(new ProductEntity
            {
                ArticleNumber = 1,
                ProductPrice = 123,
                ProductTitle = "Test",
                ProductDescription = "Test",
                ProductImage = new byte[] { 0x12, 0x34, 0x56, 0x78 }
            });

            context.SaveChanges();

            var productService = new ProductService(context);
            var reviewsService = new ReviewsService(context);

            var controller = new ProductDetailController(productService, reviewsService);

            //Act
            var result = await controller.ProductDetail(1);

            //Assert
            var viewResult = (ViewResult)result;
            Assert.IsType<ProductDetailViewModel>(viewResult.Model);
        }
    }
}
