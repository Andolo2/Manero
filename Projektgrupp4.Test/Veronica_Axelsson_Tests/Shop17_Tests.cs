using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Contexts;
using Projektgrupp4.Models.Entities;
using Projektgrupp4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektgrupp4.Test.Veronica_Axelsson_Tests;

public class Shop17_Tests
{
    [Fact]
    public async Task Check_If_ProductTile_Has_Content()
    {
        // Arrange
        var _database = new DbContextOptionsBuilder<DataContext>().UseInMemoryDatabase(databaseName: "grupp4-sqlserver.database-1.dbo").Options;

        using (var context = new DataContext(_database))
        {
            var productService = new ProductService(context);

            // Act: When GetAllProductsAsync is called with products from database
            var product = new ProductEntity();
            List<ProductEntity> products = await productService.GetAllProductsAsync();

            foreach (var _product in products)
            {
                // Assert: Then we should get a list of products. Check for "not null" and "not null" there is product in database       
                Assert.NotNull(product.ProductTitle);
                Assert.NotEmpty(product.ProductTitle);
            }
        }
    }
}
