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
}
