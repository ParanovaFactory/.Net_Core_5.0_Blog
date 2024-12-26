using BusinessLayer.Conrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Blog.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager _portfolioManager = new PortfolioManager(new EFPortfolioDal());

        public IActionResult List()
        {
            ViewBag.v1 = "Portfolio";
            ViewBag.v2 = "Portfolio List";
            var values = _portfolioManager.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.v1 = "Portfolio";
            ViewBag.v2 = "Add Project";
            return View();
        }
        [HttpPost]
        public IActionResult Add(Portfolio p)
        {
            _portfolioManager.TAdd(p);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            var value = _portfolioManager.TGetById(id);
            _portfolioManager.TDelete(value);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.v1 = "Portfolio";
            ViewBag.v2 = "Edit Project";
            var value = _portfolioManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Edit(Portfolio p)
        {
            _portfolioManager.TUpdate(p);
            return RedirectToAction("List");
        }
    }
}
