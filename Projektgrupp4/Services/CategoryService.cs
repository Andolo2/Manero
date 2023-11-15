using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Contexts;
using Projektgrupp4.Interfaces;
using Projektgrupp4.Models.Entities;

namespace Projektgrupp4.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _dataContext;

        public CategoryService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<CategoryEntity> CreateCategoryAsync(string categoryName)
        {
            var entity = new CategoryEntity { CategoryName = categoryName };
            _dataContext.Categories.Add(entity);

            await _dataContext.SaveChangesAsync();

            return entity;
        }

        //Används för att populera CreateProduct vy-modellen med Categories
        public async Task<List<SelectListItem>> GetCategoryAsync(string[] selectedCategories)
        {
            var category = new List<SelectListItem>();

            foreach (var categories in await GetAllCategoriesAsync())
            {
                category.Add(new SelectListItem
                {
                    Value = categories.CategoryId.ToString(),
                    Text = categories.CategoryName,
                    Selected = selectedCategories.Contains(categories.CategoryId.ToString())
                });
            }
            return category;
        }



        public async Task<IEnumerable<CategoryEntity>> GetAllCategoriesAsync()
        {
            return await _dataContext.Set<CategoryEntity>().ToListAsync();
        }

  
    }
}