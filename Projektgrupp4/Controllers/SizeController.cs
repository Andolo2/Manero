using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Projektgrupp4.Contexts;
using Projektgrupp4.ViewModels;
using Projektgrupp4.Services;

namespace Projektgrupp4.Controllers
{



    public class SizeController : Controller
    {
        private readonly SizeService _sizeService;

        public SizeController(SizeService sizeService)
        {
            _sizeService = sizeService;
        }



        public async Task<IActionResult> CreateSize()
        {
            var viewModel = new SizeViewModel();

            var sizes = await _sizeService.GetAllSizesAsync();

            viewModel.Sizes = sizes.Select(size => size.SizeName).ToList();

            return View(viewModel);
        }


        [HttpPost]
        public async Task<IActionResult> CreateSize(SizeViewModel sizeViewModel)
        {
            if (ModelState.IsValid)
            {
                var sizeName = sizeViewModel.SizeName;
                var createdSize = await _sizeService.CreateSizeAsync(sizeName);

                if (createdSize != null)
                {
                    return RedirectToAction("CreateSize");
                }
                else
                {
                    ModelState.AddModelError("", "Failed to create the Size.");
                }

            }
            return View(sizeViewModel);
        }
    }


}






