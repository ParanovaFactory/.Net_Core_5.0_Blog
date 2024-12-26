using BusinessLayer.Conrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Blog.ViewComponents.Testmonial
{
    public class TestmonialList : ViewComponent
    {
        TestmonialManager manager = new TestmonialManager(new EFTestmonialDal());
        public IViewComponentResult Invoke()
        {
            var values = manager.GetList();
            return View(values);
        }
    }
}
