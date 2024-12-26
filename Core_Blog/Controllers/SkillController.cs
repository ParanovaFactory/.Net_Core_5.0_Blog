using BusinessLayer.Conrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Blog.Controllers
{
    public class SkillController : Controller
    {
        SkillManager _skillManager = new SkillManager(new EFSkillDal());

        public IActionResult List()
        {
            ViewBag.v1 = "Skill";
            ViewBag.v2 = "Skill List";
            var values = _skillManager.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.v1 = "Skill";
            ViewBag.v2 = "Add Skill";
            return View();
        }
        [HttpPost]
        public IActionResult Add(Skill p)
        {
            _skillManager.TAdd(p);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            var value = _skillManager.TGetById(id);
            _skillManager.TDelete(value);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.v1 = "Skill";
            ViewBag.v2 = "Edit Skill";
            var value = _skillManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Edit(Skill p)
        {
            _skillManager.TUpdate(p);
            return RedirectToAction("List");
        }
    }
}
