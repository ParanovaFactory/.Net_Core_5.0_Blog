using BusinessLayer.Conrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Blog.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager _serviceManager = new ServiceManager(new EFServiceDal());

        public IActionResult List()
        {
            ViewBag.v1 = "Service";
            ViewBag.v2 = "Service List";
            var values = _serviceManager.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.v1 = "Service";
            ViewBag.v2 = "Add Service";
            return View();
        }
        [HttpPost]
        public IActionResult Add(Service p)
        {
            _serviceManager.TAdd(p);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            var value = _serviceManager.TGetById(id);
            _serviceManager.TDelete(value);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.v1 = "Service";
            ViewBag.v2 = "Edit Service";
            var value = _serviceManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Edit(Service p)
        {
            _serviceManager.TUpdate(p);
            return RedirectToAction("List");
        }
    }
}
