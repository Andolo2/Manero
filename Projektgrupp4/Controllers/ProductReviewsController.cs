using Microsoft.AspNetCore.Mvc;

namespace Projektgrupp4.Controllers
{
	public class ProductReviewsController : Controller
	{
		public IActionResult ProductReviews()
		{
			return View();
		}

		public IActionResult LeaveAReview()
		{
			return View();
		}
	}
}
