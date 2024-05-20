using Microsoft.AspNetCore.Mvc;

namespace Anyar.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
