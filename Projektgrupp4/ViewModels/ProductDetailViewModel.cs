namespace Projektgrupp4.ViewModels
{
	public class ProductDetailViewModel
	{
        public int ArticleNumber { get; set; }
        public string ProductTitle { get; set; } = null!;
        public decimal ProductPrice { get; set; }
        public decimal? ProductOfferPrice { get; set; }
        public bool ProductPriceOrOffer { get; set; }
        public string? ProductDescription { get; set; } = null!;

        public ICollection<ReviewEntity> ProductReviews { get; set; } = new HashSet<ReviewEntity>();

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
                ProductReviews = entity.ProductReviews,
                ProductEntries = entity.ProductEntries,
                ProductCategories = entity.ProductCategories
            };
        }

    }
}
