using Microsoft.AspNet.Mvc;

namespace dotnethelloworld.Controllers
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
