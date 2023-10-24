using System.ComponentModel.DataAnnotations;

namespace Projektgrupp4.Models.Entities;

public class ProductCategoriesEntity
{
    [Key]
    public int CategoryId { get; set; }

    public string CategoryBestSeller { get; set; } = null!;

    public string CategoryFeatured { get; set; } = null!;





    public string? ProductImage { get; set; } = null!;
    public string ProductTitle { get; set; } = null!;

    public int ProductPrice { get; set; }
    public int? ProductOfferPrice { get; set; }
    public bool ProductPriceOrOffer { get; set; } = true; //if(ProductPrice) else(ProductOff erPrice)
                                                          //if it is ProductOfferPrice, change classes on a product card. From ProductPrice to ProductOfferPrice
    public string? ProductDescription { get; set; } = null!;
}
