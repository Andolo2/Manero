using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Contexts;
using Projektgrupp4.Models.Entities;
using System.Security.Claims;

namespace Projektgrupp4.Services;

public class ShoppingCartService
{
    private readonly DataContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly UserManager<UserEntity> _userManager;

    public ShoppingCartService(DataContext context, UserManager<UserEntity> userManager, IHttpContextAccessor httpContextAccessor)
    {
        _context = context;
        _userManager = userManager;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<string?> GetCurrentUserIdAsync()
    {
        // Get the current user's claims principal
        ClaimsPrincipal? userPrincipal = _httpContextAccessor.HttpContext?.User;

        // Check if the user is authenticated
        if (userPrincipal?.Identity?.IsAuthenticated == true)
        {
            // Get the user's ID using UserManager
            UserEntity? currentUser = await _userManager.GetUserAsync(userPrincipal);

            // Return the user's ID
            return currentUser?.Id;
        }

        // If the user is not authenticated, return null
        return null;
    }

    public async Task<IEnumerable<ProductEntity>> GetCartAsync()
    {
        var userId = await GetCurrentUserIdAsync();
        var cartEntity = await _context.ShoppingCart.FirstOrDefaultAsync(x => x.ShoppingCartUser.Id == userId);

        if (cartEntity != null)
        {
            var cart = cartEntity.ShoppingCartProducts;
            return cart;
        }

        else return null!;
    }

    public decimal OrderPrice(IEnumerable<ProductEntity> cart)
    {
        if (cart != null)
        {
            decimal orderPrice = 0;
            foreach (var product in cart)
            {
                product.ProductPrice += orderPrice;
            }
            return orderPrice;
        }
        else return 0;
    }

    public decimal OrderDiscount(IEnumerable<ProductEntity> cart)
    {
        if (cart != null)
        {
            decimal orderPrice = 0;
            decimal normalPrice = 0;
            decimal orderDiscount = 0;
            foreach (var product in cart)
            {
                product.ProductPrice += normalPrice;
                product.ProductOfferPrice += orderPrice;
            }
            normalPrice -= orderPrice = orderDiscount;
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
                    product.ProductOfferPrice += totalOrderPrice;
                }

                else
                {
                    product.ProductPrice += totalOrderPrice;
                }
            }
            
            return totalOrderPrice;
        }
        else return 0;
    }
}

