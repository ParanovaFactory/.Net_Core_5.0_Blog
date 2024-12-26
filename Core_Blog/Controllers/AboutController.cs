using BusinessLayer.Conrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Blog.Controllers
{
    public class AboutController : Controller
    {
        AboutManager _aboutManager = new AboutManager(new EFAboutDal());

        public IActionResult List()
        {
            ViewBag.v1 = "About";
            ViewBag.v2 = "About Us";
            var values = _aboutManager.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.v1 = "About";
            ViewBag.v2 = "Edit About";
            var value = _aboutManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Edit(About p)
        {
            _aboutManager.TUpdate(p);
            return RedirectToAction("List");
        }
    }
}
