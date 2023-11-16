using Microsoft.AspNetCore.Mvc.Rendering;
using Projektgrupp4.Models.Entities;


namespace Projektgrupp4.Interfaces;

public interface ICategoryService
{
    Task<IEnumerable<CategoryEntity>> GetAllCategoriesAsync();

    Task<CategoryEntity> CreateCategoryAsync(string categoryName);

    Task<List<SelectListItem>> GetCategoryAsync(string[] selectedCategories);
}