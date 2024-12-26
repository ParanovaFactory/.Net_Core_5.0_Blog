using BusinessLayer.Conrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_Blog.Controllers
{
    public class ShowCase : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult MessagePartial() 
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult MessagePartial(Message p)
        {
            MessageManager manager = new MessageManager(new EFMessageDal());
            p.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.MessageStatus = true;
            manager.TAdd(p);
            return PartialView();
        }
    }
}
