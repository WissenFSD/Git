using Microsoft.AspNetCore.Mvc;

namespace Git.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
