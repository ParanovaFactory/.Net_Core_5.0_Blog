using BusinessLayer.Conrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Blog.Controllers
{
    public class TestmonialController : Controller
    {
        TestmonialManager manager = new TestmonialManager(new EFTestmonialDal());
        public IActionResult List()
        {
            ViewBag.v1 = "Testmonial";
            ViewBag.v2 = "Testmonial List";
            var values = manager.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.v1 = "Testmonial";
            ViewBag.v2 = "Add Testmonial";
            return View();
        }
        [HttpPost]
        public IActionResult Add(Testmonial p)
        {
            manager.TAdd(p);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            var value = manager.TGetById(id);
            manager.TDelete(value);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.v1 = "Testmonial";
            ViewBag.v2 = "Edit Testmonial";
            var value = manager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Edit(Testmonial p)
        {
            manager.TUpdate(p);
            return RedirectToAction("List");
        }
    }
}
