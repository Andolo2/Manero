using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Contexts;
using Projektgrupp4.Models.Entities;
using Projektgrupp4.Services;

namespace Projektgrupp4.Test.Veronica_Axelsson_Tests;

public class Home13_Tests
{
    [Fact]
    public async Task Check_If_GetAllProductsAsync_Is_working()
    {
        // Arrange. Given database and product service.
        var _database = new DbContextOptionsBuilder<DataContext>().UseInMemoryDatabase(databaseName: "grupp4-sqlserver.database-1.dbo").Options;

        using (var context = new DataContext(_database))
        {
            var productService = new ProductService(context);

            // Act: When GetAllProductsAsync is called with products from database
            ProductEntity product = new ProductEntity();
            List<ProductEntity> products = await productService.GetAllProductsAsync();

            foreach (var _product in products)
            {
                // Assert: Then we should get a list of products. Check for "not null", "not empty" and if "true" there is product in database
                Assert.NotNull(_product);
                Assert.NotEmpty(products);
                Assert.True(products.Count > 0);
            }
        }
    }
}
