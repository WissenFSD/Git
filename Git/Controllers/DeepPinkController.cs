using Microsoft.AspNetCore.Mvc;

namespace Git.Controllers
{
	public class DeepPinkController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
