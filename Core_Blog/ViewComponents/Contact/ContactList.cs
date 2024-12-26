using BusinessLayer.Conrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Blog.ViewComponents.Contact
{
    public class ContactList :ViewComponent
    {
        ContactManager manager = new ContactManager(new EFContactDal());
        public IViewComponentResult Invoke()
        {
            var values = manager.GetList();
            return View(values);
        }
    }
}
