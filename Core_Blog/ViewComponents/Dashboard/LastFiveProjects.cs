using BusinessLayer.Conrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Blog.ViewComponents.Dashboard
{
    public class LastFiveProjects : ViewComponent
    {
        PortfolioManager _portfolioManager = new PortfolioManager(new EFPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values = _portfolioManager.GetList();
            return View(values);
        }
    }
}
