using Projektgrupp4.Models.Entities;

namespace Projektgrupp4.ViewModels;

public class ProductReviewsViewModel
{
    public int ArticleNumber { get; set; }
    public List<ProductReviewCardViewModel> Reviews { get; set; }


}
