using System.ComponentModel.DataAnnotations;

namespace Projektgrupp4.Models.Entities;

public class ProductCategoriesEntity
{
    [Key]
    public int CategoryId { get; set; }

    public string CategoryBestSeller { get; set; } = null!;

    public string CategoryFeatured { get; set; } = null!;


}
