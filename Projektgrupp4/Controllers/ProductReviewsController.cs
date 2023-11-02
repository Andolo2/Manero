using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Projektgrupp4.Services;
using Projektgrupp4.ViewModels;

namespace Projektgrupp4.Controllers
{

    public class ProductReviewsController : Controller
	{

        private readonly ReviewsService _reviewService;

        public ProductReviewsController(ReviewsService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpGet]
        public async Task<IActionResult> ProductReviews(int articleNumber)
		{
            var reviews = await _reviewService.GetReviewsAsync(articleNumber);

            ProductReviewsViewModel viewModel = new ProductReviewsViewModel
            {
                Reviews = reviews
            };

            return View(viewModel);
		}


		public IActionResult LeaveAReview()
		{


            return View();
		}

		[HttpPost]
        public async Task<IActionResult> LeaveAReview(LeaveAReviewViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                await _reviewService.CreateReviewAsync(viewModel);

                return RedirectToAction("ProductDetail", "ProductDetail", new { viewModel.ArticleNumber });
            }

            return View(viewModel);
        }
    }
}
