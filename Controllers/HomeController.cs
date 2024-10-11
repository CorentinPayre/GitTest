using Microsoft.AspNetCore.Mvc;

namespace GitTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
