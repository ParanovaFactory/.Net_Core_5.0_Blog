using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Blog.ViewComponents.Dashboard
{
    public class DashboardStatistic : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Portfolios.Count();
            ViewBag.v2 = c.Skills.Count();
            ViewBag.v3 = c.Services.Count();
            return View();
        }
    }
}
