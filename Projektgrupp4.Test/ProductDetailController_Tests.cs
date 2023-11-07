
using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Contexts;
using Projektgrupp4.Controllers;
using Projektgrupp4.Models.Entities;
using Projektgrupp4.ViewModels;

namespace Projektgrupp4.Test;

public class ProductDetailController_Tests
{

    [Fact]
    public async Task asdasdasd()
    {
        // Arrange
        var dbContextOptions = new DbContextOptionsBuilder<DataContext>()
        var controller = new ProductDetailController(productService, reviewsService);
        var product = new ProductEntity()
        {
            ArticleNumber = 1,
            ProductPrice = 123,
            ProductTitle = "Test",
            ProductDescription = "Test",
        };

        //Act
        var result = await controller.ProductDetail(product.ArticleNumber);

        //Assert
        Assert.IsType<ProductDetailViewModel>(result);
    }
}
