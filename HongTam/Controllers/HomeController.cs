using Microsoft.AspNetCore.Mvc;

namespace HongTam.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
