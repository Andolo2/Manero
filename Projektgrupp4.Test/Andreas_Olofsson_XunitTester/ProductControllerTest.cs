using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Moq;
using Projektgrupp4.Contexts;
using Projektgrupp4.Controllers;
using Projektgrupp4.Models.Entities;
using Projektgrupp4.Services;
using Projektgrupp4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektgrupp4.Test.Andreas_Olofsson_XunitTester
{
    public class ProductControllerTests
    {
        [Fact]
        public async Task CreateProductAsync_Should_CreateProductAndProductItems()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "InMemoryDatabase")
                .Options;

            using (var context = new DataContext(options))
            {
                var productService = new ProductService(context);

                // Exempelbild för att fylla min array)
                byte[] sampleImageBytes = new byte[] { 0x00, 0x01, 0x02, 0x03, };

                // Act
                var product = new ProductEntity
                {
                    ProductImage = sampleImageBytes,
                    ProductTitle = "Testprodukt",
                    ProductPrice = 50.0m, // Exempelpris
                    ProductOfferPrice = 45.0m, // Exempel på erbjudandepris
                    ProductPriceOrOffer = true, // Exempel på pris eller erbjudande
                    ProductDescription = "Testproduktbeskrivning", // Exempel på beskrivning
                    
                };

                var categories = new string[] { "1" };
                var colors = new string[] { "3" };
                var sizes = new string[] { "5" };

                await productService.CreateProductAsync(product, categories, colors, sizes);

                // Assert
                // Verifiera att produkten och produktartiklarna har lagts till i minnesdatabasen
                Assert.Equal(1, context.Products.Count());
                Assert.Equal(1, context.ProductItem.Count()); // Antalet produkter i databasen efter testet
            }
        }

    }
}
