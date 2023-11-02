using Microsoft.AspNetCore.Mvc;
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


        public IActionResult ProductReviews()
		{
			return View();
		}

        [HttpGet]
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

            }

            return View(viewModel);
        }
    }
}
