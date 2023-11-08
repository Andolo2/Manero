using Microsoft.AspNetCore.Mvc;
using Projektgrupp4.Contexts;
using Projektgrupp4.Services;
using Projektgrupp4.ViewModels;

namespace Projektgrupp4.Controllers
{
    public class CategoryController : Controller
    {

        private readonly CategoryService _categoryService;

        public CategoryController(CategoryService categoryService)
        {


            _categoryService = categoryService;
        }

        public async Task<IActionResult> CreateCategory()
        {
            var viewModel = new CategoryViewModel();

            var categories = await _categoryService.GetAllCategoriesAsync();

            viewModel.Categories = categories.Select(categories => categories.CategoryName).ToList();

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryViewModel categoryViewModel)
        {
            if (ModelState.IsValid)
            {
                var categoryName = categoryViewModel.CategoryName;
                var createdCategory = await _categoryService.CreateCategoryAsync(categoryName);

                if (createdCategory != null)
                {
                    return RedirectToAction("CreateCategory");
                }
                else
                {
                    ModelState.AddModelError("", "Failed to create the Color.");
                }

            }
            return View(categoryViewModel);
        }
    }
}