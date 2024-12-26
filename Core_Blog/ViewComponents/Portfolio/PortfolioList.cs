using BusinessLayer.Conrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Blog.ViewComponents.Portfolio
{
    public class PortfolioList :ViewComponent
    {
        PortfolioManager manager = new PortfolioManager(new EFPortfolioDal());

        public IViewComponentResult Invoke()
        {
            var values = manager.GetList();
            return View(values);
        }
    }
}
