using Microsoft.AspNetCore.Mvc;
using Projektgrupp4.Contexts;
using Projektgrupp4.Services;
using Projektgrupp4.ViewModels;

namespace Projektgrupp4.Controllers
{
    public class ColorController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly ProductService _productService;
        private readonly ColorService _colorService;

        public ColorController(DataContext dataContext, ProductService productService, ColorService colorService)
        {
            _dataContext = dataContext;
            _productService = productService;
            _colorService = colorService;
        }

        public async Task<IActionResult> CreateColor()
        {
            var viewModel = new ColorViewModel();

            var colors = await _colorService.GetAllColorsAsync();

            viewModel.Colors = colors.Select(color => color.ColorName).ToList();

            return View(viewModel);
        }



        [HttpPost]
        public async Task<IActionResult> CreateColor(ColorViewModel colorViewModel)
        {
            if (ModelState.IsValid)
            {
                var colorName = colorViewModel.ColorName;
                var createdColor = await _colorService.CreateColorAsync(colorName);

                if (createdColor != null)
                {
                    return RedirectToAction("CreateColor");
                }
                else
                {
                    ModelState.AddModelError("", "Failed to create the Color.");
                }

            }
            return View(colorViewModel);
        }
    }
}