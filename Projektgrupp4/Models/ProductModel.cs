namespace Projektgrupp4.Models
{
    public class ProductModel
    {
        public int ArticleNumber { get; set; }

        public string? ProductImage { get; set; } = null!;
        public string ProductTitle { get; set; } = null!;

        public int ProductPrice { get; set; }
        public int? ProductOfferPrice { get; set; }
        public bool ProductPriceOrOffer { get; set; } = true; 
                                                             
        public string? ProductDescription { get; set; } = null!;
    }
}
