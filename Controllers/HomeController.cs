using Microsoft.AspNetCore.Mvc;

namespace Eseries.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
