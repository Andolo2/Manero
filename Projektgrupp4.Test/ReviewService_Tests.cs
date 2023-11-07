
using Moq;
using Projektgrupp4.Models.Entities;
using Projektgrupp4.ViewModels;
using Projektgrupp4.Test;
using Xunit;
using Projektgrupp4.Interfaces;

namespace Projektgrupp4.Test;

public class ReviewService_Tests
{
    private readonly Mock<IReviewService> _reviewsServiceMock;


    public ReviewService_Tests()
    {
        _reviewsServiceMock = new Mock<IReviewService>();

    }

    [Fact]
    public async void GetReviewAsync_Should_Return_a_listof_ProductReviewCardViewModel()
    {
        //Arrange
        var productEntity = new ProductEntity() { ArticleNumber = 1, ProductTitle = "Test", ProductPrice = 32, ProductDescription = "test" };

        _reviewsServiceMock.Setup(x => x.GetReviewsAsync(productEntity.ArticleNumber)).ReturnsAsync(new List<ProductReviewCardViewModel>());


        //act
        var result = await _reviewsServiceMock.Object.GetReviewsAsync(productEntity.ArticleNumber);

        //Assert
        Assert.IsType<List<ProductReviewCardViewModel>>(result);
    }
}
