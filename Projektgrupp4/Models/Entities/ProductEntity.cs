using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Projektgrupp4.Enum;
using Projektgrupp4.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Projektgrupp4.Models.Entities;

public class ProductEntity
{
    [Key]
    public int ArticleNumber { get; set; }
    public byte[] ProductImage { get; set; } = null!; // To save in database
    public string ProductTitle { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal ProductPrice { get; set; }

    [Column(TypeName = "money")]
    public decimal? ProductOfferPrice { get; set; }     
    public bool ProductPriceOrOffer { get; set; } = true;
                                                          
    public string? ProductDescription { get; set; } = null!;

    public ICollection<ReviewEntity> ProductReviews { get; set; } = new HashSet<ReviewEntity>();

    public ICollection<ProductItemEntity> ProductEntries { get; set; } = new HashSet<ProductItemEntity>();

    public ICollection<ProductCategoriesEntity> ProductCategories { get; set; } = new HashSet<ProductCategoriesEntity>();

  



}








