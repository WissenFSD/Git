using Microsoft.AspNetCore.Mvc;

namespace Git.Controllers
{
    public class EmreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
