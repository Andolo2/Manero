using Projektgrupp4.Models.Entities;


namespace Projektgrupp4.Interfaces;

public interface ICategoryService
{
    Task<IEnumerable<CategoryEntity>> GetAllCategoriesAsync();
}