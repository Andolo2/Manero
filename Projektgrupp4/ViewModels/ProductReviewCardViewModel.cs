using Projektgrupp4.Models.Entities;

namespace Projektgrupp4.ViewModels;

public class ProductReviewCardViewModel
{
    public string Name { get; set; } = null!;
    public string Comment { get; set; } = null!;
    public DateTime Created {  get; set; }
    public int Rating { get; set; }

    public static implicit operator ProductReviewCardViewModel(ReviewEntity entity)
    {
        return new ProductReviewCardViewModel
        {
            Name = entity.Name,
            Comment = entity.Comment,
            Created = entity.Created,
            Rating = entity.Rating,
        };
    }
}
