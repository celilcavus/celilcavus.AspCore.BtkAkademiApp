using Microsoft.AspNetCore.Mvc;

namespace BtkAkademi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
