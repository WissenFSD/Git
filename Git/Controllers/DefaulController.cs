using Microsoft.AspNetCore.Mvc;

namespace Git.Controllers
{
    public class DefaulController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
