using BusinessLayer.Conrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Blog.ViewComponents.Skill
{
    public class SkillList : ViewComponent
    {
        SkillManager manager = new SkillManager(new EFSkillDal());

        public IViewComponentResult Invoke()
        {
            var values = manager.GetList();
            return View(values);
        }

    }
}
