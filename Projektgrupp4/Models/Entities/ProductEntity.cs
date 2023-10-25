using Projektgrupp4.Enum;
using System.ComponentModel.DataAnnotations;

namespace Projektgrupp4.Models.Entities;

public class ProductEntity
{
    [Key]
    public int ArticleNumber { get; set; }
    public string? ProductImageUrl { get; set; } = null!;
    public string ProductTitle { get; set; } = null!;
    public decimal ProductPrice { get; set; }
    public decimal? ProductOfferPrice { get; set; }     
    public bool ProductPriceOrOffer { get; set; } = true;
                                                          
    public string? ProductDescription { get; set; } = null!;

    public ICollection<ReviewEntity> ProductReviews { get; set; } = new HashSet<ReviewEntity>();

    public ICollection<ProductItemEntity> ProductEntries { get; set; } = new HashSet<ProductItemEntity>();

    public ICollection<ProductCategoriesEntity> ProductCategories { get; set; } = new HashSet<ProductCategoriesEntity>();


    
}








