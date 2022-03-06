using Microsoft.AspNetCore.Mvc;

namespace phantom.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
