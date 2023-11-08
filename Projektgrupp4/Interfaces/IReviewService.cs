using Projektgrupp4.ViewModels;

namespace Projektgrupp4.Interfaces;

public interface IReviewService
{
    Task<List<ProductReviewCardViewModel>> GetReviewsAsync(int articleNumber);
}
