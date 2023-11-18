using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Contexts;
using Projektgrupp4.Models.Entities;
using Projektgrupp4.Services;

namespace Projektgrupp4.Test.Veronica_Axelsson_Tests;

public class Shop17_Tests
{
    [Fact]
    public async Task Check_If_ProductTitle_Has_Content()
    {
        // Arrange. Given database and product service.
        var _database = new DbContextOptionsBuilder<DataContext>().UseInMemoryDatabase(databaseName: "grupp4-sqlserver.database-1.dbo").Options;

        using (var context = new DataContext(_database))
        {
            var productService = new ProductService(context);

            // Act: When GetAllProductsAsync is called with products from database
            var product = new ProductEntity();
            List<ProductEntity> products = await productService.GetAllProductsAsync();

            foreach (var _product in products)
            {
                // Assert: Then we should get a list of products. Check for "not null" and "not empty".       
                Assert.NotNull(_product.ProductTitle);
                Assert.NotEmpty(_product.ProductTitle);
            }
        }
    }
}
