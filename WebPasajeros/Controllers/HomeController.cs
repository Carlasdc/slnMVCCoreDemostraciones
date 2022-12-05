using Microsoft.AspNetCore.Mvc;

namespace WebPasajeros.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
