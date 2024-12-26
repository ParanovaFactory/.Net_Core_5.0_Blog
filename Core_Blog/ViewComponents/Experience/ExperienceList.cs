using BusinessLayer.Conrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Blog.ViewComponents.Experience
{
    public class ExperienceList : ViewComponent
    {
        ExperienceManager manager = new ExperienceManager(new EFExperienceDal());
        public IViewComponentResult Invoke()
        {
            var values = manager.GetList();
            return View(values);
        }
    }
}
