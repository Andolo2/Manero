public class ProductCardViewModel
{
    public int? ArticleNumber { get; set; }
    public IFormFile? ProductImage { get; set; }
    public int Rating { get; set; }
    public string? ProductTitle { get; set; }
    public decimal ProductPrice { get; set; }
    public decimal? ProductOfferPrice { get; set; }
}