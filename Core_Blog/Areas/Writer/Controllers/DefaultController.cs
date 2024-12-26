using BusinessLayer.Conrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Blog.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DefaultController : Controller
    {
        AnnouncementManager manager = new AnnouncementManager(new EFAnnouncement());
        public IActionResult Index()
        {
            var values = manager.GetList();
            return View(values);
        }
    }
}
