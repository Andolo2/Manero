using Projektgrupp4.Models.Entities;
using Projektgrupp4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektgrupp4.Test.Harald_Tests;

public class OrderPrice_Test
{
    readonly ShoppingCartService shoppingCartService = new();
    [Fact]
    public void OrderPrice_ShouldReturn_TotalPriceOfShoppingCart()
    {
        //Arrange
        IEnumerable<ProductEntity> shoppingCart = new List<ProductEntity> {
            new ProductEntity{ ArticleNumber = 1, ProductPrice = 10 },
            new ProductEntity{ ArticleNumber = 2, ProductPrice = 20 },
        };

        //Act        
        var totalOrderPrice = shoppingCartService.OrderPrice(shoppingCart);
        decimal expectedResult = 30.0m;

        //Assert
        Assert.Equal(expectedResult, totalOrderPrice);
    }
}
