using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Contexts;
using Projektgrupp4.Models.Entities;
using Projektgrupp4.ViewModels;

namespace Projektgrupp4.Services;

public class ReviewsService
{
    private readonly DataContext _dataContext;

    public ReviewsService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<bool> CreateReviewAsync(LeaveAReviewViewModel viewModel)
    {
        try
        {
            var entity = new ReviewEntity
            {
                Name = "Temp Name",
                ProductId = viewModel.ArticleNumber,
                Created = viewModel.Created,
                Rating = viewModel.Rating,
                Comment = viewModel.Comment,

                
            };

            _dataContext.Reviews.Add(entity);
            await _dataContext.SaveChangesAsync();

            return true;

        } catch (Exception ex)
        {
            return false;
        }
    }

    public async Task<List<ProductReviewCardViewModel>> GetReviewsAsync(int articleNumber)
    {
        try
        {
            var reviews = await _dataContext.Reviews.Where(x => x.ProductId == articleNumber).ToListAsync();
            var reviewList = new List<ProductReviewCardViewModel>();
            if (reviews.Any())
            {
                foreach (var review in reviews)
                {
                    reviewList.Add(review);
                }

                return reviewList;

            }

            return null!;
            
        }
        catch (Exception ex) { return null!; }
    }

    public async Task<double?> GetAverageRatingAsync(int articleNumber)
    {
        try
        {
            var averageRating = await _dataContext.Reviews.Where(x => x.ProductId == articleNumber).AverageAsync(x => x.Rating);

            return averageRating;

        }
        catch
        {
            return null!;
        }
    }
}
