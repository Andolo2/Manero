using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Contexts;
using Projektgrupp4.Models.Entities;

namespace Projektgrupp4.Services;

public class ShoppingCartService
{
    private readonly DataContext _context;

    public ShoppingCartService(DataContext context)
    {
        _context = context;
    }

    public void AddToCartAsync(string userId, int productId)
    {

        if (userId != null)
        {
            if (_context.ShoppingCart.Any(x => x.ProductId == productId && x.UserId == userId))
            {
                return;
            }
             
            var shoppingCartEntity = new ShoppingCartEntity
            {
                UserId = userId,
                ProductId = productId
            };

            _context.ShoppingCart.Add(shoppingCartEntity);
            _context.SaveChanges();
        }
    }

    public IEnumerable<ProductEntity> GetShoppingCart(string userId)
    {

        var cart = _context.ShoppingCart
            .Where(x => x.UserId == userId)
            .Select(x => x.Product)
            .ToList();

        foreach (var product in cart)
        {
            product.ProductEntry = _context.ProductItem
                .Include(x => x.Color)
                .Include(x => x.Size)
                .FirstOrDefault(x => x.ProductId == product.ArticleNumber);
        }

        if (cart != null)
        {
            return cart;
        }

        return Enumerable.Empty<ProductEntity>();
    }

    public decimal OrderPrice(IEnumerable<ProductEntity> cart)
    {
        if (cart != null)
        {
            decimal orderPrice = 0;
            foreach (var product in cart)
            {
                orderPrice += product.ProductPrice;
            }
            return orderPrice;
        }
        else return 0;
    }

    public decimal OrderDiscount(IEnumerable<ProductEntity> cart)
    {
        if (cart != null)
        {
            decimal orderDiscount = 0;
            foreach (var product in cart)
            {
                if (product.ProductOfferPrice != null)
                {
                    
                    orderDiscount = product.ProductPrice -= (decimal)product.ProductOfferPrice;
                    
                }
            }
            return orderDiscount;
        }
        else return 0;
    }

    public decimal TotalOrderPrice(IEnumerable<ProductEntity> cart)
    {
        if (cart != null)
        {
            decimal totalOrderPrice = 0;
            foreach (var product in cart)
            {
                if (product.ProductOfferPrice != null)
                {
                     totalOrderPrice += product.ProductOfferPrice ?? 0;
                }

                else
                {
                    totalOrderPrice += product.ProductPrice;
                }
            }
            
            return totalOrderPrice;
        }
        else return 0;
    }
}

