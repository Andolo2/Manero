using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Services;
using Projektgrupp4.ViewModels;
using System.Data.Entity;

namespace Projektgrupp4.Controllers
{
    public class NewAddressController : Controller
    {
        //private readonly UserManager<IdentityUser> _userManager;
        //private readonly AddressService _addressService;

        //public NewAddressController(UserManager<IdentityUser> userManager, AddressService addressService)
        //{
        //    _addressService = addressService;
        //    _userManager = userManager;
        //}

        //[HttpPost]
        //public async Task<IActionResult> CheckIfUserAddress(NewAddressViewModel viewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (!await _userManager.Users.AnyAsync(x => x.Id == viewModel.Id.ToString()))
        //        {
        //            if (await _addressService.RegisterAddressAsync(viewModel))
        //                return RedirectToAction("Index", "Home");
        //        }
        //        ModelState.AddModelError("", "error");
        //    }
        //    return View(viewModel);

            //if (ModelState.IsValid)
            //{
            //    if (!await _userManager.Users.AnyAsync(x => x.Id == viewModel.Id.ToString()))
            //    {
            //        if (await _addressService.RegisterAddressAsync(viewModel))
            //            return RedirectToAction("Index", "Home");
            //    }
            //    ModelState.AddModelError("", "Error");
            //}
            //return View(viewModel);
        //}

        public IActionResult Index()
        {
            return View();
        }
    }
}
