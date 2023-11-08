using Projektgrupp4.Models.Entities;

namespace Projektgrupp4.ViewModels
{
	public class ProductDetailViewModel
	{
        public int ArticleNumber { get; set; }
        public string ProductTitle { get; set; } = null!;
        public IFormFile? ProductImage { get; set; }
        public string? ProductImageBase64 { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal? ProductOfferPrice { get; set; }
        public bool ProductPriceOrOffer { get; set; }
        public string? ProductDescription { get; set; } = null!;

        public List<ProductReviewCardViewModel>? ProductReviews { get; set; }

        public double? AverageRating { get; set; }
        public ICollection<ProductItemEntity> ProductEntries { get; set; } = new HashSet<ProductItemEntity>();

        public ICollection<ProductCategoriesEntity> ProductCategories { get; set; } = new HashSet<ProductCategoriesEntity>();

        public List<SizeEntity>? ProductSizes { get; set; }

        public List<ColorEntity>? ProductColors { get; set; }

        public static implicit operator ProductDetailViewModel(ProductEntity entity)
        {
            return new ProductDetailViewModel
            {
                ArticleNumber = entity.ArticleNumber,
                ProductTitle = entity.ProductTitle,
                ProductPrice = entity.ProductPrice,
                ProductOfferPrice = entity.ProductOfferPrice,
                ProductDescription = entity.ProductDescription,
                ProductEntries = entity.ProductEntries,
                ProductCategories = entity.ProductCategories,
                ProductImageBase64 = Convert.ToBase64String(entity.ProductImage),
            };
        }

    }
}
