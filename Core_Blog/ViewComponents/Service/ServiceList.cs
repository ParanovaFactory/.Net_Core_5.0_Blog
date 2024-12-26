using BusinessLayer.Conrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Blog.ViewComponents.Service
{
    public class ServiceList : ViewComponent
    {
        ServiceManager manager = new ServiceManager(new EFServiceDal());

        public IViewComponentResult Invoke()
        {
            var values = manager.GetList();
            return View(values);
        }
    }
}
