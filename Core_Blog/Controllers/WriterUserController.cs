using Microsoft.AspNetCore.Mvc;

namespace Core_Blog.Controllers
{
    public class WriterUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
