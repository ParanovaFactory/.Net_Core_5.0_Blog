using BusinessLayer.Conrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Blog.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        FeatureManager manager = new FeatureManager(new EFFeatureDal());

        public IViewComponentResult Invoke()
        {
            var values = manager.GetList();
            return View(values);
        }
    }
}
