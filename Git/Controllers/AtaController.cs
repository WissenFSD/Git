using Microsoft.AspNetCore.Mvc;

namespace Git.Controllers
{
	public class AtaController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
