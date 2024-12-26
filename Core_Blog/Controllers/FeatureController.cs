using BusinessLayer.Conrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Core_Blog.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager _featureManager = new FeatureManager(new EFFeatureDal());
        FeatureValidator validationRules = new FeatureValidator();

        public IActionResult List()
        {
            ViewBag.v1 = "Feature";
            ViewBag.v2 = "Feature Info";
            var values = _featureManager.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.v1 = "Feature";
            ViewBag.v2 = "Edit Feature";
            var value = _featureManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Edit(Feature p)
        {
            ValidationResult validationResult = validationRules.Validate(p);
            if (validationResult.IsValid)
            {
                _featureManager.TUpdate(p);
                return RedirectToAction("List");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }
    }
}
