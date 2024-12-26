using Microsoft.AspNetCore.Mvc;

namespace Core_Blog.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
