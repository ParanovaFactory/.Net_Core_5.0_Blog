using BusinessLayer.Conrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Blog.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EFContactDal());

        public IActionResult List()
        {
            ViewBag.v1 = "Contact";
            ViewBag.v2 = "Contact List";
            var values = contactManager.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.v1 = "Contact";
            ViewBag.v2 = "Edit Contact";
            var value = contactManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Edit(Contact p)
        {
            contactManager.TUpdate(p);
            return RedirectToAction("List");
        }
    }
}
