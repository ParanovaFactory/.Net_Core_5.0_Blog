using BusinessLayer.Conrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Blog.Controllers
{
    public class MessagesController : Controller
    {
        MessageManager messageManager = new MessageManager(new EFMessageDal());
        public IActionResult List()
        {
            ViewBag.v1 = "Message";
            ViewBag.v2 = "Message List";
            var values = messageManager.GetList();
            return View(values);
        }

        public IActionResult Delete(int id)
        {
            var value = messageManager.TGetById(id);
            messageManager.TDelete(value);
            return RedirectToAction("List");
        }
    }
}
