using Projektgrupp4.Models.Entities;

namespace Projektgrupp4.ViewModels
{
    //Använd för att visa flera produkter på en sida
    public class ProductListViewModel
    {
        public int ArticleNumber { get; set; }
        public string? ProductImageUrl { get; set; }
        public string? ProductTitle { get; set; }
        public decimal? ProductPrice { get; set; }
        public decimal? ProductOfferPrice { get; set; }
        public bool? ProductPriceOrOffer { get; set; }
        public string? ProductDescription { get; set; }
        public List<ReviewEntity>? ProductReviews { get; set; }
        public List<ProductItemEntity>? ProductEntries { get; set; }
        public List<ProductCategoriesEntity>? ProductCategories { get; set; }
    }
}
