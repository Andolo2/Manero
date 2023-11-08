using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Projektgrupp4.Models.Entities;
using Projektgrupp4.Services;
using Projektgrupp4.ViewModels;

namespace Projektgrupp4.Controllers
{

    public class ProductReviewsController : Controller
	{

        private readonly ReviewsService _reviewService;
        private readonly IAuthenticationService _authService;


        public ProductReviewsController(ReviewsService reviewService, IAuthenticationService authService)
        {
            _reviewService = reviewService;
            _authService = authService;
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

        [Authorize(Roles = "user")]
        public IActionResult LeaveAReview()
		{
            return View();
		}

		[HttpPost]
        public async Task<IActionResult> LeaveAReview(LeaveAReviewViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                var user = await _authService.GetUserAsync(User);
                if(user != null)
                {
                    await _reviewService.CreateReviewAsync(viewModel, user);
                }

                return RedirectToAction("ProductDetail", "ProductDetail", new { viewModel.ArticleNumber });
            }

            return View(viewModel);
        }
    }
}
