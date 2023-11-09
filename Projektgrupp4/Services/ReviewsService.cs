using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Contexts;
using Projektgrupp4.Models.Entities;
using Projektgrupp4.ViewModels;
using System.Diagnostics;

namespace Projektgrupp4.Services;

public class ReviewsService
{
    private readonly DataContext _dataContext;

    public ReviewsService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<bool> CreateReviewAsync(LeaveAReviewViewModel viewModel, UserEntity user)
    {
        try
        {
            var entity = new ReviewEntity
            {
                Name = user.Name,
                ProductId = viewModel.ArticleNumber,
                Created = viewModel.Created,
                Rating = viewModel.Rating,
                Comment = viewModel.Comment,

                
            };

            _dataContext.Reviews.Add(entity);
            await _dataContext.SaveChangesAsync();

            return true;

        } catch(Exception ex)
        {
            Debug.WriteLine(ex);
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
        catch { return null!; }
    }

    public async Task<double?> GetAverageRatingAsync(int articleNumber)
    {
        try
        {
            var reviews = await _dataContext.Reviews.Where(x => x.ProductId == articleNumber).ToListAsync();

            if (reviews.Any())
            {
                var averageRating = reviews.Average(x => x.Rating);
                return averageRating;
            }

            return null!;

        }
        catch
        {
            return null!;
        }
    }

}
