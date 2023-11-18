using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Projektgrupp4.Services;
using Projektgrupp4.ViewModels;
using System.Security.Claims;

namespace Projektgrupp4.Controllers;


[Authorize]
public class ShoppingCartController : Controller
{

    private readonly ShoppingCartService _shoppingCartService;

    public ShoppingCartController(ShoppingCartService shoppingCartService)
    {
        _shoppingCartService = shoppingCartService;
    }

    public IActionResult Index()
    {
        return View();
    }

    
    public string GetCurrentUser()
    {
        ClaimsPrincipal currentUser = User;
        var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;


        if (currentUserID != null)
        {
            return currentUserID;
        }

        return string.Empty;
    }

    [HttpPost]
    public IActionResult AddProduct(ProductDetailViewModel model)
    {
        
        var currentUserID = GetCurrentUser();

        if (model != null && currentUserID != null) 
        {
            _shoppingCartService.AddToCartAsync(currentUserID, model.ArticleNumber);
        }

        return RedirectToAction("Index", "Home");
    }
}
