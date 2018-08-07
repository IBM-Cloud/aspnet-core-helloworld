using Microsoft.AspNetCore.Mvc;

namespace dotnetHelloWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
