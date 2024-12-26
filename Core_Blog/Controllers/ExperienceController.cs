using BusinessLayer.Conrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Blog.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager _experienceManager = new ExperienceManager(new EFExperienceDal());

        public IActionResult List()
        {
            ViewBag.v1 = "Experience";
            ViewBag.v2 = "Experience List";
            var values = _experienceManager.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.v1 = "Experience";
            ViewBag.v2 = "Add Experience";
            return View();
        }
        [HttpPost]
        public IActionResult Add(Experience p)
        {
            _experienceManager.TAdd(p);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            var value = _experienceManager.TGetById(id);
            _experienceManager.TDelete(value);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.v1 = "Experience";
            ViewBag.v2 = "Edit Experience";
            var value = _experienceManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Edit(Experience p)
        {
            _experienceManager.TUpdate(p);
            return RedirectToAction("List");
        }
    }
}
