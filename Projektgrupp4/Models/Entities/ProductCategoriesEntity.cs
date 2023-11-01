using System.ComponentModel.DataAnnotations;

namespace Projektgrupp4.Models.Entities;

public class ProductCategoriesEntity
{
    [Key]
    public int ProductCategoryRowId { get; set; }

    public int CategoryId { get; set; }
    public CategoryEntity Category { get; set; } = null!;

    public int ProductId { get; set; }
    public ProductEntity Product { get; set; } = null!;



}
