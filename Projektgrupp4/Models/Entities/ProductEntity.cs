using System.ComponentModel.DataAnnotations;

namespace Projektgrupp4.Models.Entities;

public class ProductEntity
{
    [Key]
    public int ArticleNumber { get; set; }
    public string? ProductImage { get; set; } = null!;
    public string ProductTitle { get; set; } = null!;

    public int ProductPrice { get; set; }
    public int? ProductOfferPrice { get; set; }     
    public bool ProductPriceOrOffer { get; set; } = true; //if(ProductPrice) else(ProductOff erPrice)
                                                          //if it is ProductOfferPrice, change classes on a product card. From ProductPrice to ProductOfferPrice
    public string? ProductDescription { get; set; } = null!;


    public ICollection<ProductCategoriesEntity> ProductCategories { get; set; } = new HashSet<ProductCategoriesEntity>();


    //Vart vi ska göra av dessa?

    //public int ProductRating { get; set; }
    //public string ProductSize { get; set; } = null!;      //Storlekar: XS, S, M, L, XL, XXL. Use a dropdown to choose a size?
    //public string ProductColor { get; set; } = null!;     //Färger, red, light-blue, beige, dark-blue and black. Use a dropdown to choose color size?
}








