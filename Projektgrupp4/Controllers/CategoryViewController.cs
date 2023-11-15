using Microsoft.AspNetCore.Mvc;
using Projektgrupp4.Interfaces;
using Projektgrupp4.Services;
using Projektgrupp4.ViewModels;

namespace Projektgrupp4.Controllers
{
    public class CategoryViewController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryViewController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new CategoryViewModel();

            var categories = await _categoryService.GetAllCategoriesAsync();

            viewModel.Categories = categories.Select(c => c.CategoryName).ToList();

            return View(viewModel);
        }
    }


}

