using Microsoft.AspNetCore.Mvc;

namespace Projektgrupp4.Controllers
{
	public class ProductReviewsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
