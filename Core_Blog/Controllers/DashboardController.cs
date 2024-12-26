using Microsoft.AspNetCore.Mvc;

namespace Core_Blog.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
