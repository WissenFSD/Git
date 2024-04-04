using Microsoft.AspNetCore.Mvc;

namespace Git.Controllers
{
	public class UgurController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
